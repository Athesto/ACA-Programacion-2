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
        TabSales = New TabPage()
        TabControl1.SuspendLayout()
        TabUsers.SuspendLayout()
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
        Button1.Location = New Point(22, 17)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "Add User"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TabProducts
        ' 
        TabProducts.Location = New Point(4, 29)
        TabProducts.Name = "TabProducts"
        TabProducts.Padding = New Padding(3)
        TabProducts.Size = New Size(779, 504)
        TabProducts.TabIndex = 1
        TabProducts.Text = "Products"
        TabProducts.UseVisualStyleBackColor = True
        ' 
        ' TabSales
        ' 
        TabSales.Location = New Point(4, 29)
        TabSales.Name = "TabSales"
        TabSales.Size = New Size(779, 504)
        TabSales.TabIndex = 2
        TabSales.Text = "Sales"
        TabSales.UseVisualStyleBackColor = True
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabUsers As TabPage
    Friend WithEvents TabProducts As TabPage
    Friend WithEvents TabSales As TabPage
    Friend WithEvents Button1 As Button
End Class
