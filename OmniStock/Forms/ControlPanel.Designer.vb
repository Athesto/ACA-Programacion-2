<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        TabUsers = New TabPage()
        Button11 = New Button()
        Button12 = New Button()
        Button13 = New Button()
        txtUserRole = New TextBox()
        Label8 = New Label()
        txtUserPass = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        txtUserEmail = New TextBox()
        RefreshUsers = New Button()
        Button10 = New Button()
        cmbUsers = New ComboBox()
        Button1 = New Button()
        TabProducts = New TabPage()
        Delete = New Button()
        Submit = New Button()
        txtPrice = New TextBox()
        Label5 = New Label()
        txtSku = New TextBox()
        Label4 = New Label()
        Edit = New Button()
        txtStock = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        txtName = New TextBox()
        Label1 = New Label()
        rtxtDescription = New RichTextBox()
        Button5 = New Button()
        Button4 = New Button()
        cmbSku = New ComboBox()
        Button2 = New Button()
        TabSales = New TabPage()
        Button8 = New Button()
        Button7 = New Button()
        ComboBox2 = New ComboBox()
        Button6 = New Button()
        ComboBox1 = New ComboBox()
        Button3 = New Button()
        TabControl1.SuspendLayout()
        TabUsers.SuspendLayout()
        TabProducts.SuspendLayout()
        TabSales.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabUsers)
        TabControl1.Controls.Add(TabProducts)
        TabControl1.Controls.Add(TabSales)
        TabControl1.Location = New Point(12, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(812, 537)
        TabControl1.TabIndex = 0
        ' 
        ' TabUsers
        ' 
        TabUsers.Controls.Add(Button11)
        TabUsers.Controls.Add(Button12)
        TabUsers.Controls.Add(Button13)
        TabUsers.Controls.Add(txtUserRole)
        TabUsers.Controls.Add(Label8)
        TabUsers.Controls.Add(txtUserPass)
        TabUsers.Controls.Add(Label6)
        TabUsers.Controls.Add(Label7)
        TabUsers.Controls.Add(txtUserEmail)
        TabUsers.Controls.Add(RefreshUsers)
        TabUsers.Controls.Add(Button10)
        TabUsers.Controls.Add(cmbUsers)
        TabUsers.Controls.Add(Button1)
        TabUsers.Location = New Point(4, 29)
        TabUsers.Name = "TabUsers"
        TabUsers.Padding = New Padding(3)
        TabUsers.Size = New Size(804, 504)
        TabUsers.TabIndex = 0
        TabUsers.Text = "Users"
        TabUsers.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.ForeColor = Color.Brown
        Button11.Location = New Point(526, 260)
        Button11.Name = "Button11"
        Button11.Size = New Size(94, 29)
        Button11.TabIndex = 28
        Button11.Text = "Delete"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Location = New Point(526, 295)
        Button12.Name = "Button12"
        Button12.Size = New Size(94, 29)
        Button12.TabIndex = 27
        Button12.Text = "Save"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Button13
        ' 
        Button13.Location = New Point(526, 225)
        Button13.Name = "Button13"
        Button13.Size = New Size(94, 29)
        Button13.TabIndex = 26
        Button13.Text = "Edit"
        Button13.UseVisualStyleBackColor = True
        ' 
        ' txtUserRole
        ' 
        txtUserRole.Enabled = False
        txtUserRole.Location = New Point(248, 288)
        txtUserRole.Name = "txtUserRole"
        txtUserRole.ReadOnly = True
        txtUserRole.Size = New Size(116, 27)
        txtUserRole.TabIndex = 25
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(204, 291)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 20)
        Label8.TabIndex = 24
        Label8.Text = "Role"
        ' 
        ' txtUserPass
        ' 
        txtUserPass.Enabled = False
        txtUserPass.Location = New Point(248, 255)
        txtUserPass.Name = "txtUserPass"
        txtUserPass.ReadOnly = True
        txtUserPass.Size = New Size(116, 27)
        txtUserPass.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(173, 258)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 20)
        Label6.TabIndex = 22
        Label6.Text = "Password"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(160, 225)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 20)
        Label7.TabIndex = 21
        Label7.Text = "User Email"
        ' 
        ' txtUserEmail
        ' 
        txtUserEmail.Enabled = False
        txtUserEmail.Location = New Point(248, 222)
        txtUserEmail.Name = "txtUserEmail"
        txtUserEmail.ReadOnly = True
        txtUserEmail.Size = New Size(226, 27)
        txtUserEmail.TabIndex = 20
        ' 
        ' RefreshUsers
        ' 
        RefreshUsers.Location = New Point(138, 175)
        RefreshUsers.Name = "RefreshUsers"
        RefreshUsers.Size = New Size(94, 29)
        RefreshUsers.TabIndex = 9
        RefreshUsers.Text = "Refresh"
        RefreshUsers.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(453, 175)
        Button10.Name = "Button10"
        Button10.Size = New Size(167, 29)
        Button10.TabIndex = 8
        Button10.Text = "Fetch User/Client"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' cmbUsers
        ' 
        cmbUsers.FormattingEnabled = True
        cmbUsers.Location = New Point(266, 175)
        cmbUsers.Name = "cmbUsers"
        cmbUsers.Size = New Size(155, 28)
        cmbUsers.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(19, 24)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "Add User"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TabProducts
        ' 
        TabProducts.Controls.Add(Delete)
        TabProducts.Controls.Add(Submit)
        TabProducts.Controls.Add(txtPrice)
        TabProducts.Controls.Add(Label5)
        TabProducts.Controls.Add(txtSku)
        TabProducts.Controls.Add(Label4)
        TabProducts.Controls.Add(Edit)
        TabProducts.Controls.Add(txtStock)
        TabProducts.Controls.Add(Label3)
        TabProducts.Controls.Add(Label2)
        TabProducts.Controls.Add(txtName)
        TabProducts.Controls.Add(Label1)
        TabProducts.Controls.Add(rtxtDescription)
        TabProducts.Controls.Add(Button5)
        TabProducts.Controls.Add(Button4)
        TabProducts.Controls.Add(cmbSku)
        TabProducts.Controls.Add(Button2)
        TabProducts.Location = New Point(4, 29)
        TabProducts.Name = "TabProducts"
        TabProducts.Padding = New Padding(3)
        TabProducts.Size = New Size(804, 504)
        TabProducts.TabIndex = 1
        TabProducts.Text = "Products"
        TabProducts.UseVisualStyleBackColor = True
        ' 
        ' Delete
        ' 
        Delete.ForeColor = Color.Brown
        Delete.Location = New Point(579, 287)
        Delete.Name = "Delete"
        Delete.Size = New Size(94, 29)
        Delete.TabIndex = 23
        Delete.Text = "Delete"
        Delete.UseVisualStyleBackColor = True
        ' 
        ' Submit
        ' 
        Submit.Location = New Point(579, 446)
        Submit.Name = "Submit"
        Submit.Size = New Size(94, 29)
        Submit.TabIndex = 22
        Submit.Text = "Save"
        Submit.UseVisualStyleBackColor = True
        ' 
        ' txtPrice
        ' 
        txtPrice.Enabled = False
        txtPrice.Location = New Point(562, 145)
        txtPrice.Name = "txtPrice"
        txtPrice.ReadOnly = True
        txtPrice.Size = New Size(116, 27)
        txtPrice.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(513, 148)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 20)
        Label5.TabIndex = 20
        Label5.Text = "Price"
        ' 
        ' txtSku
        ' 
        txtSku.Enabled = False
        txtSku.Location = New Point(562, 99)
        txtSku.Name = "txtSku"
        txtSku.ReadOnly = True
        txtSku.Size = New Size(116, 27)
        txtSku.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(518, 102)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 20)
        Label4.TabIndex = 18
        Label4.Text = "SKU"
        ' 
        ' Edit
        ' 
        Edit.Location = New Point(579, 252)
        Edit.Name = "Edit"
        Edit.Size = New Size(94, 29)
        Edit.TabIndex = 17
        Edit.Text = "Edit"
        Edit.UseVisualStyleBackColor = True
        ' 
        ' txtStock
        ' 
        txtStock.Enabled = False
        txtStock.Location = New Point(628, 196)
        txtStock.Name = "txtStock"
        txtStock.ReadOnly = True
        txtStock.Size = New Size(45, 27)
        txtStock.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(557, 199)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 20)
        Label3.TabIndex = 15
        Label3.Text = "Quantity"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(151, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 14
        Label2.Text = "Product Name"
        ' 
        ' txtName
        ' 
        txtName.Enabled = False
        txtName.Location = New Point(261, 99)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(226, 27)
        txtName.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(151, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 20)
        Label1.TabIndex = 12
        Label1.Text = "Description"
        ' 
        ' rtxtDescription
        ' 
        rtxtDescription.Enabled = False
        rtxtDescription.Location = New Point(151, 171)
        rtxtDescription.Name = "rtxtDescription"
        rtxtDescription.ReadOnly = True
        rtxtDescription.Size = New Size(336, 313)
        rtxtDescription.TabIndex = 11
        rtxtDescription.Text = ""
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(151, 57)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 6
        Button5.Text = "Refresh"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(466, 57)
        Button4.Name = "Button4"
        Button4.Size = New Size(125, 29)
        Button4.TabIndex = 5
        Button4.Text = "Fetch Product"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' cmbSku
        ' 
        cmbSku.FormattingEnabled = True
        cmbSku.Location = New Point(279, 57)
        cmbSku.Name = "cmbSku"
        cmbSku.Size = New Size(155, 28)
        cmbSku.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(3, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(141, 29)
        Button2.TabIndex = 3
        Button2.Text = "Add Product"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TabSales
        ' 
        TabSales.Controls.Add(Button8)
        TabSales.Controls.Add(Button7)
        TabSales.Controls.Add(ComboBox2)
        TabSales.Controls.Add(Button6)
        TabSales.Controls.Add(ComboBox1)
        TabSales.Controls.Add(Button3)
        TabSales.Location = New Point(4, 29)
        TabSales.Name = "TabSales"
        TabSales.Size = New Size(804, 504)
        TabSales.TabIndex = 2
        TabSales.Text = "Sales"
        TabSales.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(360, 106)
        Button8.Name = "Button8"
        Button8.Size = New Size(139, 29)
        Button8.TabIndex = 11
        Button8.Text = "Add"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(20, 105)
        Button7.Name = "Button7"
        Button7.Size = New Size(139, 29)
        Button7.TabIndex = 10
        Button7.Text = "Refresh Products"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(178, 106)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(155, 28)
        ComboBox2.TabIndex = 9
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(20, 54)
        Button6.Name = "Button6"
        Button6.Size = New Size(139, 29)
        Button6.TabIndex = 8
        Button6.Text = "Refresh Clients"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(178, 55)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(155, 28)
        ComboBox1.TabIndex = 7
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(3, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(141, 29)
        Button3.TabIndex = 4
        Button3.Text = "Add Sale"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ControlPanel
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(836, 561)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "ControlPanel"
        Text = "ControlPanel"
        TabControl1.ResumeLayout(False)
        TabUsers.ResumeLayout(False)
        TabUsers.PerformLayout()
        TabProducts.ResumeLayout(False)
        TabProducts.PerformLayout()
        TabSales.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabUsers As TabPage
    Friend WithEvents TabProducts As TabPage
    Friend WithEvents TabSales As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents cmbSku As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Submit As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSku As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Edit As Button
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rtxtDescription As RichTextBox
    Friend WithEvents Delete As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RefreshUsers As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents cmbUsers As ComboBox
    Friend WithEvents txtUserRole As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUserPass As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUserEmail As TextBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
End Class
