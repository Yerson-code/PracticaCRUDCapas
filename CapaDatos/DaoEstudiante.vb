Imports System.Data.SqlClient
Imports CapaEntidades
Public Class DaoEstudiante
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function mostrarDatos() As DataTable
        conectar()
        Try
            Dim mostrar As New DataTable
            cmd = New SqlCommand("select * from ESTUDIANTE")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conex
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(mostrar)
            Return mostrar
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
            desconectar()
        End Try
        desconectar()
    End Function
    Public Function insertar(ByVal dts As Estudiante) As Boolean
        conectar()
        Try
            cmd = New SqlCommand("insert into estudiante(nombre,apellidos,dni,carrera)values(@nombre,@apellidos,@dni,@carrera)")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conex
            cmd.Parameters.AddWithValue("@nombre", dts.gNombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.gApellidos)
            cmd.Parameters.AddWithValue("@dni", dts.gDni)
            cmd.Parameters.AddWithValue("@carrera", dts.gCarrera)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function modificar(ByVal dts As Estudiante) As Boolean
        conectar()
        Try
            cmd = New SqlCommand("update estudiante set nombre=@nombre,apellidos=@apellidos,dni=@dni,carrera=@carrera where idestudiante=@idestudiante")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conex
            cmd.Parameters.AddWithValue("@idestudiante", dts.gIdestudiante)
            cmd.Parameters.AddWithValue("@nombre", dts.gNombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.gApellidos)
            cmd.Parameters.AddWithValue("@dni", dts.gDni)
            cmd.Parameters.AddWithValue("@carrera", dts.gCarrera)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function eliminar(ByVal dts As Estudiante)
        Try
            cmd = New SqlCommand("delete from estudiante where idestudiante=@idestudiante")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conex
            cmd.Parameters.AddWithValue("@idestudiante", dts.gIdestudiante)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
