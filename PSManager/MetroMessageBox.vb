''' <copyright file="MetroMessageBox.vb" company="BBG Software">
''' Copyright (c) February 20, 2015 08:00 PM All Right Reserved
''' </copyright>
''' <author>Danny Pomeroy</author>
''' <date>February 20, 2015 08:00 PM</date>
''' <summary>A module representing a message box with the "Metro" styling.</summary>
Friend Module MetroMessageBox
    ''' <summary>
    ''' Displays a metro style message box with specified text.
    ''' </summary>
    ''' <param name="text">The text to display in the message box.</param>
    Public Function Show(text As String) As DialogResult
        Return Show(text, "")
    End Function
    ''' <summary>
    ''' Displays a metro style message box in front of the specified object and with the specified text.
    ''' </summary>
    ''' <param name="owner">An implementation of IWin32Window that will own the modal dialog box.</param>
    ''' <param name="text">The text to display in the message box.</param>
    Public Function Show(owner As IWin32Window, text As String) As DialogResult
        Return Show(owner, text, "")
    End Function
    ''' <summary>
    ''' Displays a metro style message box with specified text and caption.
    ''' </summary>
    ''' <param name="text">The text to display in the message box.</param>
    ''' <param name="caption">The text to display in the title bar of the message box.</param>
    Public Function Show(text As String, caption As String) As DialogResult
        Return Show(text, caption, MessageBoxButtons.OK)
    End Function
    ''' <summary>
    ''' Displays a metro style message box in front of the specified object and with the specified text and caption.
    ''' </summary>
    ''' <param name="owner">An implementation of IWin32Window that will own the modal dialog box.</param>
    ''' <param name="text">The text to display in the message box.</param>
    ''' <param name="caption">The text to display in the title bar of the message box.</param>
    Public Function Show(owner As IWin32Window, text As String, caption As String) As DialogResult
        Return Show(owner, text, caption, MessageBoxButtons.OK)
    End Function
    ''' <summary>
    ''' Displays a metro style message box with specified text, caption, and buttons.
    ''' </summary>
    ''' <param name="text">The text to display in the message box.</param>
    ''' <param name="caption">The text to display in the title bar of the message box.</param>
    ''' <param name="buttons">One of the <c>MessageBoxButtons</c> values that specifies which buttons to display in the message box.</param>
    Public Function Show(text As String, caption As String, buttons As MessageBoxButtons) As DialogResult
        Return Show(text, caption, buttons, MessageBoxIcon.Information)
    End Function
    ''' <summary>
    ''' Displays a metro style message box in front of the specified object and with the specified text, caption, and buttons.
    ''' </summary>
    ''' <param name="owner">An implementation of IWin32Window that will own the modal dialog box.</param>
    ''' <param name="text">The text to display in the message box.</param>
    ''' <param name="caption">The text to display in the title bar of the message box.</param>
    ''' <param name="buttons">One of the <c>MessageBoxButtons</c> values that specifies which buttons to display in the message box.</param>
    Public Function Show(owner As IWin32Window, text As String, caption As String, buttons As MessageBoxButtons) As DialogResult
        Return Show(owner, text, caption, buttons, MessageBoxIcon.Information)
    End Function
    ''' <summary>
    ''' Displays a metro style message box with specified text, caption, buttons, and icon.
    ''' </summary>
    ''' <param name="text">The text to display in the message box.</param>
    ''' <param name="caption">The text to display in the title bar of the message box.</param>
    ''' <param name="buttons">One of the <c>MessageBoxButtons</c> values that specifies which buttons to display in the message box.</param>
    ''' <param name="icon">One of the <c>MessageBoxIcon</c> values that specifies which icon to display in the message box.</param>
    Public Function Show(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon) As DialogResult
        Return Show(text, caption, buttons, icon, MessageBoxDefaultButton.Button1)
    End Function
    ''' <summary>
    ''' Displays a metro style message box in front of the specified object and with the specified text, caption, buttons, and icon.
    ''' </summary>
    ''' <param name="owner">An implementation of IWin32Window that will own the modal dialog box.</param>
    ''' <param name="text">The text to display in the message box.</param>
    ''' <param name="caption">The text to display in the title bar of the message box.</param>
    ''' <param name="buttons">One of the <c>MessageBoxButtons</c> values that specifies which buttons to display in the message box.</param>
    ''' <param name="icon">One of the <c>MessageBoxIcon</c> values that specifies which icon to display in the message box.</param>
    Public Function Show(owner As IWin32Window, text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon) As DialogResult
        Return Show(owner, text, caption, buttons, icon, MessageBoxDefaultButton.Button1)
    End Function
    ''' <summary>
    ''' Displays a metro style message box with the specified text, caption, buttons, icon, and default button.
    ''' </summary>
    ''' <param name="text">The text to display in the message box.</param>
    ''' <param name="caption">The text to display in the title bar of the message box.</param>
    ''' <param name="buttons">One of the <c>MessageBoxButtons</c> values that specifies which buttons to display in the message box.</param>
    ''' <param name="icon">One of the <c>MessageBoxIcon</c> values that specifies which icon to display in the message box.</param>
    ''' <param name="defaultButton">One of the <c>MessageBoxDefaultButton</c> values that specifies the default button for the message box.</param>
    Public Function Show(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton) As DialogResult
        Return Show(Nothing, text, caption, buttons, icon, defaultButton)
    End Function
    ''' <summary>
    ''' Displays a metro style message box in front of the specified object and with the specified text, caption, buttons, icon, and default button.
    ''' </summary>
    ''' <param name="owner">An implementation of IWin32Window that will own the modal dialog box.</param>
    ''' <param name="text">The text to display in the message box.</param>
    ''' <param name="caption">The text to display in the title bar of the message box.</param>
    ''' <param name="buttons">One of the <c>MessageBoxButtons</c> values that specifies which buttons to display in the message box.</param>
    ''' <param name="icon">One of the <c>MessageBoxIcon</c> values that specifies which icon to display in the message box.</param>
    ''' <param name="defaultButton">One of the <c>MessageBoxDefaultButton</c> values that specifies the default button for the message box.</param>
    Public Function Show(owner As IWin32Window, text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton) As DialogResult
        Using frm As New FrmMetroMessageBox(owner, text, caption, buttons, icon, defaultButton)
            Return frm.ShowDialog(owner)
        End Using
    End Function
End Module

