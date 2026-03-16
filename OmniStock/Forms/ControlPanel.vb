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
        Dim product_dao As New ProductDAO
        Dim product = product_dao.GetOneBySku(cmbSku.Text)

        txtName.Text = product.Rows(0).Item("name").ToString
        txtSku.Text = product.Rows(0).Item("sku").ToString
        rtxtDescription.Text = product.Rows(0).Item("description").ToString
        txtPrice.Text = product.Rows(0).Item("price").ToString
        txtStock.Text = product.Rows(0).Item("units").ToString
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
        Dim product_dao As New ProductDAO
        Dim product = product_dao.UpdateOneBySku(txtName.Text, txtPrice.Text, txtSku.Text, rtxtDescription.Text)

        Dim inventory_dao As New InventoryDAO
        inventory_dao.UpdateOneBySku(txtSku.Text, txtStock.Text)

        txtName.ReadOnly = True
        rtxtDescription.ReadOnly = True
        txtPrice.ReadOnly = True
        txtStock.ReadOnly = True

        txtName.Enabled = False
        rtxtDescription.Enabled = False
        txtPrice.Enabled = False
        txtStock.Enabled = False
        MessageBox.Show("Producto Guardado")
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim product_dao As New ProductDAO
        Dim inventory_dao As New InventoryDAO
        Dim product_id = product_dao.GetIdBySku(txtSku.Text)
        inventory_dao.DeleteByProductId(product_id)
        product_dao.DelectBySku(txtSku.Text)
        MessageBox.Show("Producto eliminado")
        Button5_Click(Nothing, Nothing)

        txtName.Clear()
        txtSku.Clear()
        rtxtDescription.Clear()
        txtPrice.Clear()
        txtStock.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles RefreshUsers.Click
        Dim user_dao As New UserDAO()
        Dim emails = user_dao.GetAllEmails()
        cmbUsers.DataSource = emails
        cmbUsers.DisplayMember = "email"
        cmbUsers.ValueMember = "email"
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsers.SelectedIndexChanged

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim user_dao As New UserDAO
        Dim user_data = user_dao.GetOneByEmail(cmbUsers.Text)

        txtUserEmail.Text = user_data.Rows(0).Item("email").ToString
        txtUserPass.Text = user_data.Rows(0).Item("password_hash").ToString
        txtUserRole.Text = user_data.Rows(0).Item("role").ToString

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        txtUserPass.ReadOnly = False
        txtUserRole.ReadOnly = False

        txtUserPass.Enabled = True
        txtUserRole.Enabled = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim user_dao As New UserDAO
        user_dao.DeleteOneByEmail(cmbUsers.Text)
        txtUserRole.Clear()
        txtUserPass.Clear()
        txtUserEmail.Clear()
        Button9_Click(Nothing, Nothing)
        MessageBox.Show("Usuario eliminado")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim user_dao As New UserDAO
        user_dao.UpdateByEmail(txtUserEmail.Text, txtUserPass.Text, txtUserRole.Text)
        txtUserEmail.ReadOnly = True
        txtUserPass.ReadOnly = True
        txtUserRole.ReadOnly = True
        txtUserEmail.Enabled = False
        txtUserPass.Enabled = False
        txtUserRole.Enabled = False
        MessageBox.Show("Usuario Guardado")
    End Sub
End Class