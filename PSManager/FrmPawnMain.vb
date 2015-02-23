Imports MetroFramework
Imports MetroFramework.Components

Public Class FrmPawnMain

    Private Sub FrmPawnMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TileNavPane1.Appearance.BackColor = ColorHelper.DarkGrey
        TileNavPane2.Appearance.BackColor = ColorHelper.DarkGrey
        TbiPawn.AppearanceItem.Normal.BackColor = ColorHelper.LightTurquoise
        TbiSell.AppearanceItem.Normal.BackColor = ColorHelper.LightOrange
        TbiInventory.AppearanceItem.Normal.BackColor = ColorHelper.LightPurple
        TileBar1.SelectionColor = ColorHelper.DarkGrey

        'TileBarItem2
    End Sub

    Private Sub BtnAbout_ElementClick(sender As Object, e As DevExpress.XtraBars.Navigation.NavElementEventArgs) Handles BtnAbout.ElementClick
        MetroMessageBox.Show("This is where the about box will be!", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub BtnSettings_ElementClick(sender As Object, e As DevExpress.XtraBars.Navigation.NavElementEventArgs) Handles BtnSettings.ElementClick
        MetroMessageBox.Show(Me, "This is where the settings will be.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub TileBar1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileBar1.ItemClick
        NavButton2.Caption = e.Item.Text


    End Sub

    Private Sub CheckTransition()
        If TransitionManager1.IsTransition Then TransitionManager1.EndTransition()
        'If Not _ctrl Is Nothing Then _ctrl.Visible = False
    End Sub

    Private Sub TileBar1_Click(sender As Object, e As EventArgs) Handles TileBar1.Click

    End Sub

    Private Sub TbiSell_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TbiSell.ItemClick
        CheckTransition()
        TransitionManager1.StartTransition(PnlMain)
        Dim uc As UcSearch = Nothing
        For Each item As Control In PnlMain.Controls
            item.Visible = False
            If TypeOf item Is UcSearch Then uc = item
        Next

        If uc Is Nothing Then uc = New UcSearch()
        uc.Parent = PnlMain
        uc.Dock = DockStyle.Fill
        uc.Width = Me.Width
        uc.Visible = True

        TransitionManager1.EndTransition()

        CheckTransition()
    End Sub

    Private Sub TbiPawn_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TbiPawn.ItemClick
        CheckTransition()
        TransitionManager1.StartTransition(PnlMain)
        Dim uc As UcPawn = Nothing
        For Each item As Control In PnlMain.Controls
            item.Visible = False
            If TypeOf item Is UcPawn Then uc = item
        Next

        If uc Is Nothing Then uc = New UcPawn()
        uc.Parent = PnlMain
        uc.Dock = DockStyle.Fill
        uc.Width = Me.Width
        uc.Visible = True
        Application.DoEvents()
        TransitionManager1.EndTransition()

        CheckTransition()
    End Sub

    Private Sub TbiReports_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TbiReports.ItemClick

        CheckTransition()
        TransitionManager1.StartTransition(PnlMain)
        Dim uc As UcReport = Nothing
        For Each item As Control In PnlMain.Controls
            item.Visible = False
            If TypeOf item Is UcReport Then uc = item
        Next

        If uc Is Nothing Then uc = New UcReport()
        uc.Parent = PnlMain
        uc.Dock = DockStyle.Fill
        uc.Width = Me.Width
        uc.Visible = True
        Application.DoEvents()
        TransitionManager1.EndTransition()

        CheckTransition()
    End Sub

    Private Sub FrmPawnMain_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave

    End Sub

    Private Sub FrmPawnMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        TbiPawn.PerformItemClick()
    End Sub


    Private Sub TbiInventory_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TbiInventory.ItemClick
        ColorHelper.SetNextPallete()
        TbiPawn.AppearanceItem.Normal.BackColor = ColorHelper.Color1
        TbiSell.AppearanceItem.Normal.BackColor = ColorHelper.Color2
        TbiInventory.AppearanceItem.Normal.BackColor = ColorHelper.Color3
        TbiReports.AppearanceItem.Normal.BackColor = ColorHelper.Color4
    End Sub
End Class