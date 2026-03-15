Imports MySql.Data.MySqlClient

Public Class Connection
    Private Shared cadena As String =
    "server=localhost;port=3306;database=omnistock;user=root;password=pa$$;"

    Public Shared Function GetConnection() As MySqlConnection
        Dim conexion As New MySqlConnection(cadena)
        conexion.Open()
        Return conexion
    End Function
End Class

