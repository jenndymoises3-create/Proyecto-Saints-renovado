<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompras))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbProductoComp = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecioComp = New System.Windows.Forms.TextBox()
        Me.btnRegistrarCompra = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colProductoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecioC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidadC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubtotalC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnLimpiarTabla = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 100)
        Me.Panel1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(125, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(468, 40)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "REGISTRO DE COMPRAS"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(697, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 21)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Volver al menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(688, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.txtPrecioComp)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cmbProductoComp)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 160)
        Me.Panel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto"
        '
        'cmbProductoComp
        '
        Me.cmbProductoComp.FormattingEnabled = True
        Me.cmbProductoComp.Location = New System.Drawing.Point(76, 34)
        Me.cmbProductoComp.Name = "cmbProductoComp"
        Me.cmbProductoComp.Size = New System.Drawing.Size(212, 21)
        Me.cmbProductoComp.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(153, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(367, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Precio de Compra"
        '
        'txtPrecioComp
        '
        Me.txtPrecioComp.Location = New System.Drawing.Point(314, 35)
        Me.txtPrecioComp.Name = "txtPrecioComp"
        Me.txtPrecioComp.Size = New System.Drawing.Size(212, 20)
        Me.txtPrecioComp.TabIndex = 5
        '
        'btnRegistrarCompra
        '
        Me.btnRegistrarCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRegistrarCompra.FlatAppearance.BorderSize = 0
        Me.btnRegistrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarCompra.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarCompra.Location = New System.Drawing.Point(174, 73)
        Me.btnRegistrarCompra.Name = "btnRegistrarCompra"
        Me.btnRegistrarCompra.Size = New System.Drawing.Size(161, 23)
        Me.btnRegistrarCompra.TabIndex = 6
        Me.btnRegistrarCompra.Text = "REGISTRAR COMPRA"
        Me.btnRegistrarCompra.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colProductoC, Me.colPrecioC, Me.colCantidadC, Me.colSubtotalC, Me.colFechaC})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 260)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(800, 190)
        Me.DataGridView1.TabIndex = 4
        '
        'colProductoC
        '
        Me.colProductoC.HeaderText = "Producto"
        Me.colProductoC.Name = "colProductoC"
        '
        'colPrecioC
        '
        Me.colPrecioC.HeaderText = "Costo Unitario"
        Me.colPrecioC.Name = "colPrecioC"
        '
        'colCantidadC
        '
        Me.colCantidadC.HeaderText = "Cantidad"
        Me.colCantidadC.Name = "colCantidadC"
        '
        'colSubtotalC
        '
        Me.colSubtotalC.HeaderText = "Subtotal"
        Me.colSubtotalC.Name = "colSubtotalC"
        '
        'colFechaC
        '
        Me.colFechaC.HeaderText = "Fecha de Compra"
        Me.colFechaC.Name = "colFechaC"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(76, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.btnLimpiarTabla)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.btnRegistrarCompra)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 350)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 100)
        Me.Panel3.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(591, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "TOTAL COMPRA: $ 0.00."
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(638, 74)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "FINALIZAR COMPRA"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(355, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Quitar Fila"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnLimpiarTabla
        '
        Me.btnLimpiarTabla.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnLimpiarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarTabla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarTabla.Location = New System.Drawing.Point(3, 74)
        Me.btnLimpiarTabla.Name = "btnLimpiarTabla"
        Me.btnLimpiarTabla.Size = New System.Drawing.Size(165, 23)
        Me.btnLimpiarTabla.TabIndex = 8
        Me.btnLimpiarTabla.Text = "Vaciar Lista"
        Me.btnLimpiarTabla.UseVisualStyleBackColor = False
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AINTS - Registro de Compras"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbProductoComp As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegistrarCompra As Button
    Friend WithEvents txtPrecioComp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colProductoC As DataGridViewTextBoxColumn
    Friend WithEvents colPrecioC As DataGridViewTextBoxColumn
    Friend WithEvents colCantidadC As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotalC As DataGridViewTextBoxColumn
    Friend WithEvents colFechaC As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents btnLimpiarTabla As Button
    Friend WithEvents Button2 As Button
End Class
