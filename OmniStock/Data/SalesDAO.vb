Imports MySql.Data.MySqlClient

Public Class SalesDAO

    Public Function CreateSale(clientId As Integer) As Integer

        Dim sql As String =
            "INSERT INTO sales (client_id, created_at) VALUES (@client_id, NOW())"

        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@client_id", clientId)
        }

        DbHelper.ExecuteNonQuery(sql, parameters)

        Return DbHelper.ExecuteScalar("SELECT LAST_INSERT_ID();")

    End Function

End Class