Public Class UserForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rnd As New Random()
        Dim rndValue = rnd.Next(1000, 9999)
        txtEmail.Text = "user" & rndValue
        txtPassword.Text = rndValue
        cmbRole.Text = "client"

        Dim dao As New UserDAO()
        dao.Insert(txtEmail.Text, txtPassword.Text, cmbRole.SelectedItem.ToString())
    End Sub
End Class