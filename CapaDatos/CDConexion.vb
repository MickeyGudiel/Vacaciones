Imports System.Configuration
Imports System.Data.SqlClient

Public MustInherit Class CDConexion
    ReadOnly strConexion As String

    Public Sub New()
        strConexion = ConfigurationManager.ConnectionStrings("CapaPresentacion.My.MySettings.bd").ToString
    End Sub
    Protected Function GetConection() As SqlConnection
        Return New SqlConnection(strConexion)
    End Function
End Class
