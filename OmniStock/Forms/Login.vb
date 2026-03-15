Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using conn As MySqlConnection = Connection.GetConnection()
                Dim sql As String =
                    "SELECT id, email, rol FROM users WHERE email = @email AND pass = @pass"

                Dim dataEmail As String = "admin@omnistock.com"
                Dim dataPass As String = "admin123"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@email", dataEmail)
                    cmd.Parameters.AddWithValue("@pass", dataPass)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            MessageBox.Show("Login correcto")
                        Else
                            MessageBox.Show("Credenciales inválidas")
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Me.Hide()
        Dim controlPanel As New ControlPanel()
        controlPanel.ShowDialog()
        Me.Close()
    End Sub
End Class