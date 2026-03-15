Imports MySql.Data.MySqlClient

Public Class DbHelper

    Public Shared Function ExecuteNonQuery(
        sql As String,
        Optional parameters As List(Of MySqlParameter) = Nothing
    ) As Integer

        Using conn As MySqlConnection = Connection.GetConnection()
            Using cmd As New MySqlCommand(sql, conn)

                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If

                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Shared Function ExecuteScalar(
        sql As String,
        Optional parameters As List(Of MySqlParameter) = Nothing
    ) As Object

        Using conn As MySqlConnection = Connection.GetConnection()
            Using cmd As New MySqlCommand(sql, conn)

                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If

                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function

    Public Shared Function ExecuteDataTable(
        sql As String,
        Optional parameters As List(Of MySqlParameter) = Nothing
    ) As DataTable

        Dim dt As New DataTable()

        Using conn As MySqlConnection = Connection.GetConnection()
            Using cmd As New MySqlCommand(sql, conn)

                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

End Class