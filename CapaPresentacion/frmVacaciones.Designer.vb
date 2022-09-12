<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVacaciones
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.dgEmpleadoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgTiIdentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgTipoIdent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgEmpIdent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgEmpFechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgEmpSalBaseMen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgEmpDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.tabEmpleado = New System.Windows.Forms.TabPage()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblSalBase = New System.Windows.Forms.Label()
        Me.tbxSalBase = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTipoIdent = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.cbxTipIdent = New System.Windows.Forms.ComboBox()
        Me.tbxDireccion = New System.Windows.Forms.TextBox()
        Me.tbxIdentificacion = New System.Windows.Forms.TextBox()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.tabVacacion = New System.Windows.Forms.TabPage()
        Me.lblDiasVac = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnEditarVacacion = New System.Windows.Forms.Button()
        Me.btnEliminarVacacion = New System.Windows.Forms.Button()
        Me.dgvVacaciones = New System.Windows.Forms.DataGridView()
        Me.dgvEmpleados2 = New System.Windows.Forms.DataGridView()
        Me.dgEmpleadoId2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgVacacionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgVacacionEmpleadoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgVacacionFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgVacacionFechaIni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgVacacionFechaFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgVacacionDias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabs.SuspendLayout()
        Me.tabEmpleado.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tabVacacion.SuspendLayout()
        CType(Me.dgvVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmpleados2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgEmpleadoId, Me.dgNombre, Me.dgTiIdentId, Me.dgTipoIdent, Me.dgEmpIdent, Me.dgEmpFechaIngreso, Me.dgEmpSalBaseMen, Me.dgEmpDireccion})
        Me.dgvEmpleados.Location = New System.Drawing.Point(8, 11)
        Me.dgvEmpleados.MultiSelect = False
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.Size = New System.Drawing.Size(380, 292)
        Me.dgvEmpleados.TabIndex = 0
        '
        'dgEmpleadoId
        '
        Me.dgEmpleadoId.DataPropertyName = "empleado_id"
        Me.dgEmpleadoId.HeaderText = "EmpleadoId"
        Me.dgEmpleadoId.Name = "dgEmpleadoId"
        Me.dgEmpleadoId.ReadOnly = True
        Me.dgEmpleadoId.Visible = False
        '
        'dgNombre
        '
        Me.dgNombre.DataPropertyName = "emp_nombre"
        Me.dgNombre.HeaderText = "Nombre"
        Me.dgNombre.Name = "dgNombre"
        Me.dgNombre.ReadOnly = True
        '
        'dgTiIdentId
        '
        Me.dgTiIdentId.DataPropertyName = "tipo_ident_id"
        Me.dgTiIdentId.HeaderText = "IdentificacionId"
        Me.dgTiIdentId.Name = "dgTiIdentId"
        Me.dgTiIdentId.ReadOnly = True
        Me.dgTiIdentId.Visible = False
        '
        'dgTipoIdent
        '
        Me.dgTipoIdent.DataPropertyName = "tipo"
        Me.dgTipoIdent.HeaderText = "Tipo Identificación"
        Me.dgTipoIdent.Name = "dgTipoIdent"
        Me.dgTipoIdent.ReadOnly = True
        '
        'dgEmpIdent
        '
        Me.dgEmpIdent.DataPropertyName = "emp_identificacion"
        Me.dgEmpIdent.HeaderText = "Identificación"
        Me.dgEmpIdent.Name = "dgEmpIdent"
        Me.dgEmpIdent.ReadOnly = True
        '
        'dgEmpFechaIngreso
        '
        Me.dgEmpFechaIngreso.DataPropertyName = "emp_fecha_ingreso"
        Me.dgEmpFechaIngreso.HeaderText = "Fecha de Ingreso"
        Me.dgEmpFechaIngreso.Name = "dgEmpFechaIngreso"
        Me.dgEmpFechaIngreso.ReadOnly = True
        '
        'dgEmpSalBaseMen
        '
        Me.dgEmpSalBaseMen.DataPropertyName = "emp_sal_base_men"
        Me.dgEmpSalBaseMen.HeaderText = "Salario base mensual"
        Me.dgEmpSalBaseMen.Name = "dgEmpSalBaseMen"
        Me.dgEmpSalBaseMen.ReadOnly = True
        '
        'dgEmpDireccion
        '
        Me.dgEmpDireccion.DataPropertyName = "emp_direccion"
        Me.dgEmpDireccion.HeaderText = "Dirección"
        Me.dgEmpDireccion.Name = "dgEmpDireccion"
        Me.dgEmpDireccion.ReadOnly = True
        '
        'tabs
        '
        Me.tabs.AccessibleName = ""
        Me.tabs.Controls.Add(Me.tabEmpleado)
        Me.tabs.Controls.Add(Me.tabVacacion)
        Me.tabs.Location = New System.Drawing.Point(0, 0)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(654, 362)
        Me.tabs.TabIndex = 1
        '
        'tabEmpleado
        '
        Me.tabEmpleado.Controls.Add(Me.btnEditar)
        Me.tabEmpleado.Controls.Add(Me.btnEliminar)
        Me.tabEmpleado.Controls.Add(Me.btnAgregar)
        Me.tabEmpleado.Controls.Add(Me.Panel1)
        Me.tabEmpleado.Controls.Add(Me.dgvEmpleados)
        Me.tabEmpleado.Location = New System.Drawing.Point(4, 22)
        Me.tabEmpleado.Name = "tabEmpleado"
        Me.tabEmpleado.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEmpleado.Size = New System.Drawing.Size(646, 336)
        Me.tabEmpleado.TabIndex = 0
        Me.tabEmpleado.Text = "Empleado"
        Me.tabEmpleado.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(235, 308)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(313, 308)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(154, 309)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 21)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.lblDireccion)
        Me.Panel1.Controls.Add(Me.lblSalBase)
        Me.Panel1.Controls.Add(Me.tbxSalBase)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblTipoIdent)
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Controls.Add(Me.dtpFechaIngreso)
        Me.Panel1.Controls.Add(Me.cbxTipIdent)
        Me.Panel1.Controls.Add(Me.tbxDireccion)
        Me.Panel1.Controls.Add(Me.tbxIdentificacion)
        Me.Panel1.Controls.Add(Me.tbxNombre)
        Me.Panel1.Location = New System.Drawing.Point(399, -9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(251, 350)
        Me.Panel1.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(157, 284)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(76, 284)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(18, 189)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 11
        Me.lblDireccion.Text = "Direccion"
        '
        'lblSalBase
        '
        Me.lblSalBase.AutoSize = True
        Me.lblSalBase.Location = New System.Drawing.Point(115, 138)
        Me.lblSalBase.Name = "lblSalBase"
        Me.lblSalBase.Size = New System.Drawing.Size(65, 13)
        Me.lblSalBase.TabIndex = 10
        Me.lblSalBase.Text = "Salario base"
        '
        'tbxSalBase
        '
        Me.tbxSalBase.Location = New System.Drawing.Point(118, 154)
        Me.tbxSalBase.Name = "tbxSalBase"
        Me.tbxSalBase.Size = New System.Drawing.Size(114, 20)
        Me.tbxSalBase.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha ingreso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Identificacion"
        '
        'lblTipoIdent
        '
        Me.lblTipoIdent.AutoSize = True
        Me.lblTipoIdent.Location = New System.Drawing.Point(18, 89)
        Me.lblTipoIdent.Name = "lblTipoIdent"
        Me.lblTipoIdent.Size = New System.Drawing.Size(93, 13)
        Me.lblTipoIdent.TabIndex = 6
        Me.lblTipoIdent.Text = "Tipo identificacion"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(18, 41)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(90, 13)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.Text = "Nombre completo"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.CustomFormat = "dd-MM-yyyy"
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(21, 154)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(87, 20)
        Me.dtpFechaIngreso.TabIndex = 4
        '
        'cbxTipIdent
        '
        Me.cbxTipIdent.FormattingEnabled = True
        Me.cbxTipIdent.Location = New System.Drawing.Point(21, 104)
        Me.cbxTipIdent.Name = "cbxTipIdent"
        Me.cbxTipIdent.Size = New System.Drawing.Size(87, 21)
        Me.cbxTipIdent.TabIndex = 3
        '
        'tbxDireccion
        '
        Me.tbxDireccion.Location = New System.Drawing.Point(21, 205)
        Me.tbxDireccion.Multiline = True
        Me.tbxDireccion.Name = "tbxDireccion"
        Me.tbxDireccion.Size = New System.Drawing.Size(211, 63)
        Me.tbxDireccion.TabIndex = 2
        '
        'tbxIdentificacion
        '
        Me.tbxIdentificacion.Location = New System.Drawing.Point(118, 105)
        Me.tbxIdentificacion.Name = "tbxIdentificacion"
        Me.tbxIdentificacion.Size = New System.Drawing.Size(114, 20)
        Me.tbxIdentificacion.TabIndex = 1
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(21, 57)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(211, 20)
        Me.tbxNombre.TabIndex = 0
        '
        'tabVacacion
        '
        Me.tabVacacion.Controls.Add(Me.Button1)
        Me.tabVacacion.Controls.Add(Me.lblDiasVac)
        Me.tabVacacion.Controls.Add(Me.Label4)
        Me.tabVacacion.Controls.Add(Me.dtpFechaFin)
        Me.tabVacacion.Controls.Add(Me.Label3)
        Me.tabVacacion.Controls.Add(Me.dtpFechaIni)
        Me.tabVacacion.Controls.Add(Me.Button6)
        Me.tabVacacion.Controls.Add(Me.Button5)
        Me.tabVacacion.Controls.Add(Me.btnReporte)
        Me.tabVacacion.Controls.Add(Me.btnEditarVacacion)
        Me.tabVacacion.Controls.Add(Me.btnEliminarVacacion)
        Me.tabVacacion.Controls.Add(Me.dgvVacaciones)
        Me.tabVacacion.Controls.Add(Me.dgvEmpleados2)
        Me.tabVacacion.Location = New System.Drawing.Point(4, 22)
        Me.tabVacacion.Name = "tabVacacion"
        Me.tabVacacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVacacion.Size = New System.Drawing.Size(646, 336)
        Me.tabVacacion.TabIndex = 1
        Me.tabVacacion.Text = "Vacaciones"
        Me.tabVacacion.UseVisualStyleBackColor = True
        '
        'lblDiasVac
        '
        Me.lblDiasVac.AutoSize = True
        Me.lblDiasVac.Location = New System.Drawing.Point(316, 64)
        Me.lblDiasVac.Name = "lblDiasVac"
        Me.lblDiasVac.Size = New System.Drawing.Size(30, 13)
        Me.lblDiasVac.TabIndex = 16
        Me.lblDiasVac.Text = "Días"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(420, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Fecha fin"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CustomFormat = "dd-MM-yyyy"
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.Location = New System.Drawing.Point(423, 30)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(87, 20)
        Me.dtpFechaFin.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(316, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Fecha inicio"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.CustomFormat = "dd-MM-yyyy"
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaIni.Location = New System.Drawing.Point(319, 30)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(87, 20)
        Me.dtpFechaIni.TabIndex = 11
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(565, 11)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Cancelar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(565, 40)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Guardar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(8, 11)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(125, 23)
        Me.btnReporte.TabIndex = 7
        Me.btnReporte.Text = "Reporte vacaciones"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnEditarVacacion
        '
        Me.btnEditarVacacion.Location = New System.Drawing.Point(396, 105)
        Me.btnEditarVacacion.Name = "btnEditarVacacion"
        Me.btnEditarVacacion.Size = New System.Drawing.Size(75, 23)
        Me.btnEditarVacacion.TabIndex = 6
        Me.btnEditarVacacion.Text = "Editar"
        Me.btnEditarVacacion.UseVisualStyleBackColor = True
        '
        'btnEliminarVacacion
        '
        Me.btnEliminarVacacion.Location = New System.Drawing.Point(315, 105)
        Me.btnEliminarVacacion.Name = "btnEliminarVacacion"
        Me.btnEliminarVacacion.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarVacacion.TabIndex = 5
        Me.btnEliminarVacacion.Text = "Eliminar"
        Me.btnEliminarVacacion.UseVisualStyleBackColor = True
        '
        'dgvVacaciones
        '
        Me.dgvVacaciones.AllowUserToAddRows = False
        Me.dgvVacaciones.AllowUserToDeleteRows = False
        Me.dgvVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVacaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgVacacionId, Me.dgVacacionEmpleadoId, Me.dgVacacionFecha, Me.dgVacacionFechaIni, Me.dgVacacionFechaFin, Me.dgVacacionDias})
        Me.dgvVacaciones.Location = New System.Drawing.Point(311, 134)
        Me.dgvVacaciones.Name = "dgvVacaciones"
        Me.dgvVacaciones.ReadOnly = True
        Me.dgvVacaciones.Size = New System.Drawing.Size(326, 197)
        Me.dgvVacaciones.TabIndex = 4
        '
        'dgvEmpleados2
        '
        Me.dgvEmpleados2.AllowUserToAddRows = False
        Me.dgvEmpleados2.AllowUserToDeleteRows = False
        Me.dgvEmpleados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgEmpleadoId2, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgvEmpleados2.Location = New System.Drawing.Point(8, 40)
        Me.dgvEmpleados2.MultiSelect = False
        Me.dgvEmpleados2.Name = "dgvEmpleados2"
        Me.dgvEmpleados2.ReadOnly = True
        Me.dgvEmpleados2.Size = New System.Drawing.Size(297, 291)
        Me.dgvEmpleados2.TabIndex = 1
        '
        'dgEmpleadoId2
        '
        Me.dgEmpleadoId2.DataPropertyName = "empleado_id"
        Me.dgEmpleadoId2.HeaderText = "EmpleadoId"
        Me.dgEmpleadoId2.Name = "dgEmpleadoId2"
        Me.dgEmpleadoId2.ReadOnly = True
        Me.dgEmpleadoId2.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "emp_nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tipo_ident_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdentificacionId"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tipo Identificación"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "emp_identificacion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Identificación"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "emp_fecha_ingreso"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha de Ingreso"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "emp_sal_base_men"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Salario base mensual"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "emp_direccion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'dgVacacionId
        '
        Me.dgVacacionId.DataPropertyName = "vacacion_id"
        Me.dgVacacionId.HeaderText = "VacacionId"
        Me.dgVacacionId.Name = "dgVacacionId"
        Me.dgVacacionId.ReadOnly = True
        Me.dgVacacionId.Visible = False
        '
        'dgVacacionEmpleadoId
        '
        Me.dgVacacionEmpleadoId.DataPropertyName = "empleado_id"
        Me.dgVacacionEmpleadoId.HeaderText = "EmpleadoId"
        Me.dgVacacionEmpleadoId.Name = "dgVacacionEmpleadoId"
        Me.dgVacacionEmpleadoId.ReadOnly = True
        Me.dgVacacionEmpleadoId.Visible = False
        '
        'dgVacacionFecha
        '
        Me.dgVacacionFecha.DataPropertyName = "fecha"
        Me.dgVacacionFecha.HeaderText = "Solicidada"
        Me.dgVacacionFecha.Name = "dgVacacionFecha"
        Me.dgVacacionFecha.ReadOnly = True
        '
        'dgVacacionFechaIni
        '
        Me.dgVacacionFechaIni.DataPropertyName = "fecha_ini"
        DataGridViewCellStyle5.Format = "d"
        Me.dgVacacionFechaIni.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgVacacionFechaIni.HeaderText = "Inicia"
        Me.dgVacacionFechaIni.Name = "dgVacacionFechaIni"
        Me.dgVacacionFechaIni.ReadOnly = True
        '
        'dgVacacionFechaFin
        '
        Me.dgVacacionFechaFin.DataPropertyName = "fecha_fin"
        DataGridViewCellStyle6.Format = "d"
        Me.dgVacacionFechaFin.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgVacacionFechaFin.HeaderText = "Finaliza"
        Me.dgVacacionFechaFin.Name = "dgVacacionFechaFin"
        Me.dgVacacionFechaFin.ReadOnly = True
        '
        'dgVacacionDias
        '
        Me.dgVacacionDias.DataPropertyName = "dias"
        Me.dgVacacionDias.HeaderText = "Días"
        Me.dgVacacionDias.Name = "dgVacacionDias"
        Me.dgVacacionDias.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(139, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Reporte calculos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmVacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 359)
        Me.Controls.Add(Me.tabs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmVacaciones"
        Me.Text = "Form1"
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabs.ResumeLayout(False)
        Me.tabEmpleado.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabVacacion.ResumeLayout(False)
        Me.tabVacacion.PerformLayout()
        CType(Me.dgvVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmpleados2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents tabs As TabControl
    Friend WithEvents tabEmpleado As TabPage
    Friend WithEvents tabVacacion As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblNombre As Label
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents cbxTipIdent As ComboBox
    Friend WithEvents tbxDireccion As TextBox
    Friend WithEvents tbxIdentificacion As TextBox
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTipoIdent As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblSalBase As Label
    Friend WithEvents tbxSalBase As TextBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents dgEmpleadoId As DataGridViewTextBoxColumn
    Friend WithEvents dgNombre As DataGridViewTextBoxColumn
    Friend WithEvents dgTiIdentId As DataGridViewTextBoxColumn
    Friend WithEvents dgTipoIdent As DataGridViewTextBoxColumn
    Friend WithEvents dgEmpIdent As DataGridViewTextBoxColumn
    Friend WithEvents dgEmpFechaIngreso As DataGridViewTextBoxColumn
    Friend WithEvents dgEmpSalBaseMen As DataGridViewTextBoxColumn
    Friend WithEvents dgEmpDireccion As DataGridViewTextBoxColumn
    Friend WithEvents dgvEmpleados2 As DataGridView
    Friend WithEvents btnReporte As Button
    Friend WithEvents btnEditarVacacion As Button
    Friend WithEvents btnEliminarVacacion As Button
    Friend WithEvents dgvVacaciones As DataGridView
    Friend WithEvents lblDiasVac As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFechaIni As DateTimePicker
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents dgEmpleadoId2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents dgVacacionId As DataGridViewTextBoxColumn
    Friend WithEvents dgVacacionEmpleadoId As DataGridViewTextBoxColumn
    Friend WithEvents dgVacacionFecha As DataGridViewTextBoxColumn
    Friend WithEvents dgVacacionFechaIni As DataGridViewTextBoxColumn
    Friend WithEvents dgVacacionFechaFin As DataGridViewTextBoxColumn
    Friend WithEvents dgVacacionDias As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
