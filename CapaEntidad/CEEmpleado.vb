Public Class CEEmpleado
    Public Property EmpleadoId As Integer
    Public Property EmpNombre As String
    Public Property TipoIdent As CETipoIdentificacion
    Public Property EmpIdentificacion As String
    Public Property EmpFechaIngreso As Date
    Public Property EmpSalBase As Double
    Public Property EmpDireccion As String

    Public Sub New(empleadoId As Integer, empNombre As String, tipoIdent As CETipoIdentificacion, empIdentificacion As String, empFechaIngreso As Date, empSalBase As Double, empDireccion As String)
        If empNombre Is Nothing Then
            Throw New ArgumentNullException(NameOf(empNombre))
        End If

        If tipoIdent Is Nothing Then
            Throw New ArgumentNullException(NameOf(tipoIdent))
        End If

        If empIdentificacion Is Nothing Then
            Throw New ArgumentNullException(NameOf(empIdentificacion))
        End If

        If empDireccion Is Nothing Then
            Throw New ArgumentNullException(NameOf(empDireccion))
        End If

        Me.EmpleadoId = empleadoId
        Me.EmpNombre = empNombre
        Me.TipoIdent = tipoIdent
        Me.EmpIdentificacion = empIdentificacion
        Me.EmpFechaIngreso = empFechaIngreso
        Me.EmpSalBase = empSalBase
        Me.EmpDireccion = empDireccion
    End Sub

    Public Sub New(empNombre As String, tipoIdent As CETipoIdentificacion, empIdentificacion As String, empFechaIngreso As Date, empSalBase As Double, empDireccion As String)
        If empNombre Is Nothing Then
            Throw New ArgumentNullException(NameOf(empNombre))
        End If

        If tipoIdent Is Nothing Then
            Throw New ArgumentNullException(NameOf(tipoIdent))
        End If

        If empIdentificacion Is Nothing Then
            Throw New ArgumentNullException(NameOf(empIdentificacion))
        End If

        If empDireccion Is Nothing Then
            Throw New ArgumentNullException(NameOf(empDireccion))
        End If

        Me.EmpNombre = empNombre
        Me.TipoIdent = tipoIdent
        Me.EmpIdentificacion = empIdentificacion
        Me.EmpFechaIngreso = empFechaIngreso
        Me.EmpSalBase = empSalBase
        Me.EmpDireccion = empDireccion
    End Sub
End Class