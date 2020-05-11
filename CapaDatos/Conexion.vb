Imports System.Data.SqlClient
Public Class Conexion
    Protected conex As New SqlConnection
    Function conectar()
        Try
            conex = New SqlConnection("Data Source=(local);Initial Catalog=DB_CRUD;Integrated Security=True")
            conex.Open()
        Catch ex As Exception
            MsgBox("error en la conexion" & ex.Message)
        End Try
        Return conex
    End Function

    Protected Sub desconectar()
        If conex.State = ConnectionState.Open Then
            conex.Close()
        End If

    End Sub
End Class
