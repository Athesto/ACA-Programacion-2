<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products_forms
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        rtxtDescription = New RichTextBox()
        Label1 = New Label()
        txtName = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtStock = New TextBox()
        Submit = New Button()
        txtSku = New TextBox()
        Label4 = New Label()
        txtPrice = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' rtxtDescription
        ' 
        rtxtDescription.Location = New Point(12, 104)
        rtxtDescription.Name = "rtxtDescription"
        rtxtDescription.Size = New Size(336, 313)
        rtxtDescription.TabIndex = 0
        rtxtDescription.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 20)
        Label1.TabIndex = 1
        Label1.Text = "Description"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(122, 32)
        txtName.Name = "txtName"
        txtName.Size = New Size(226, 27)
        txtName.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 3
        Label2.Text = "Product Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(418, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 20)
        Label3.TabIndex = 4
        Label3.Text = "Quantity"
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(489, 129)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(45, 27)
        txtStock.TabIndex = 5
        ' 
        ' Submit
        ' 
        Submit.Location = New Point(440, 388)
        Submit.Name = "Submit"
        Submit.Size = New Size(94, 29)
        Submit.TabIndex = 6
        Submit.Text = "Submit"
        Submit.UseVisualStyleBackColor = True
        ' 
        ' txtSku
        ' 
        txtSku.Location = New Point(423, 32)
        txtSku.Name = "txtSku"
        txtSku.Size = New Size(116, 27)
        txtSku.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(379, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 20)
        Label4.TabIndex = 7
        Label4.Text = "SKU"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(423, 78)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(116, 27)
        txtPrice.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(374, 81)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 20)
        Label5.TabIndex = 9
        Label5.Text = "Price"
        ' 
        ' Products_forms
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(565, 450)
        Controls.Add(txtPrice)
        Controls.Add(Label5)
        Controls.Add(txtSku)
        Controls.Add(Label4)
        Controls.Add(Submit)
        Controls.Add(txtStock)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Controls.Add(rtxtDescription)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Products_forms"
        Text = "*"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rtxtDescription As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Submit As Button
    Friend WithEvents txtSku As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label5 As Label
End Class
