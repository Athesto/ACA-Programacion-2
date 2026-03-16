Public Class Products_forms
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        txtName.Text = "Producto de prueba"
        rtxtDescription.Text = "Descripción de prueba"
        txtPrice.Text = "9.99"
        txtStock.Text = "100"
        Dim rnd As New Random()
        txtSku.Text = "PRD-" & rnd.Next(10000, 99999)

        Dim product_dao As New ProductDAO()
        Dim productId As Integer = product_dao.Insert(
            txtName.Text,
            txtSku.Text,
            rtxtDescription.Text,
            Decimal.Parse(txtPrice.Text)
        )
        MessageBox.Show(productId)

        Dim inventory_dao As New InventoryDAO()
        inventory_dao.Insert(productId, Integer.Parse(txtStock.Text))
    End Sub

    Private Sub txtSku_TextChanged(sender As Object, e As EventArgs) Handles txtSku.TextChanged

    End Sub
End Class