Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class MenuPrincipal
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 42)
        panelMenu.Controls.Add(leftBorderBtn)
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            iconoactual.IconChar = currentBtn.IconChar
            iconoactual.IconColor = customColor
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Escritorio.Controls.Add(childForm)
        Escritorio.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        titulo.Text = childForm.Text
    End Sub
    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        iconoactual.IconChar = IconChar.Home
        iconoactual.IconColor = Color.MediumPurple
        titulo.Text = "Inicio"
    End Sub



    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        ActivateButton(sender, RGB.color1)
        OpenChildForm(New FrmEstudiante)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        ActivateButton(sender, RGB.color2)
        ' OpenChildForm(New FormDashboard)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        ActivateButton(sender, RGB.color3)
        ' OpenChildForm(New FormCustomers)
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        ActivateButton(sender, RGB.color4)
        ' OpenChildForm(New FormCustomers)
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        ActivateButton(sender, RGB.color5)
        ' OpenChildForm(New FormCustomers)
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles IconButton1.Click

    End Sub

    Private Sub IconButton2_Click_1(sender As Object, e As EventArgs) Handles IconButton2.Click

    End Sub

    Private Sub Escritorio_Paint(sender As Object, e As PaintEventArgs) Handles Escritorio.Paint

    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub


    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnrestaurar_Click(sender As Object, e As EventArgs) Handles btnrestaurar.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
