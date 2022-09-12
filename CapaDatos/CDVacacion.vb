Imports System.Data.SqlClient
Imports CapaEntidad

Public Class CDVacacion
    Inherits CDConexion
    Function ObtenerVacaciones(EmpleadoId As Integer) As DataTable
        Try
            Using cn = GetConection()
                cn.Open()
                Using da = New SqlDataAdapter("VP_ObtenerVacaciones", cn)
                    With da.SelectCommand
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@P_EMPID", SqlDbType.Int).Value = EmpleadoId
                    End With
                    Dim reader = da.SelectCommand.ExecuteReader()
                    Using table = New DataTable
                        table.Load(reader)
                        reader.Dispose()
                        Return table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Function EditarVacacion(vacacion As CEVacacion) As Boolean
        Try
            Using cn = GetConection()
                cn.Open()
                Using da = New SqlDataAdapter("VP_EditarVacacion", cn)
                    With da.SelectCommand
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@P_VACACIONID", SqlDbType.Int).Value = vacacion.VacacionId
                        .Parameters.Add("@P_EMPID", SqlDbType.Int).Value = vacacion.EmpleadoId
                        .Parameters.Add("@P_FECHA", SqlDbType.Date).Value = vacacion.FechaSol
                        .Parameters.Add("@P_FECHAINI", SqlDbType.Date).Value = vacacion.FechaIni
                        .Parameters.Add("@P_FECHAFIN", SqlDbType.Date).Value = vacacion.FechaFin
                        .Parameters.Add("@P_DIAS", SqlDbType.Decimal).Value = vacacion.dias
                    End With
                    da.SelectCommand.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function CrearVacacion(vacacion As CEVacacion) As Boolean
        Try
            Using cn = GetConection()
                cn.Open()
                Using da = New SqlDataAdapter("VP_CrearVacacion", cn)
                    With da.SelectCommand
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@P_EMPID", SqlDbType.Int).Value = vacacion.EmpleadoId
                        .Parameters.Add("@P_FECHA", SqlDbType.Date).Value = vacacion.FechaSol
                        .Parameters.Add("@P_FECHAINI", SqlDbType.Date).Value = vacacion.FechaIni
                        .Parameters.Add("@P_FECHAFIN", SqlDbType.Date).Value = vacacion.FechaFin
                        .Parameters.Add("@P_DIAS", SqlDbType.Decimal).Value = vacacion.dias
                    End With
                    da.SelectCommand.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function EliminarVacacion(VacacionId As Integer) As Boolean
        Try
            Using cn = GetConection()
                cn.Open()
                Using da = New SqlDataAdapter("VP_EliminarVacacion", cn)
                    With da.SelectCommand
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@P_VACACIONID", SqlDbType.Int).Value = VacacionId
                    End With
                    da.SelectCommand.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
