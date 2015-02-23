Imports System.Media

''' <copyright file="MetroMessageBox.vb" company="BBG Software">
''' Copyright (c) February 20, 2015 08:00 PM All Right Reserved
''' </copyright>
''' <author>Danny Pomeroy</author>
''' <date>February 20, 2015 08:00 PM</date>
''' <summary>A form used in the representation of a message box with the "Metro" styling.</summary>
Friend Class FrmMetroMessageBox
#Region " Variables "
    Private ReadOnly _red As Color = Color.FromArgb(209, 17, 65)
    Private ReadOnly _green As Color = Color.FromArgb(0, 177, 89)
    Private ReadOnly _blue As Color = Color.FromArgb(0, 174, 219)
    Private ReadOnly _orange As Color = Color.FromArgb(243, 119, 53)
    Private ReadOnly _yellow As Color = Color.FromArgb(255, 196, 37)
    Private _sound As Sounds
#End Region

#Region " Enums "
    ''' <summary>
    ''' A list of the system sounds
    ''' </summary>
    ''' <remarks>Used to know which sound to play when the message box is shown.</remarks>
    Private Enum Sounds
        Asterick
        Beep
        Exclamation
        Hand
        Question
    End Enum
#End Region

#Region " Properties "
    ''' <summary>
    ''' An implementation of IWin32Window that will own the modal dialog box.
    ''' </summary>
    Private Overloads WriteOnly Property Owner As IWin32Window
        Set(value As IWin32Window)
            If Not value Is Nothing Then
                Dim myOwner As Control = DirectCast(value, Control)
                If myOwner.Width > Me.Width Then
                    Me.Width = myOwner.ClientSize.Width
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' The text to display in the message box.
    ''' </summary>
    Private Overloads WriteOnly Property Text As String
        Set(value As String)
            LblMessage.Text = value
        End Set
    End Property

    ''' <summary>
    ''' The text to display in the title bar of the message box.
    ''' </summary>
    Private WriteOnly Property Caption As String
        Set(value As String)
            LblTitle.Text = value.Trim()
            TableLayoutPanel2.RowStyles(0).SizeType = SizeType.Absolute
            TableLayoutPanel2.RowStyles(1).SizeType = SizeType.Absolute
            TableLayoutPanel2.RowStyles(2).SizeType = SizeType.Absolute
            TableLayoutPanel2.RowStyles(3).SizeType = SizeType.Percent
            TableLayoutPanel2.RowStyles(4).SizeType = SizeType.Absolute

            TableLayoutPanel2.RowStyles(0).Height = 20
            TableLayoutPanel2.RowStyles(1).Height = 40
            TableLayoutPanel2.RowStyles(2).Height = 20
            TableLayoutPanel2.RowStyles(3).Height = 100
            TableLayoutPanel2.RowStyles(4).Height = 20

            If LblTitle.Text.Length = 0 Then
                TableLayoutPanel2.RowStyles(0).Height = 0
                TableLayoutPanel2.RowStyles(1).Height = 0
                TableLayoutPanel2.RowStyles(2).Height = 0
            End If
        End Set
    End Property

    ''' <summary>
    ''' One of the <c>MessageBoxButtons</c> values that specifies which buttons to display in the message box.
    ''' </summary>
    Private WriteOnly Property Buttons As MessageBoxButtons
        Set(value As MessageBoxButtons)
            Dim bCount As Integer
            Select Case value
                Case MessageBoxButtons.AbortRetryIgnore
                    Btn1.Text = "Abort"
                    Btn1.DialogResult = DialogResult.Abort
                    Btn2.Text = "Retry"
                    Btn2.DialogResult = DialogResult.Retry
                    Btn3.Text = "Ignore"
                    Btn3.DialogResult = DialogResult.Ignore
                    bCount = 3
                Case MessageBoxButtons.OKCancel
                    Btn1.Text = "OK"
                    Btn1.DialogResult = DialogResult.OK
                    Btn2.Text = "Cancel"
                    Btn2.DialogResult = DialogResult.Cancel
                    bCount = 2
                Case MessageBoxButtons.RetryCancel
                    Btn1.Text = "Retry"
                    Btn1.DialogResult = DialogResult.Retry
                    Btn2.Text = "Cancel"
                    Btn2.DialogResult = DialogResult.Cancel
                    bCount = 2
                Case MessageBoxButtons.YesNo
                    Btn1.Text = "Yes"
                    Btn1.DialogResult = DialogResult.Yes
                    Btn2.Text = "No"
                    Btn2.DialogResult = DialogResult.No
                    bCount = 2
                Case MessageBoxButtons.YesNoCancel
                    Btn1.Text = "Yes"
                    Btn1.DialogResult = DialogResult.Yes
                    Btn2.Text = "No"
                    Btn2.DialogResult = DialogResult.No
                    Btn3.Text = "Cancel"
                    Btn3.DialogResult = DialogResult.Cancel
                    bCount = 3
                Case Else
                    Btn1.Text = "OK"
                    Btn1.DialogResult = DialogResult.OK
                    bCount = 1
            End Select

            TableLayoutPanel1.ColumnStyles(0).SizeType = SizeType.Percent
            TableLayoutPanel1.ColumnStyles(1).SizeType = SizeType.Absolute
            TableLayoutPanel1.ColumnStyles(2).SizeType = SizeType.Absolute
            TableLayoutPanel1.ColumnStyles(3).SizeType = SizeType.Absolute
            TableLayoutPanel1.ColumnStyles(4).SizeType = SizeType.Absolute
            TableLayoutPanel1.ColumnStyles(5).SizeType = SizeType.Absolute
            TableLayoutPanel1.ColumnStyles(6).SizeType = SizeType.Percent

            TableLayoutPanel1.ColumnStyles(0).Width = 50
            TableLayoutPanel1.ColumnStyles(1).Width = 120
            TableLayoutPanel1.ColumnStyles(2).Width = 20
            TableLayoutPanel1.ColumnStyles(3).Width = 120
            TableLayoutPanel1.ColumnStyles(4).Width = 20
            TableLayoutPanel1.ColumnStyles(5).Width = 120
            TableLayoutPanel1.ColumnStyles(6).Width = 50

            If bCount < 3 Then
                TableLayoutPanel1.ColumnStyles(4).Width = 0
                TableLayoutPanel1.ColumnStyles(5).Width = 0
            End If
            If bCount < 2 Then
                TableLayoutPanel1.ColumnStyles(2).Width = 0
                TableLayoutPanel1.ColumnStyles(3).Width = 0
            End If
        End Set
    End Property

    ''' <summary>
    ''' One of the <c>MessageBoxIcon</c> values that specifies which icon to display in the message box.
    ''' </summary>
    Private Overloads WriteOnly Property Icon As MessageBoxIcon
        Set(value As MessageBoxIcon)
            Select Case value
                Case 0 'MessageBoxIcon.None
                    BackColor = _green
                    _sound = Sounds.Beep
                Case 16 ' MessageBoxIcon.Stop, MessageBoxIcon.Error, MessageBoxIcon.Hand
                    BackColor = _red
                    _sound = Sounds.Hand
                Case 32 ' MessageBoxIcon.Question
                    BackColor = _orange
                    _sound = Sounds.Question
                Case 48 ' MessageBoxIcon.Warning
                    BackColor = _yellow
                    _sound = Sounds.Exclamation
                Case 64 'MessageBoxIcon.Asterisk
                    BackColor = _blue
                    _sound = Sounds.Asterick
            End Select
        End Set
    End Property

    ''' <summary>
    ''' One of the <c>MessageBoxDefaultButton</c> values that specifies the default button for the message box.
    ''' </summary>
    Private WriteOnly Property DefaultButton As MessageBoxDefaultButton
        Set(value As MessageBoxDefaultButton)
            Select Case value
                Case MessageBoxDefaultButton.Button2
                    Btn2.Focus()
                Case MessageBoxDefaultButton.Button3
                    Btn3.Focus()
                Case Else
                    Btn1.Focus()
            End Select
        End Set
    End Property
