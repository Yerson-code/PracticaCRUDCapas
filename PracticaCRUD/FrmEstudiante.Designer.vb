<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstudiante
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstudiante))
        Me.listado = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombre = New UIDC.UI_TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtapellidos = New UIDC.UI_TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdni = New UIDC.UI_TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboespecialidad = New UIDC.UI_ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listado
        '
        Me.listado.AllowUserToAddRows = False
        Me.listado.AllowUserToDeleteRows = False
        Me.listado.AllowUserToResizeColumns = False
        Me.listado.AllowUserToResizeRows = False
        Me.listado.BackgroundColor = System.Drawing.Color.White
        Me.listado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.listado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.listado.ColumnHeadersHeight = 30
        Me.listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6})
        Me.listado.EnableHeadersVisualStyles = False
        Me.listado.GridColor = System.Drawing.Color.White
        Me.listado.Location = New System.Drawing.Point(12, 253)
        Me.listado.Name = "listado"
        Me.listado.ReadOnly = True
        Me.listado.RowHeadersVisible = False
        Me.listado.RowHeadersWidth = 40
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.listado.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.listado.RowTemplate.Height = 40
        Me.listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.listado.Size = New System.Drawing.Size(655, 207)
        Me.listado.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Nombre"
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.Transparent
        Me.txtnombre.BackgroundColour = System.Drawing.Color.White
        Me.txtnombre.BorderColour = System.Drawing.Color.Black
        Me.txtnombre.BorderSize = 0
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(15, 24)
        Me.txtnombre.MaxLength = 32767
        Me.txtnombre.Multiline = False
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ReadOnly = False
        Me.txtnombre.Size = New System.Drawing.Size(274, 26)
        Me.txtnombre.StyleBorder = UIDC.UI_TextBox.Styles.BorderRounded
        Me.txtnombre.TabIndex = 1
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtnombre.TextColour = System.Drawing.Color.Black
        Me.txtnombre.UseSystemPasswordChar = False
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnguardar.FlatAppearance.BorderSize = 0
        Me.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardar.Location = New System.Drawing.Point(77, 487)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(100, 30)
        Me.btnguardar.TabIndex = 77
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(199, 487)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 30)
        Me.btnEditar.TabIndex = 76
        Me.btnEditar.Text = "Modificar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(399, 12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(181, 180)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 78
        Me.pictureBox1.TabStop = False
        '
        'txtapellidos
        '
        Me.txtapellidos.BackColor = System.Drawing.Color.Transparent
        Me.txtapellidos.BackgroundColour = System.Drawing.Color.White
        Me.txtapellidos.BorderColour = System.Drawing.Color.Black
        Me.txtapellidos.BorderSize = 0
        Me.txtapellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellidos.Location = New System.Drawing.Point(15, 71)
        Me.txtapellidos.MaxLength = 32767
        Me.txtapellidos.Multiline = False
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.ReadOnly = False
        Me.txtapellidos.Size = New System.Drawing.Size(367, 26)
        Me.txtapellidos.StyleBorder = UIDC.UI_TextBox.Styles.BorderRounded
        Me.txtapellidos.TabIndex = 2
        Me.txtapellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtapellidos.TextColour = System.Drawing.Color.Black
        Me.txtapellidos.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Apellidos"
        '
        'txtdni
        '
        Me.txtdni.BackColor = System.Drawing.Color.Transparent
        Me.txtdni.BackgroundColour = System.Drawing.Color.White
        Me.txtdni.BorderColour = System.Drawing.Color.Black
        Me.txtdni.BorderSize = 0
        Me.txtdni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdni.Location = New System.Drawing.Point(15, 115)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Multiline = False
        Me.txtdni.Name = "txtdni"
        Me.txtdni.ReadOnly = False
        Me.txtdni.Size = New System.Drawing.Size(274, 26)
        Me.txtdni.StyleBorder = UIDC.UI_TextBox.Styles.BorderRounded
        Me.txtdni.TabIndex = 3
        Me.txtdni.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtdni.TextColour = System.Drawing.Color.Black
        Me.txtdni.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "DNI"
        '
        'cboespecialidad
        '
        Me.cboespecialidad.ArrowColour = System.Drawing.Color.DodgerBlue
        Me.cboespecialidad.BackColor = System.Drawing.Color.Transparent
        Me.cboespecialidad.BaseColour = System.Drawing.Color.White
        Me.cboespecialidad.BorderColour = System.Drawing.Color.Gray
        Me.cboespecialidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboespecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboespecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboespecialidad.FontColour = System.Drawing.Color.Black
        Me.cboespecialidad.FormattingEnabled = True
        Me.cboespecialidad.Items.AddRange(New Object() {"Ingenieria de sistemas", "Ingenieria civil", "Administracion", "Contabilidad"})
        Me.cboespecialidad.LineColour = System.Drawing.Color.DodgerBlue
        Me.cboespecialidad.Location = New System.Drawing.Point(12, 166)
        Me.cboespecialidad.Name = "cboespecialidad"
        Me.cboespecialidad.Size = New System.Drawing.Size(274, 27)
        Me.cboespecialidad.SqaureColour = System.Drawing.Color.Gainsboro
        Me.cboespecialidad.SqaureHoverColour = System.Drawing.Color.Gray
        Me.cboespecialidad.StartIndex = 0
        Me.cboespecialidad.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Especialidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(357, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Buscar:"
        '
        'btneliminar
        '
        Me.btneliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btneliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btneliminar.FlatAppearance.BorderSize = 0
        Me.btneliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.Location = New System.Drawing.Point(317, 487)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(100, 30)
        Me.btneliminar.TabIndex = 90
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(442, 487)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 30)
        Me.Button2.TabIndex = 89
        Me.Button2.Text = "Salir"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.Location = New System.Drawing.Point(423, 221)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(236, 26)
        Me.txtbuscar.TabIndex = 91
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "idestudiante"
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nombre"
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "apellidos"
        Me.Column3.HeaderText = "Apellidos"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 250
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "dni"
        Me.Column4.HeaderText = "DNI"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "carrera"
        Me.Column6.HeaderText = "Especialidad"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 150
        '
        'FrmEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(759, 671)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboespecialidad)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtapellidos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listado)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmEstudiante"
        Me.Text = "Estudiante"
        CType(Me.listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listado As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombre As UIDC.UI_TextBox
    Private WithEvents btnguardar As Button
    Private WithEvents btnEditar As Button
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents txtapellidos As UIDC.UI_TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdni As UIDC.UI_TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboespecialidad As UIDC.UI_ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents btneliminar As Button
    Private WithEvents Button2 As Button
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
