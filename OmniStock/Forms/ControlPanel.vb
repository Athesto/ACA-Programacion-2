Public Class ControlPanel
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Products_forms.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SalesForm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim product_dao As New ProductDAO
        Dim skus = product_dao.GetAllSku
        cmbSku.DataSource = skus
        cmbSku.DisplayMember = "sku"
        cmbSku.ValueMember = "sku"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim product_dao As New ProductDAO()
        Dim product = product_dao.GetOneBySku(cmbSku.Text)

        txtName.Text = product.Rows(0).Item("name").ToString()
        txtSku.Text = product.Rows(0).Item("sku").ToString()
        rtxtDescription.Text = product.Rows(0).Item("description").ToString()
        txtPrice.Text = product.Rows(0).Item("price").ToString()
        txtStock.Text = product.Rows(0).Item("units").ToString()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        txtName.ReadOnly = False
        rtxtDescription.ReadOnly = False
        txtPrice.ReadOnly = False
        txtStock.ReadOnly = False

        txtName.Enabled = True
        rtxtDescription.Enabled = True
        txtPrice.Enabled = True
        txtStock.Enabled = True
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim product_dao As New ProductDAO()
        Dim product = product_dao.UpdateOneBySku(txtName.Text, txtPrice.Text, txtSku.Text, rtxtDescription.Text)

        Dim inventory_dao As New InventoryDAO()
        inventory_dao.UpdateOneBySku(txtSku.Text, txtStock.Text)

        txtName.ReadOnly = True
        rtxtDescription.ReadOnly = True
        txtPrice.ReadOnly = True
        txtStock.ReadOnly = True

        txtName.Enabled = False
        rtxtDescription.Enabled = False
        txtPrice.Enabled = False
        txtStock.Enabled = False
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim product_dao As New ProductDAO()
        Dim inventory_dao As New InventoryDAO()
        Dim product_id = product_dao.GetIdBySku(txtSku.Text)
        inventory_dao.DeleteByProductId(product_id)
        product_dao.DelectBySku(txtSku.Text)
        Button5_Click(Nothing, Nothing)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class