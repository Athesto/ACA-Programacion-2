

Public Class SalesForm


Private carrito As New DataTable()

    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadProducts()

        carrito.Columns.Add("id")
        carrito.Columns.Add("sku")
        carrito.Columns.Add("producto")
        carrito.Columns.Add("precio", GetType(Decimal))
        carrito.Columns.Add("cantidad", GetType(Integer))
        carrito.Columns.Add("subtotal", GetType(Decimal))

        dgvCarr.DataSource = carrito

    End Sub


    Private Sub LoadProducts()

        Try

            Dim product_dao As New ProductDAO()

            dgvProducts.DataSource = product_dao.GetAvailableProducts()

        Catch ex As Exception

            MessageBox.Show("Error cargando productos: " & ex.Message)

        End Try

    End Sub

    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim id = dgvProducts.Rows(e.RowIndex).Cells("id").Value
        Dim sku = dgvProducts.Rows(e.RowIndex).Cells("sku").Value
        Dim nombre = dgvProducts.Rows(e.RowIndex).Cells("name").Value
        Dim precio = dgvProducts.Rows(e.RowIndex).Cells("price").Value

        AgregarProducto(id, sku, nombre, precio)

    End Sub

    'changes
    Private Sub AgregarProducto(id As Integer, sku As String, nombre As String, precio As Decimal)

        For Each row As DataRow In carrito.Rows

            If row("id") = id Then

                row("cantidad") += 1
                row("subtotal") = row("cantidad") * precio

                CalcularTotal()
                Exit Sub

            End If

        Next

        Dim nuevaFila = carrito.NewRow()

        nuevaFila("id") = id
        nuevaFila("sku") = sku
        nuevaFila("producto") = nombre
        nuevaFila("precio") = precio
        nuevaFila("cantidad") = 1
        nuevaFila("subtotal") = precio

        carrito.Rows.Add(nuevaFila)

        CalcularTotal()

    End Sub

    Private Sub CalcularTotal()

    Dim total As Decimal = 0

    For Each row As DataRow In carrito.Rows
        total += row("subtotal")
    Next

    lblTotal.Text = total.ToString("C")

End Sub
End Class