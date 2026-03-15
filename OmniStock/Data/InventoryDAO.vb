Imports MySql.Data.MySqlClient
Imports System.Data

Public Class InventoryDAO

    Public Function GetAll() As DataTable
        Dim sql As String = "SELECT id, email, role FROM users"
        Return DbHelper.ExecuteDataTable(sql)
    End Function

    Public Function Insert(productId As String, units As Integer) As Integer
        Dim sql As String =
            "INSERT INTO inventory (product_id, units) VALUES (@product_id, @units)"

        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@product_id", productId),
            New MySqlParameter("@units", units)
        }
        Return DbHelper.ExecuteNonQuery(sql, parameters)
    End Function
End Class