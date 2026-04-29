<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGenerarReporte = New System.Windows.Forms.Label()
        Me.cmbProductoReporte = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colFechaRep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProductoRep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantRep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecioRep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubtotalRep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlFiltros.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFiltros
        '
        Me.pnlFiltros.BackColor = System.Drawing.Color.LightGray
        Me.pnlFiltros.Controls.Add(Me.cmbProductoReporte)
        Me.pnlFiltros.Controls.Add(Me.btnGenerarReporte)
        Me.pnlFiltros.Controls.Add(Me.Button1)
        Me.pnlFiltros.Controls.Add(Me.Label3)
        Me.pnlFiltros.Controls.Add(Me.Label2)
        Me.pnlFiltros.Controls.Add(Me.dtpFin)
        Me.pnlFiltros.Controls.Add(Me.dtpInicio)
        Me.pnlFiltros.Controls.Add(Me.Label1)
        Me.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFiltros.Location = New System.Drawing.Point(0, 0)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Size = New System.Drawing.Size(200, 450)
        Me.pnlFiltros.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rango de Fechas"
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(12, 125)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(170, 20)
        Me.dtpInicio.TabIndex = 1
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(12, 211)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(161, 20)
        Me.dtpFin.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hasta"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(24, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 64)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "GENERAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.AutoSize = True
        Me.btnGenerarReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarReporte.Location = New System.Drawing.Point(21, 266)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(140, 16)
        Me.btnGenerarReporte.TabIndex = 6
        Me.btnGenerarReporte.Text = "Filtrar por Producto"
        '
        'cmbProductoReporte
        '
        Me.cmbProductoReporte.FormattingEnabled = True
        Me.cmbProductoReporte.Location = New System.Drawing.Point(12, 294)
        Me.cmbProductoReporte.Name = "cmbProductoReporte"
        Me.cmbProductoReporte.Size = New System.Drawing.Size(162, 21)
        Me.cmbProductoReporte.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 100)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(221, 324)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 114)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(520, 324)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(268, 119)
        Me.Panel3.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "TOTAL VENDIDO: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "TOTAL TRANSACCIONES: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(90, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "$0.00."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(102, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = " 0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(110, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(389, 31)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "REPORTES Y DESEMPEÑO"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFechaRep, Me.colProductoRep, Me.colCantRep, Me.colPrecioRep, Me.colSubtotalRep})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(200, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(600, 350)
        Me.DataGridView1.TabIndex = 2
        '
        'colFechaRep
        '
        Me.colFechaRep.HeaderText = "FECHA DE VENTA"
        Me.colFechaRep.Name = "colFechaRep"
        '
        'colProductoRep
        '
        Me.colProductoRep.HeaderText = "PRODUCTO / SERVICIO"
        Me.colProductoRep.Name = "colProductoRep"
        '
        'colCantRep
        '
        Me.colCantRep.HeaderText = "CANT"
        Me.colCantRep.Name = "colCantRep"
        '
        'colPrecioRep
        '
        Me.colPrecioRep.HeaderText = "PRECIO UNIT"
        Me.colPrecioRep.Name = "colPrecioRep"
        '
        'colSubtotalRep
        '
        Me.colSubtotalRep.HeaderText = "TOTAL VENTA"
        Me.colSubtotalRep.Name = "colSubtotalRep"
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlFiltros)
        Me.Name = "frmReportes"
        Me.Text = "REPORTES_Y_DESEMPEÑO"
        Me.pnlFiltros.ResumeLayout(False)
        Me.pnlFiltros.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFiltros As Panel
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbProductoReporte As ComboBox
    Friend WithEvents btnGenerarReporte As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colFechaRep As DataGridViewTextBoxColumn
    Friend WithEvents colProductoRep As DataGridViewTextBoxColumn
    Friend WithEvents colCantRep As DataGridViewTextBoxColumn
    Friend WithEvents colPrecioRep As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotalRep As DataGridViewTextBoxColumn
End Class
