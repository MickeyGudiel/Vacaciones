Imports CapaDatos
Imports CapaEntidad

Public Class CNEmpleados
    ReadOnly ObjCDEmpleado As New CDEmpleado

    Function ObtenerEmpleados() As DataSet
        Return ObjCDEmpleado.ObtenerEmpleados()
    End Function

    Function InsertarEmpleado(empleado As CEEmpleado) As Boolean
        Return ObjCDEmpleado.InsertarEmpleado(empleado)
    End Function

    Function EditarEmpleado(empleado As CEEmpleado) As Boolean
        Return ObjCDEmpleado.EditarEmpleado(empleado)
    End Function

    Function ObtenerTipoIdents() As DataSet
        Return ObjCDEmpleado.ObtenerTipoIdents()
    End Function

    Function EliminarEmpleado(EmpleadoId As Integer) As Boolean
        Return ObjCDEmpleado.EliminarEmpleado(EmpleadoId)
    End Function
End Class
