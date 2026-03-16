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
        rtxtDescription.Location = New Point(15, 130)
        rtxtDescription.Margin = New Padding(4, 4, 4, 4)
        rtxtDescription.Name = "rtxtDescription"
        rtxtDescription.Size = New Size(419, 390)
        rtxtDescription.TabIndex = 0
        rtxtDescription.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 101)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 25)
        Label1.TabIndex = 1
        Label1.Text = "Description"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(152, 40)
        txtName.Margin = New Padding(4, 4, 4, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(282, 31)
        txtName.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 44)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 25)
        Label2.TabIndex = 3
        Label2.Text = "Product Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(522, 165)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 25)
        Label3.TabIndex = 4
        Label3.Text = "Quantity"
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(611, 161)
        txtStock.Margin = New Padding(4, 4, 4, 4)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(55, 31)
        txtStock.TabIndex = 5
        ' 
        ' Submit
        ' 
        Submit.Location = New Point(550, 485)
        Submit.Margin = New Padding(4, 4, 4, 4)
        Submit.Name = "Submit"
        Submit.Size = New Size(118, 36)
        Submit.TabIndex = 6
        Submit.Text = "Submit"
        Submit.UseVisualStyleBackColor = True
        ' 
        ' txtSku
        ' 
        txtSku.Location = New Point(529, 40)
        txtSku.Margin = New Padding(4, 4, 4, 4)
        txtSku.Name = "txtSku"
        txtSku.Size = New Size(144, 31)
        txtSku.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(474, 44)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 25)
        Label4.TabIndex = 7
        Label4.Text = "SKU"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(529, 98)
        txtPrice.Margin = New Padding(4, 4, 4, 4)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(144, 31)
        txtPrice.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(468, 101)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 25)
        Label5.TabIndex = 9
        Label5.Text = "Price"
        ' 
        ' Products_forms
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(706, 562)
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
        Margin = New Padding(4, 4, 4, 4)
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
