<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlRegistroUser = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEmpleadoUser = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnCrearUser = New System.Windows.Forms.Button()
        Me.btnEditarUser = New System.Windows.Forms.Button()
        Me.btnEliminarUser = New System.Windows.Forms.Button()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.colIDUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmpleadoAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRegistroUser.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(133, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(470, 40)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "CONTROL DE USUARIOS"
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
        'pnlRegistroUser
        '
        Me.pnlRegistroUser.BackColor = System.Drawing.Color.White
        Me.pnlRegistroUser.Controls.Add(Me.btnEliminarUser)
        Me.pnlRegistroUser.Controls.Add(Me.btnEditarUser)
        Me.pnlRegistroUser.Controls.Add(Me.btnCrearUser)
        Me.pnlRegistroUser.Controls.Add(Me.txtPass)
        Me.pnlRegistroUser.Controls.Add(Me.Label3)
        Me.pnlRegistroUser.Controls.Add(Me.txtUsuario)
        Me.pnlRegistroUser.Controls.Add(Me.Label2)
        Me.pnlRegistroUser.Controls.Add(Me.cmbEmpleadoUser)
        Me.pnlRegistroUser.Controls.Add(Me.Label1)
        Me.pnlRegistroUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRegistroUser.Location = New System.Drawing.Point(0, 100)
        Me.pnlRegistroUser.Name = "pnlRegistroUser"
        Me.pnlRegistroUser.Size = New System.Drawing.Size(800, 200)
        Me.pnlRegistroUser.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleado"
        '
        'cmbEmpleadoUser
        '
        Me.cmbEmpleadoUser.FormattingEnabled = True
        Me.cmbEmpleadoUser.Location = New System.Drawing.Point(96, 11)
        Me.cmbEmpleadoUser.Name = "cmbEmpleadoUser"
        Me.cmbEmpleadoUser.Size = New System.Drawing.Size(137, 21)
        Me.cmbEmpleadoUser.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(239, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre de Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(387, 16)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(137, 20)
        Me.txtUsuario.TabIndex = 3
        Me.txtUsuario.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(521, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(613, 17)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(175, 20)
        Me.txtPass.TabIndex = 5
        Me.txtPass.UseSystemPasswordChar = True
        '
        'btnCrearUser
        '
        Me.btnCrearUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCrearUser.Location = New System.Drawing.Point(546, 165)
        Me.btnCrearUser.Name = "btnCrearUser"
        Me.btnCrearUser.Size = New System.Drawing.Size(75, 23)
        Me.btnCrearUser.TabIndex = 6
        Me.btnCrearUser.Text = "CREAR"
        Me.btnCrearUser.UseVisualStyleBackColor = False
        '
        'btnEditarUser
        '
        Me.btnEditarUser.BackColor = System.Drawing.Color.LightBlue
        Me.btnEditarUser.Location = New System.Drawing.Point(627, 165)
        Me.btnEditarUser.Name = "btnEditarUser"
        Me.btnEditarUser.Size = New System.Drawing.Size(75, 23)
        Me.btnEditarUser.TabIndex = 7
        Me.btnEditarUser.Text = "EDITAR"
        Me.btnEditarUser.UseVisualStyleBackColor = False
        '
        'btnEliminarUser
        '
        Me.btnEliminarUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnEliminarUser.Location = New System.Drawing.Point(708, 165)
        Me.btnEliminarUser.Name = "btnEliminarUser"
        Me.btnEliminarUser.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarUser.TabIndex = 8
        Me.btnEliminarUser.Text = "ELIMINAR"
        Me.btnEliminarUser.UseVisualStyleBackColor = False
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToResizeRows = False
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIDUser, Me.colUsername, Me.colEmpleadoAsignado})
        Me.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUsuarios.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgvUsuarios.Location = New System.Drawing.Point(0, 300)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(800, 150)
        Me.dgvUsuarios.TabIndex = 6
        '
        'colIDUser
        '
        Me.colIDUser.HeaderText = "ID"
        Me.colIDUser.Name = "colIDUser"
        '
        'colUsername
        '
        Me.colUsername.HeaderText = "Nombre de Usuario"
        Me.colUsername.Name = "colUsername"
        '
        'colEmpleadoAsignado
        '
        Me.colEmpleadoAsignado.HeaderText = "Empleado Asignado"
        Me.colEmpleadoAsignado.Name = "colEmpleadoAsignado"
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.pnlRegistroUser)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmUsuarios"
        Me.Text = "SAINTS - Control de Usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRegistroUser.ResumeLayout(False)
        Me.pnlRegistroUser.PerformLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlRegistroUser As Panel
    Friend WithEvents cmbEmpleadoUser As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEliminarUser As Button
    Friend WithEvents btnEditarUser As Button
    Friend WithEvents btnCrearUser As Button
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents colIDUser As DataGridViewTextBoxColumn
    Friend WithEvents colUsername As DataGridViewTextBoxColumn
    Friend WithEvents colEmpleadoAsignado As DataGridViewTextBoxColumn
End Class