#End Region

#Region " Methods "
    ''' <summary>
    ''' Displays a message box in front of the specified object and with the specified text, caption, buttons, icon, and default button.
    ''' </summary>
    ''' <param name="owner">An implementation of IWin32Window that will own the modal dialog box.</param>
    ''' <param name="text">The text to display in the message box.</param>
    ''' <param name="caption">The text to display in the title bar of the message box.</param>
    ''' <param name="buttons">One of the <c>MessageBoxButtons</c> values that specifies which buttons to display in the message box.</param>
    ''' <param name="icon">One of the <c>MessageBoxIcon</c> values that specifies which icon to display in the message box.</param>
    ''' <param name="defaultButton">One of the <c>MessageBoxDefaultButton</c> values that specifies the default button for the message box.</param>
    Public Sub New(owner As IWin32Window, text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton)

        ' This call is required by the designer.
        InitializeComponent()

        Me.Owner = owner
        Me.Text = text
        Me.Caption = caption
        Me.Buttons = buttons
        Me.Icon = icon
        Me.DefaultButton = defaultButton
    End Sub

    Private Sub FrmMetroMessageBox_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' play the appropriate sound
        Select Case _sound
            Case Sounds.Asterick
                SystemSounds.Asterisk.Play()
            Case Sounds.Beep
                SystemSounds.Beep.Play()
            Case Sounds.Exclamation
                SystemSounds.Exclamation.Play()
            Case Sounds.Hand
                SystemSounds.Hand.Play()
            Case Sounds.Question
                SystemSounds.Question.Play()
        End Select
    End Sub
#End Region
End Class