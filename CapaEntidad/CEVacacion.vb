Public Class CEVacacion
    Public Property VacacionId As Integer
    Public Property EmpleadoId As Integer
    Public Property FechaSol As Date
    Public Property FechaIni As Date
    Public Property FechaFin As Date
    Public Property dias As Long

    Public Sub New(empleadoId As Integer, fechaSol As Date, fechaIni As Date, fechaFin As Date, dias As Long)
        Me.EmpleadoId = empleadoId
        Me.FechaSol = fechaSol
        Me.FechaIni = fechaIni
        Me.FechaFin = fechaFin
        Me.dias = dias
    End Sub

    Public Sub New(vacacionId As Integer, empleadoId As Integer, fechaSol As Date, fechaIni As Date, fechaFin As Date, dias As Long)
        Me.VacacionId = vacacionId
        Me.EmpleadoId = empleadoId
        Me.FechaSol = fechaSol
        Me.FechaIni = fechaIni
        Me.FechaFin = fechaFin
        Me.dias = dias
    End Sub
End Class
