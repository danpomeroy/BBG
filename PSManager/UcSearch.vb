Public Class UcSearch

    Private Sub BtnClear_Click(sender As Object, e As EventArgs)
        TxtPawnTicketNumber.Text = String.Empty
        TxtDriversLicenseNumber.Text = String.Empty
        TxtFistName.Text = String.Empty
        TxtLastName.Text = String.Empty
        TxtPhoneNumber.Text = String.Empty
        TxtStreetAddress.Text = String.Empty
        TxtState.Text = String.Empty
        TxtCity.Text = String.Empty
        TxtZip.Text = String.Empty
    End Sub


    Private Function CanSearch() As Boolean
        Return Not (TxtPawnTicketNumber.Text.Trim = String.Empty AndAlso _
                TxtDriversLicenseNumber.Text.Trim = String.Empty AndAlso _
                TxtFistName.Text.Trim = String.Empty AndAlso _
                TxtLastName.Text.Trim = String.Empty AndAlso _
                TxtPhoneNumber.Text.Trim = String.Empty AndAlso _
                TxtStreetAddress.Text.Trim = String.Empty AndAlso _
                TxtState.Text.Trim = String.Empty AndAlso _
                TxtCity.Text.Trim = String.Empty AndAlso _
                TxtZip.Text.Trim = String.Empty)
    End Function

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class
