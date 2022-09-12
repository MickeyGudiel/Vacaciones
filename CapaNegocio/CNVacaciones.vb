Imports CapaDatos
Imports CapaEntidad

Public Class CNVacaciones
    ReadOnly ObjCDVacacion As New CDVacacion

    Function ObtenerVacaciones(EmpleadoId As Integer) As DataTable
        Return ObjCDVacacion.ObtenerVacaciones(EmpleadoId)
    End Function

    Function EditarVacacion(Vacacion As CEVacacion) As Boolean
        Return ObjCDVacacion.EditarVacacion(Vacacion)
    End Function

    Function CrearVacacion(Vacacion As CEVacacion) As Boolean
        Return ObjCDVacacion.CrearVacacion(Vacacion)
    End Function

    Function EliminarVacacion(VacacionId As Integer) As Boolean
        Return ObjCDVacacion.EliminarVacacion(VacacionId)
    End Function

End Class
