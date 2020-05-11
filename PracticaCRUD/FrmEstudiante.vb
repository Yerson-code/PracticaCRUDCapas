Imports CapaEntidades
Imports CapaNegocio
Public Class FrmEstudiante
    Dim objEntidades As New Estudiante
    Dim objNegocio As New ClassEstudiante
    Dim dt As DataTable
    Private Sub mostrar()
        dt = objNegocio.mostrarEstudiante
        listado.DataSource = dt
    End Sub
    Private Sub limpiar()
        txtnombre.Text = ""
        txtapellidos.Text = ""
        txtdni.Text = ""
        txtnombre.Focus()
    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = " nombre like '%" & txtbuscar.Text & "%'"
            If dv.Count <> 0 Then
                listado.DataSource = dv
            Else

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub FrmEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnombre.Focus()
        mostrar()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        objEntidades.gNombre = txtnombre.Text
        objEntidades.gApellidos = txtapellidos.Text
        objEntidades.gDni = txtdni.Text
        objEntidades.gCarrera = cboespecialidad.Text
        If objNegocio.insertarEstudiante(objEntidades) Then
            MsgBox("Guardado correctamente", vbInformation, "Guardado")
            mostrar()
            limpiar()
        Else
            MsgBox("No se pudo insertar", vbCritical, "Error")
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If MsgBox("Desea eliminar ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            objEntidades.gIdestudiante = listado.CurrentRow.Cells(0).Value
            If objNegocio.eliminarEstudiante(objEntidades) Then
                MsgBox("Eliminado correctamente", vbInformation, "Eliminado")
                mostrar()
                limpiar()
            Else
                MsgBox("No se pudo eliminar", vbCritical, "Error")
            End If
        End If
    End Sub

    Private Sub listado_Click(sender As Object, e As EventArgs) Handles listado.Click
        Try

            txtnombre.Text = listado.CurrentRow.Cells(1).Value
            txtapellidos.Text = listado.CurrentRow.Cells(2).Value
            txtdni.Text = listado.CurrentRow.Cells(3).Value
            cboespecialidad.Text = listado.CurrentRow.Cells(4).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        objEntidades.gIdestudiante = listado.CurrentRow.Cells(0).Value
        objEntidades.gNombre = txtnombre.Text
        objEntidades.gApellidos = txtapellidos.Text
        objEntidades.gDni = txtdni.Text
        objEntidades.gCarrera = cboespecialidad.Text
        If objNegocio.modifiarEstudiante(objEntidades) Then
            MsgBox("Modificado correctamente", vbInformation, "Modificado")
            mostrar()
            limpiar()
        Else
            MsgBox("No se pudo modificar", vbCritical, "Error")
        End If
    End Sub

    Private Sub listado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles listado.CellContentClick

    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class