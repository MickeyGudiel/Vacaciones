Imports CapaEntidad
Imports CapaNegocio
Public Class frmVacaciones
    ReadOnly utils As New Utils
    Dim esEditarEmpleado As Boolean = False
    Dim esEditarVacacion As Boolean = False
    Dim empleadoSeleccionado As CEEmpleado = Nothing
    Dim vacacionSeleccionada As CEVacacion = Nothing
    Dim empleadoIdvacacion As Integer = -1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccionesEnDataGrid(dgvVacaciones)
        AccionesEnDataGrid(dgvEmpleados)
        AccionesEnDataGrid(dgvEmpleados2)
        LlenarGridEmpleado()
        LlenarCBoxTipoIdent()
        cbxTipIdent.DisplayMember = "tipo"
        cbxTipIdent.ValueMember = "tipo_ident_id"
        InhabilitarCamposEmpleado()
    End Sub

    Private Sub AccionesEnDataGrid(ByRef dgv As DataGridView)
        dgv.AutoGenerateColumns = False
        dgv.SelectionMode = SelectionMode.One
    End Sub

    Public Sub LlenarGridEmpleado()
        SetDGrdEmpleados(dgvEmpleados.DataSource)
        SetDGrdEmpleados(dgvEmpleados2.DataSource)
    End Sub

    Public Sub LlenarGridVacaciones()
        If (dgvEmpleados2.SelectedRows.Count > 0) Then
            Dim empSel = dgvEmpleados2.SelectedRows(0).Cells("dgEmpleadoId2").Value
            If (empSel <> Nothing) Then
                Dim objCNVacaciones As New CNVacaciones
                dgvVacaciones.DataSource = objCNVacaciones.ObtenerVacaciones(empSel)
            End If
        End If
    End Sub

    Public Sub LlenarCBoxTipoIdent()
        SetCBoxEmpleados(cbxTipIdent.DataSource)
    End Sub

    Private Sub InhabilitarCamposEmpleado()
        tbxNombre.ReadOnly = True
        tbxSalBase.ReadOnly = True
        tbxDireccion.ReadOnly = True
        tbxIdentificacion.ReadOnly = True
        btnGuardar.Visible = False
        LimpiarCamposEmpleado()
    End Sub

    Private Sub HabilitarCamposEmpleado()
        tbxNombre.ReadOnly = False
        tbxSalBase.ReadOnly = False
        tbxDireccion.ReadOnly = False
        tbxIdentificacion.ReadOnly = False
        btnGuardar.Visible = True
    End Sub

    Private Sub LimpiarCamposEmpleado()
        empleadoSeleccionado = Nothing
        tbxNombre.Clear()
        tbxSalBase.Clear()
        tbxDireccion.Clear()
        tbxIdentificacion.Clear()
        cbxTipIdent.SelectedValue = 1
        dtpFechaIngreso.ResetText()
    End Sub

    Private Sub LimpiarCamposVacacion()
        vacacionSeleccionada = Nothing
        dtpFechaIni.ResetText()
        dtpFechaFin.ResetText()
        lblDiasVac.Text = "Días:" + DifDias().ToString()
        esEditarVacacion = False
    End Sub

    Private Function DifDias() As Long
        Dim dias As Long = DateDiff(DateInterval.Day, GetFechaIniVacacion, GetFechaFinVacacion)
        If dias <= 0 Then
            Return 1
        Else
            Return dias
        End If
    End Function

    Public Sub LlenarCamposParaEditarEmpleado()
        If empleadoSeleccionado Is Nothing Then
            Throw New ArgumentNullException(NameOf(empleadoSeleccionado))
        Else
            tbxNombre.Text = empleadoSeleccionado.EmpNombre
            tbxSalBase.Text = empleadoSeleccionado.EmpSalBase
            tbxDireccion.Text = empleadoSeleccionado.EmpDireccion
            tbxIdentificacion.Text = empleadoSeleccionado.EmpIdentificacion
            cbxTipIdent.SelectedValue = empleadoSeleccionado.TipoIdent.TipoIdentId
            dtpFechaIngreso.Text = empleadoSeleccionado.EmpFechaIngreso
        End If
    End Sub

    Public Sub LlenarCamposParaEditarVacacion()
        If vacacionSeleccionada Is Nothing Then
            Throw New ArgumentNullException(NameOf(empleadoSeleccionado))
        Else
            dtpFechaFin.Text = vacacionSeleccionada.FechaIni
            dtpFechaIni.Text = vacacionSeleccionada.FechaFin
            lblDiasVac.Text = "Días: " + vacacionSeleccionada.dias.ToString()
        End If
    End Sub

    Private Sub SetDGrdEmpleados(ByRef val As Object)
        Dim objCNEmpleados As New CNEmpleados
        val = objCNEmpleados.ObtenerEmpleados.Tables("Empleados")
    End Sub

    Private Sub SetCBoxEmpleados(ByRef val As Object)
        Dim objCNEmpleados As New CNEmpleados
        val = objCNEmpleados.ObtenerTipoIdents.Tables("TipoIdentificacion")
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        InhabilitarCamposEmpleado()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (esEditarEmpleado) Then
            Dim objCNEmpleados As New CNEmpleados
            Dim empleadoEditado As Boolean = objCNEmpleados.EditarEmpleado(ObjEmpleado)
            If (empleadoEditado) Then
                MsgBox("Empleado editado correctamente", MsgBoxStyle.OkOnly, "Empleado Editado")
            End If
        Else
            Dim objCNEmpleados As New CNEmpleados
            Dim empleadoInsertado As Boolean = objCNEmpleados.InsertarEmpleado(ObjEmpleado)
            If (empleadoInsertado) Then
                MsgBox("Empleado agregado correctamente", MsgBoxStyle.OkOnly, "Empleado agregado")
            End If
        End If
        LlenarGridEmpleado()
        InhabilitarCamposEmpleado()
    End Sub

    Private Function ObjEmpleado()
        Dim value As Double
        StrToDouble(value, GetSalBase(), "Ingrese un salario base valido")
        Dim TipoIdent As New CETipoIdentificacion(cbxTipIdent.SelectedValue, cbxTipIdent.SelectedText)
        If (esEditarEmpleado) Then
            Return New CEEmpleado(empleadoSeleccionado.EmpleadoId, GetNombre(), TipoIdent, GetIdentificacion(), GetFechaInicio(), value, GetDireccion())
        Else
            Return New CEEmpleado(GetNombre(), TipoIdent, GetIdentificacion(), GetFechaInicio(), value, GetDireccion())
        End If
    End Function

    Private Function ObjVacacion()
        If (esEditarVacacion) Then
            Return New CEVacacion(vacacionSeleccionada.VacacionId, vacacionSeleccionada.EmpleadoId, vacacionSeleccionada.FechaSol, GetFechaIniVacacion, GetFechaFinVacacion, DifDias)
        Else
            Return New CEVacacion(empleadoIdvacacion, Date.Now(), GetFechaIniVacacion, GetFechaFinVacacion, DifDias)
        End If
    End Function

    Private Sub StrToDouble(ByRef ret As Double, str As String, msj As String)
        Try
            Double.TryParse(str, ret)
        Catch ex As Exception
            MsgBox(msj)
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        esEditarEmpleado = False
        LimpiarCamposEmpleado()
        HabilitarCamposEmpleado()
    End Sub

    Private Function GetNombre() As String
        Return tbxNombre.Text
    End Function

    Private Function GetTipIdent() As String
        Return cbxTipIdent.SelectedValue
    End Function

    Private Function GetSalBase() As String
        Return tbxSalBase.Text
    End Function

    Private Function GetIdentificacion() As String
        Return tbxIdentificacion.Text
    End Function

    Private Function GetDireccion() As String
        Return tbxDireccion.Text
    End Function

    Private Function GetFechaInicio() As Date
        Return utils.ParsearFecha(dtpFechaIngreso.Value)
    End Function

    Private Function GetFechaIniVacacion() As Date
        Return utils.ParsearFecha(dtpFechaIni.Value)
    End Function

    Private Function GetFechaFinVacacion() As Date
        Return utils.ParsearFecha(dtpFechaFin.Value)
    End Function

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (dgvEmpleados.SelectedRows.Count > 0) Then
            esEditarEmpleado = True
            Dim EmpleadoId As String = dgvEmpleados.SelectedRows(0).Cells("dgEmpleadoId").Value.ToString
            Dim filaSeleccionada As DataGridViewRow = dgvEmpleados.SelectedRows(0)
            Dim TipoIden As New CETipoIdentificacion(filaSeleccionada.Cells("dgTiIdentId").Value,
                                                     filaSeleccionada.Cells("dgTipoIdent").Value)
            empleadoSeleccionado = New CEEmpleado(filaSeleccionada.Cells("dgEmpleadoId").Value,
                                     filaSeleccionada.Cells("dgNombre").Value, TipoIden,
                                     filaSeleccionada.Cells("dgEmpIdent").Value,
                                     filaSeleccionada.Cells("dgEmpFechaIngreso").Value,
                                     filaSeleccionada.Cells("dgEmpSalBaseMen").Value,
                                     filaSeleccionada.Cells("dgEmpDireccion").Value)
            LlenarCamposParaEditarEmpleado()
            HabilitarCamposEmpleado()
            btnGuardar.Visible = True
        Else
            MsgBox("No hay empleado seleccionado para editar", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (dgvEmpleados.SelectedRows.Count > 0) Then
            Dim objCNEmpleados As New CNEmpleados
            Dim empleadoEliminado As Boolean = objCNEmpleados.EliminarEmpleado(dgvEmpleados.SelectedRows(0).Cells("dgEmpleadoId").Value)
            If (empleadoEliminado) Then
                MsgBox("Empleado eliminado correctamente", MsgBoxStyle.OkOnly, "Empleado eliminado")
                LlenarGridEmpleado()
            End If
        Else
            MsgBox("No hay empleado seleccionado para borrar", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub tabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabs.SelectedIndexChanged
        If (tabs.SelectedIndex = 1) Then
            LlenarGridVacaciones()
        End If
    End Sub

    Private Sub btnEditarVacacion_Click(sender As Object, e As EventArgs) Handles btnEditarVacacion.Click
        If (dgvEmpleados2.SelectedRows.Count > 0) Then
            If (dgvVacaciones.SelectedRows.Count > 0) Then
                Dim filaSeleccionada As DataGridViewRow = dgvVacaciones.SelectedRows(0)
                Dim empSel = filaSeleccionada.Cells("dgVacacionEmpleadoId").Value
                If (empSel <> Nothing) Then
                    empleadoIdvacacion = empSel
                    vacacionSeleccionada = New CEVacacion(filaSeleccionada.Cells("dgVacacionId").Value,
                                                           empSel,
                                                           filaSeleccionada.Cells("dgVacacionFecha").Value,
                                                           filaSeleccionada.Cells("dgVacacionFechaIni").Value,
                                                           filaSeleccionada.Cells("dgVacacionFechaFin").Value,
                                                           filaSeleccionada.Cells("dgVacacionDias").Value)
                    LlenarCamposParaEditarVacacion()
                    esEditarVacacion = True
                End If
            Else
                MsgBox("No hay vacacion seleccionada para editar", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim objCNVacaciones As New CNVacaciones
        If (esEditarVacacion) Then
            dgvVacaciones.DataSource = objCNVacaciones.EditarVacacion(ObjVacacion())
        Else
            dgvVacaciones.DataSource = objCNVacaciones.CrearVacacion(ObjVacacion())
        End If
        LimpiarCamposVacacion()
        LlenarGridVacaciones()
        esEditarVacacion = False
    End Sub

    Private Sub dgvEmpleados2_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvEmpleados2.RowStateChanged
        If (dgvEmpleados2.SelectedRows.Count > 0) Then
            Dim filaSeleccionada As DataGridViewRow = dgvEmpleados2.SelectedRows(0)
            Dim empSel = filaSeleccionada.Cells("dgEmpleadoId2").Value
            If (empSel <> Nothing) Then
                empleadoIdvacacion = empSel
                LimpiarCamposVacacion()
                LlenarGridVacaciones()
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        LimpiarCamposVacacion()
    End Sub

    Private Sub dtpFechaIni_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaIni.ValueChanged
        lblDiasVac.Text = "Días:" + DifDias().ToString()
    End Sub

    Private Sub dtpFechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFin.ValueChanged
        lblDiasVac.Text = "Días:" + DifDias().ToString()
    End Sub

    Private Sub btnEliminarVacacion_Click(sender As Object, e As EventArgs) Handles btnEliminarVacacion.Click
        If (dgvVacaciones.SelectedRows.Count > 0) Then
            Dim filaSeleccionada As DataGridViewRow = dgvVacaciones.SelectedRows(0)
            Dim vacSel = filaSeleccionada.Cells("dgVacacionId").Value
            If (vacSel <> Nothing) Then
                Dim objCNVacaciones As New CNVacaciones
                Dim vacacionEliminada As Boolean = objCNVacaciones.EliminarVacacion(vacSel)
                If (vacacionEliminada) Then
                    MsgBox("Vacación eliminada correctamente", MsgBoxStyle.OkOnly, "Vacacion eliminada")
                Else
                    MsgBox("No se pudo eliminar la vacación", MsgBoxStyle.Critical, "Error")
                End If
                LlenarGridVacaciones()
            End If
        End If
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim frmReporte = New frmReporte()
        frmReporte.ShowDialog()
    End Sub

    Private Sub tbxSalBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxSalBase.KeyPress
        utils.NumerosyDecimal(tbxSalBase, e)
    End Sub
End Class
