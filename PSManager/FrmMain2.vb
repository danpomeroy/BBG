Imports DevExpress.Utils
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors

Public Class FrmMain2

    Private Sub CheckTransition()
        If TransitionManager1.IsTransition Then TransitionManager1.EndTransition()
        'If Not _ctrl Is Nothing Then _ctrl.Visible = False
    End Sub
    Private Sub TileBarItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        CheckTransition()

        'TransitionManager1.StartTransition(PnlMain)
        'Dim uc As New UcSearch
        'uc.Parent = PnlMain
        'uc.Dock = DockStyle.Fill
        'uc.Width = Me.Width
        'uc.Visible = True

        'TransitionManager1.EndTransition()
        ''LblLocation.Text = "Search"
        'CheckTransition()
    End Sub

    Private Sub TileBarItem1_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        'TileBar1.Text = TbiPawn.Text
    End Sub

    Private Sub FrmMain2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TbiPawn.PerformItemClick()

    End Sub

    Private Sub TileBarItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        'TileBar1.Text = TbiSell.Text
    End Sub

    Private Sub test()
    End Sub


    Private Sub TileBarItem1_ItemPress(sender As Object, e As TileItemEventArgs)

    End Sub

    Private Sub TileBar1_ItemClick(sender As Object, e As TileItemEventArgs)

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SetupControls()
    End Sub

    Private Sub SetupControls()
        'TbiPawn.AppearanceItem.Normal.BackColor = ColorHelper.LightRed
        'TbiSell.AppearanceItem.Normal.BackColor = ColorHelper.LightGreen
        PnlBottom.BackColor = ColorHelper.DarkGrey
    End Sub
End Class