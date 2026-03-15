Imports MySql.Data.MySqlClient
Imports System.Data

Public Class ProductDAO

    Public Function GetAll() As DataTable
        Dim sql As String = "SELECT name, sku, description, price FROM products"
        Return DbHelper.ExecuteDataTable(sql)
    End Function

    Public Function Insert(name As String, sku As String, description As String, price As Decimal) As Integer
        Dim sql As String =
            "INSERT INTO products (name, price, sku, description) VALUES (@name, @price, @sku, @description)"

        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@name", name),
            New MySqlParameter("@price", price),
            New MySqlParameter("@sku", sku),
            New MySqlParameter("@description", description)
        }
        DbHelper.ExecuteNonQuery(sql, parameters)
        Return DbHelper.ExecuteScalar("SELECT LAST_INSERT_ID();")
    End Function

End Class