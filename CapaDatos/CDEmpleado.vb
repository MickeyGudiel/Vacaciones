Imports System.Data.SqlClient
Imports CapaEntidad

Public Class CDEmpleado

    Inherits CDConexion
    Function ObtenerEmpleados() As DataSet
        Try
            Using cn = GetConection()
                cn.Open()
                Using da = New SqlDataAdapter("VP_ObtenerEmpleados", cn)
                    Dim ds As New DataSet
                    da.Fill(ds, "Empleados")
                    Return ds
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Function ObtenerTipoIdents() As DataSet
        Try
            Using cn = GetConection()
                cn.Open()
                Using da = New SqlDataAdapter("VP_ObtenerTipoIdents", cn)
                    Dim ds As New DataSet
                    da.Fill(ds, "TipoIdentificacion")
                    Return ds
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Function InsertarEmpleado(ByVal empleado As CEEmpleado) As Boolean
        Try
            Using cn = GetConection()
                cn.Open()
                Using da = New SqlDataAdapter("VP_InsertarEmpleado", cn)
                    With da.SelectCommand
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@P_EMPNOM", SqlDbType.VarChar).Value = empleado.EmpNombre
                        .Parameters.Add("@P_TIDENT", SqlDbType.VarChar).Value = empleado.TipoIdent.TipoIdentId
                        .Parameters.Add("@P_EMPIDENT", SqlDbType.VarChar).Value = empleado.EmpIdentificacion
                        .Parameters.Add("@P_EMPFINGRESO", SqlDbType.Date).Value = empleado.EmpFechaIngreso
                        .Parameters.Add("@P_EMPSALBASEMEN", SqlDbType.Decimal).Value = empleado.EmpSalBase
                        .Parameters.Add("@P_EMPDIR", SqlDbType.VarChar).Value = empleado.EmpDireccion
                    End With
                    da.SelectCommand.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function EditarEmpleado(ByVal empleado As CEEmpleado) As Boolean
        Try
            Using cn = GetConection()
                cn.Open()
                Using da = New SqlDataAdapter("VP_EditarEmpleado", cn)
                    With da.SelectCommand
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@P_EMPID", SqlDbType.Int).Value = empleado.EmpleadoId
                        .Parameters.Add("@P_EMPNOM", SqlDbType.VarChar).Value = empleado.EmpNombre
                        .Parameters.Add("@P_TIDENT", SqlDbType.VarChar).Value = empleado.TipoIdent.TipoIdentId
                        .Parameters.Add("@P_EMPIDENT", SqlDbType.VarChar).Value = empleado.EmpIdentificacion
                        .Parameters.Add("@P_EMPFINGRESO", SqlDbType.Date).Value = empleado.EmpFechaIngreso
                        .Parameters.Add("@P_EMPSALBASEMEN", SqlDbType.Decimal).Value = empleado.EmpSalBase
                        .Parameters.Add("@P_EMPDIR", SqlDbType.VarChar).Value = empleado.EmpDireccion
                    End With
                    da.SelectCommand.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function EliminarEmpleado(EmpleadoId As Integer) As Boolean
        Try
            Using cn = GetConection()
                cn.Open()
                Using da = New SqlDataAdapter("VP_EliminarEmpleado", cn)
                    With da.SelectCommand
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@P_EMPID", SqlDbType.Int).Value = EmpleadoId
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
