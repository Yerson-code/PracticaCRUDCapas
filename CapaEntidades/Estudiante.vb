Public Class Estudiante
    Private idestudiante As Integer
    Private nombre As String
    Private apellidos As String
    Private dni As Integer
    Private carrera As String

    Public Property gIdestudiante As Integer
        Get
            Return idestudiante
        End Get
        Set(value As Integer)
            idestudiante = value
        End Set
    End Property

    Public Property gNombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property gApellidos As String
        Get
            Return apellidos
        End Get
        Set(value As String)
            apellidos = value
        End Set
    End Property

    Public Property gDni As Integer
        Get
            Return dni
        End Get
        Set(value As Integer)
            dni = value
        End Set
    End Property

    Public Property gCarrera As String
        Get
            Return carrera
        End Get
        Set(value As String)
            carrera = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
