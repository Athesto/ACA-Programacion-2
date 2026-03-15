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
        Button1 = New Button()
        TabProducts = New TabPage()
        Button2 = New Button()
        TabSales = New TabPage()
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
        TabControl1.Size = New Size(787, 537)
        TabControl1.TabIndex = 0
        ' 
        ' TabUsers
        ' 
        TabUsers.Controls.Add(Button1)
        TabUsers.Location = New Point(4, 29)
        TabUsers.Name = "TabUsers"
        TabUsers.Padding = New Padding(3)
        TabUsers.Size = New Size(779, 504)
        TabUsers.TabIndex = 0
        TabUsers.Text = "Users"
        TabUsers.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "Add User"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TabProducts
        ' 
        TabProducts.Controls.Add(Button2)
        TabProducts.Location = New Point(4, 29)
        TabProducts.Name = "TabProducts"
        TabProducts.Padding = New Padding(3)
        TabProducts.Size = New Size(779, 504)
        TabProducts.TabIndex = 1
        TabProducts.Text = "Products"
        TabProducts.UseVisualStyleBackColor = True
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
        TabSales.Controls.Add(Button3)
        TabSales.Location = New Point(4, 29)
        TabSales.Name = "TabSales"
        TabSales.Size = New Size(779, 504)
        TabSales.TabIndex = 2
        TabSales.Text = "Sales"
        TabSales.UseVisualStyleBackColor = True
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
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(811, 561)
        Controls.Add(TabControl1)
        Name = "ControlPanel"
        Text = "ControlPanel"
        TabControl1.ResumeLayout(False)
        TabUsers.ResumeLayout(False)
        TabProducts.ResumeLayout(False)
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
End Class
