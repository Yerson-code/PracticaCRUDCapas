Imports CapaDatos
Imports CapaEntidades
Public Class ClassEstudiante
    Dim objCapaDatos As New DaoEstudiante

    Public Function mostrarEstudiante() As DataTable
        Return objCapaDatos.mostrarDatos
    End Function

    Public Function insertarEstudiante(ByVal datos As Estudiante) As Boolean
        Return objCapaDatos.insertar(datos)
    End Function
    Public Function modifiarEstudiante(ByVal datos As Estudiante) As Boolean
        Return objCapaDatos.modificar(datos)
    End Function

    Public Function eliminarEstudiante(ByVal datos As Estudiante) As Boolean
        Return objCapaDatos.eliminar(datos)
    End Function
End Class
