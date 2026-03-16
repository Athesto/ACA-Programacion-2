Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class ProductDAO

    Public Function GetAll() As DataTable
        Dim sql As String = "SELECT name, sku, description, price FROM products"
        Return DbHelper.ExecuteDataTable(sql)
    End Function

    Public Function GetAllSku() As DataTable
        Dim sql As String = "SELECT sku FROM products"
        Return DbHelper.ExecuteDataTable(sql)
    End Function

    Public Function GetIdBySku(sku As String) As Integer
        Dim sql As String = "SELECT p.id FROM products as p where sku=@sku"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@sku", sku)
        }
        Return DbHelper.ExecuteScalar(sql, parameters)
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
    Public Function GetOneBySku(sku As String) As DataTable
        Dim sql As String =
            "SELECT p.sku, p.name, p.price, i.units, p.description FROM products p JOIN inventory i ON p.id = i.product_id where p.sku = (@sku);"

        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@sku", sku)
        }
        Return DbHelper.ExecuteDataTable(sql, parameters)
    End Function

    Public Function UpdateOneBySku(name As String, price As Decimal, sku As String, description As String) As Integer
        Dim sql As String =
            "UPDATE products SET name=@name, price=@price, description=@description WHERE sku = (@sku);"

        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@name", name),
            New MySqlParameter("@price", price),
            New MySqlParameter("@description", description),
            New MySqlParameter("@sku", sku)
        }
        DbHelper.ExecuteNonQuery(sql, parameters)

        Dim sql2 As String = String.Format("SELECT id FROM products WHERE sku = '{0}'", sku)
        Return DbHelper.ExecuteScalar(sql2)
    End Function

    Public Function DelectBySku(sku As String) As DataTable
        Dim sql As String = "DELETE FROM products where sku=@sku"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@sku", sku)
        }
        Return DbHelper.ExecuteScalar(sql, parameters)
    End Function
End Class