<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnrestaurar = New System.Windows.Forms.Button()
        Me.btnminimizar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.titulo = New System.Windows.Forms.Label()
        Me.iconoactual = New FontAwesome.Sharp.IconPictureBox()
        Me.Escritorio = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.iconoactual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Escritorio.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.IconButton5)
        Me.panelMenu.Controls.Add(Me.IconButton4)
        Me.panelMenu.Controls.Add(Me.IconButton3)
        Me.panelMenu.Controls.Add(Me.IconButton2)
        Me.panelMenu.Controls.Add(Me.IconButton1)
        Me.panelMenu.Controls.Add(Me.IconButton6)
        Me.panelMenu.Controls.Add(Me.Panel1)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(220, 658)
        Me.panelMenu.TabIndex = 0
        '
        'IconButton5
        '
        Me.IconButton5.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton5.ForeColor = System.Drawing.Color.White
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.Tags
        Me.IconButton5.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton5.IconSize = 32
        Me.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.Location = New System.Drawing.Point(0, 310)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton5.Rotation = 0R
        Me.IconButton5.Size = New System.Drawing.Size(220, 42)
        Me.IconButton5.TabIndex = 12
        Me.IconButton5.Text = "Transparencia"
        Me.IconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton5.UseVisualStyleBackColor = True
        '
        'IconButton4
        '
        Me.IconButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton4.ForeColor = System.Drawing.Color.White
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.IconButton4.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton4.IconSize = 32
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(0, 268)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton4.Rotation = 0R
        Me.IconButton4.Size = New System.Drawing.Size(220, 42)
        Me.IconButton4.TabIndex = 11
        Me.IconButton4.Text = "Biblioteca"
        Me.IconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton3.ForeColor = System.Drawing.Color.White
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.AddressCard
        Me.IconButton3.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton3.IconSize = 32
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(0, 226)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton3.Rotation = 0R
        Me.IconButton3.Size = New System.Drawing.Size(220, 42)
        Me.IconButton3.TabIndex = 10
        Me.IconButton3.Text = "Escuelas"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.ListAlt
        Me.IconButton2.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton2.IconSize = 32
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(0, 184)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(220, 42)
        Me.IconButton2.TabIndex = 9
        Me.IconButton2.Text = "Admision"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.UserGraduate
        Me.IconButton1.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton1.IconSize = 32
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 142)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(220, 42)
        Me.IconButton1.TabIndex = 8
        Me.IconButton1.Text = "Estudiantes"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'IconButton6
        '
        Me.IconButton6.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton6.FlatAppearance.BorderSize = 0
        Me.IconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton6.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton6.ForeColor = System.Drawing.Color.White
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconButton6.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton6.IconSize = 32
        Me.IconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.Location = New System.Drawing.Point(0, 100)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton6.Rotation = 0R
        Me.IconButton6.Size = New System.Drawing.Size(220, 42)
        Me.IconButton6.TabIndex = 7
        Me.IconButton6.Text = "Inicio"
        Me.IconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton6.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 100)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnrestaurar)
        Me.Panel2.Controls.Add(Me.btnminimizar)
        Me.Panel2.Controls.Add(Me.btncerrar)
        Me.Panel2.Controls.Add(Me.titulo)
        Me.Panel2.Controls.Add(Me.iconoactual)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(220, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(891, 49)
        Me.Panel2.TabIndex = 1
        '
        'btnrestaurar
        '
        Me.btnrestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnrestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrestaurar.FlatAppearance.BorderSize = 0
        Me.btnrestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnrestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnrestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrestaurar.Image = CType(resources.GetObject("btnrestaurar.Image"), System.Drawing.Image)
        Me.btnrestaurar.Location = New System.Drawing.Point(797, 6)
        Me.btnrestaurar.Name = "btnrestaurar"
        Me.btnrestaurar.Size = New System.Drawing.Size(40, 40)
        Me.btnrestaurar.TabIndex = 8
        Me.btnrestaurar.UseVisualStyleBackColor = True
        '
        'btnminimizar
        '
        Me.btnminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnminimizar.FlatAppearance.BorderSize = 0
        Me.btnminimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimizar.Image = CType(resources.GetObject("btnminimizar.Image"), System.Drawing.Image)
        Me.btnminimizar.Location = New System.Drawing.Point(751, 6)
        Me.btnminimizar.Name = "btnminimizar"
        Me.btnminimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnminimizar.TabIndex = 7
        Me.btnminimizar.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(847, 6)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(40, 40)
        Me.btncerrar.TabIndex = 6
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo.ForeColor = System.Drawing.Color.MediumOrchid
        Me.titulo.Location = New System.Drawing.Point(67, 13)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(45, 16)
        Me.titulo.TabIndex = 1
        Me.titulo.Text = "Inicio"
        '
        'iconoactual
        '
        Me.iconoactual.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.iconoactual.ForeColor = System.Drawing.Color.Purple
        Me.iconoactual.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.iconoactual.IconColor = System.Drawing.Color.Purple
        Me.iconoactual.IconSize = 34
        Me.iconoactual.Location = New System.Drawing.Point(15, 8)
        Me.iconoactual.Name = "iconoactual"
        Me.iconoactual.Size = New System.Drawing.Size(45, 34)
        Me.iconoactual.TabIndex = 0
        Me.iconoactual.TabStop = False
        '
        'Escritorio
        '
        Me.Escritorio.Controls.Add(Me.Label6)
        Me.Escritorio.Controls.Add(Me.Label5)
        Me.Escritorio.Controls.Add(Me.Label4)
        Me.Escritorio.Controls.Add(Me.Label3)
        Me.Escritorio.Controls.Add(Me.Label2)
        Me.Escritorio.Controls.Add(Me.Label1)
        Me.Escritorio.Controls.Add(Me.PictureBox2)
        Me.Escritorio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Escritorio.Location = New System.Drawing.Point(220, 49)
        Me.Escritorio.Name = "Escritorio"
        Me.Escritorio.Size = New System.Drawing.Size(891, 609)
        Me.Escritorio.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(334, 244)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(295, 102)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(330, 464)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Yerson Bocanegra Guerrero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(330, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Derbis Huaman Huancas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(330, 383)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Alvaro Cabanillas Torres"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(330, 404)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Carlos Cortez Rubio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(330, 424)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Carlos Fernandez Saldaña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(330, 444)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(217, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Luiggi Guerrero Sernaque"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 658)
        Me.Controls.Add(Me.Escritorio)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.iconoactual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Escritorio.ResumeLayout(False)
        Me.Escritorio.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents iconoactual As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents titulo As Label
    Friend WithEvents Escritorio As Panel
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnrestaurar As Button
    Friend WithEvents btnminimizar As Button
    Friend WithEvents btncerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
