<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesForm
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
        dgvProducts = New DataGridView()
        dgvCarr = New DataGridView()
        TextBox1 = New TextBox()
        lblTotal = New Label()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvCarr, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvProducts
        ' 
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(12, 64)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.RowHeadersWidth = 62
        dgvProducts.Size = New Size(360, 311)
        dgvProducts.TabIndex = 0
        ' 
        ' dgvCarr
        ' 
        dgvCarr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCarr.Location = New Point(413, 64)
        dgvCarr.Name = "dgvCarr"
        dgvCarr.RowHeadersWidth = 62
        dgvCarr.Size = New Size(360, 311)
        dgvCarr.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(623, 398)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 2
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(557, 401)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(49, 25)
        lblTotal.TabIndex = 3
        lblTotal.Text = "Total"
        ' 
        ' SalesForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotal)
        Controls.Add(TextBox1)
        Controls.Add(dgvCarr)
        Controls.Add(dgvProducts)
        Name = "SalesForm"
        Text = "SalesForm"
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCarr, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents dgvCarr As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblTotal As Label
End Class
