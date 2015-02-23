Imports System.Media

Public Class FrmSearch
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TileBarItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TbiOk.ItemClick
        DialogResult = DialogResult.OK
    End Sub

    Private Sub FrmSearch_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SystemSounds.Asterisk.Play()
    End Sub

    Private Sub TileBarItem1_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TbiCancel.ItemClick
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub TbiClear_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TbiClear.ItemClick
        TextEdit1.Text = String.Empty
        TextEdit2.Text = String.Empty
        TextEdit3.Text = String.Empty
        TextEdit4.Text = String.Empty
        TextEdit5.Text = String.Empty
        TextEdit6.Text = String.Empty
        TextEdit7.Text = String.Empty
        TextEdit8.Text = String.Empty
        TextEdit9.Text = String.Empty
    End Sub
End Class