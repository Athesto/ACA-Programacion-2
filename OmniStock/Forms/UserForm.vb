Public Class UserForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dao As New UserDAO()
        dao.Insert(txtEmail.Text, txtPassword.Text, cmbRole.SelectedItem.ToString())
    End Sub
End Class