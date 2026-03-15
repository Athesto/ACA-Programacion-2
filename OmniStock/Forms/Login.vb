Imports MySql.Data.MySqlClient
Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dao As New UserDAO()
        txtEmail.Text = "admin@omnistock.com"
        txtPassword.Text = "admin123"

        If Not dao.ValidateLogin(txtEmail.Text, txtPassword.Text) Then
            MessageBox.Show("Credenciales inválidas")
            Exit Sub
        End If

        MessageBox.Show("Bienvenido")
        Me.Hide()
        Dim controlPanel As New ControlPanel()
        controlPanel.ShowDialog()
        Me.Close()
    End Sub
End Class