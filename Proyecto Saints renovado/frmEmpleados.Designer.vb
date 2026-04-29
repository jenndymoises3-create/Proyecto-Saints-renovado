<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleados))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreEmp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCargoEmp = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefonoEmp = New System.Windows.Forms.TextBox()
        Me.btnAgregarEmp = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnModificarEmp = New System.Windows.Forms.Button()
        Me.btnEliminarEmp = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colIDEmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreEmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCargoEmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefonoEmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(125, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(489, 40)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "GESTIÓN DE EMPLEADOS"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Completo"
        '
        'txtNombreEmp
        '
        Me.txtNombreEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreEmp.Location = New System.Drawing.Point(132, 14)
        Me.txtNombreEmp.Name = "txtNombreEmp"
        Me.txtNombreEmp.Size = New System.Drawing.Size(199, 20)
        Me.txtNombreEmp.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(349, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cargo"
        '
        'cmbCargoEmp
        '
        Me.cmbCargoEmp.FormattingEnabled = True
        Me.cmbCargoEmp.Location = New System.Drawing.Point(399, 17)
        Me.cmbCargoEmp.Name = "cmbCargoEmp"
        Me.cmbCargoEmp.Size = New System.Drawing.Size(177, 21)
        Me.cmbCargoEmp.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(582, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Teléfono"
        '
        'txtTelefonoEmp
        '
        Me.txtTelefonoEmp.Location = New System.Drawing.Point(646, 21)
        Me.txtTelefonoEmp.Name = "txtTelefonoEmp"
        Me.txtTelefonoEmp.Size = New System.Drawing.Size(151, 20)
        Me.txtTelefonoEmp.TabIndex = 5
        '
        'btnAgregarEmp
        '
        Me.btnAgregarEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregarEmp.FlatAppearance.BorderSize = 0
        Me.btnAgregarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarEmp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEmp.Location = New System.Drawing.Point(515, 171)
        Me.btnAgregarEmp.Name = "btnAgregarEmp"
        Me.btnAgregarEmp.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarEmp.TabIndex = 6
        Me.btnAgregarEmp.Text = "AGREGAR"
        Me.btnAgregarEmp.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnEliminarEmp)
        Me.Panel2.Controls.Add(Me.btnModificarEmp)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnAgregarEmp)
        Me.Panel2.Controls.Add(Me.txtNombreEmp)
        Me.Panel2.Controls.Add(Me.txtTelefonoEmp)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cmbCargoEmp)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 200)
        Me.Panel2.TabIndex = 7
        '
        'btnModificarEmp
        '
        Me.btnModificarEmp.BackColor = System.Drawing.Color.LightBlue
        Me.btnModificarEmp.FlatAppearance.BorderSize = 0
        Me.btnModificarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarEmp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarEmp.Location = New System.Drawing.Point(596, 171)
        Me.btnModificarEmp.Name = "btnModificarEmp"
        Me.btnModificarEmp.Size = New System.Drawing.Size(102, 23)
        Me.btnModificarEmp.TabIndex = 7
        Me.btnModificarEmp.Text = "ACTUALIZAR"
        Me.btnModificarEmp.UseVisualStyleBackColor = False
        '
        'btnEliminarEmp
        '
        Me.btnEliminarEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnEliminarEmp.FlatAppearance.BorderSize = 0
        Me.btnEliminarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarEmp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarEmp.Location = New System.Drawing.Point(704, 171)
        Me.btnEliminarEmp.Name = "btnEliminarEmp"
        Me.btnEliminarEmp.Size = New System.Drawing.Size(84, 23)
        Me.btnEliminarEmp.TabIndex = 8
        Me.btnEliminarEmp.Text = "ELIMINAR"
        Me.btnEliminarEmp.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIDEmp, Me.colNombreEmp, Me.colCargoEmp, Me.colTelefonoEmp})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 300)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(800, 150)
        Me.DataGridView1.TabIndex = 9
        '
        'colIDEmp
        '
        Me.colIDEmp.HeaderText = "ID"
        Me.colIDEmp.Name = "colIDEmp"
        '
        'colNombreEmp
        '
        Me.colNombreEmp.HeaderText = "Nombre Completo"
        Me.colNombreEmp.Name = "colNombreEmp"
        '
        'colCargoEmp
        '
        Me.colCargoEmp.HeaderText = "Cargo"
        Me.colCargoEmp.Name = "colCargoEmp"
        '
        'colTelefonoEmp
        '
        Me.colTelefonoEmp.HeaderText = "Teléfono"
        Me.colTelefonoEmp.Name = "colTelefonoEmp"
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEmpleados"
        Me.Text = "frmEmpleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreEmp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCargoEmp As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTelefonoEmp As TextBox
    Friend WithEvents btnAgregarEmp As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEliminarEmp As Button
    Friend WithEvents btnModificarEmp As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colIDEmp As DataGridViewTextBoxColumn
    Friend WithEvents colNombreEmp As DataGridViewTextBoxColumn
    Friend WithEvents colCargoEmp As DataGridViewTextBoxColumn
    Friend WithEvents colTelefonoEmp As DataGridViewTextBoxColumn
End Class
