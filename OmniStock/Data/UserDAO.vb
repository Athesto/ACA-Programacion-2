Imports MySql.Data.MySqlClient
Imports System.Data

Public Class UserDAO

    Public Function GetAll() As DataTable
        Dim sql As String = "SELECT id, email, role FROM users"
        Return DbHelper.ExecuteDataTable(sql)
    End Function

    Public Function GetAllEmails() As DataTable
        Dim sql As String = "SELECT email, role FROM users"
        Return DbHelper.ExecuteDataTable(sql)
    End Function
    Public Function GetOneByEmail(email As String) As DataTable
        Dim sql As String =
            "SELECT email, password_hash, role FROM users WHERE email=@email"

        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@email", email)
        }
        Return DbHelper.ExecuteDataTable(sql, parameters)
    End Function
    Public Function DeleteOneByEmail(email As String) As DataTable
        Dim sql As String =
            "DELETE FROM users WHERE email=@email"

        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@email", email)
        }
        Return DbHelper.ExecuteDataTable(sql, parameters)
    End Function

    Public Function UpdateByEmail(email As String, password As String, role As String) As DataTable
        Dim sql As String =
            "UPDATE users SET password_hash=@pass, role=@role WHERE email=@email"

        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@email", email),
            New MySqlParameter("@pass", password),
            New MySqlParameter("@role", role)
        }
        Return DbHelper.ExecuteDataTable(sql, parameters)
    End Function
    Public Function Insert(email As String, password As String, rol As String) As Integer
        Dim sql As String =
            "INSERT INTO users (email, password_hash, role) VALUES (@email, @pass, @role)"

        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@email", email),
            New MySqlParameter("@pass", password),
            New MySqlParameter("@role", rol)
        }

        Return DbHelper.ExecuteNonQuery(sql, parameters)
    End Function

    Public Function ValidateLogin(email As String, password As String) As Boolean
        Dim sql As String =
            "SELECT COUNT(*) FROM users WHERE email = @email AND password_hash = @pass"

        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@email", email),
            New MySqlParameter("@pass", password)
        }

        Dim result As Integer = Convert.ToInt32(DbHelper.ExecuteScalar(sql, parameters))
        Return result > 0
    End Function

End Class