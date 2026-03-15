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
        Dim product_dao As New ProductDAO()
        Dim skus = product_dao.GetAllSku()
        cmbSku.DataSource = skus
        cmbSku.DisplayMember = "sku"
        cmbSku.ValueMember = "sku"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim product_dao As New ProductDAO()
        MessageBox.Show(cmbSku.Text)
        Dim product = product_dao.GetOneBySku(cmbSku.Text)

        txtName.Text = product.Rows(0).Item("name").ToString()
        txtSku.Text = product.Rows(0).Item("sku").ToString()
        rtxtDescription.Text = product.Rows(0).Item("description").ToString()
        txtPrice.Text = product.Rows(0).Item("price").ToString()
        txtStock.Text = product.Rows(0).Item("units").ToString()
    End Sub

End Class