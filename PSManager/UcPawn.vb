Public Class UcPawn

    Private Sub TileBarItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TbiSearch.ItemClick
        Try
            Using frm As New FrmSearch
                frm.Width = Me.ClientSize.Width
                frm.ShowDialog(Me)
            End Using
        Catch ex As Exception
            End Try
    End Sub

    Private Sub UcPawn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XtraTabControl1.BackColor = Me.BackColor
        XtraTabPage1.BackColor = Me.BackColor
    End Sub
End Class
