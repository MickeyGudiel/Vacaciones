Public Class CETipoIdentificacion
    Public Property TipoIdentId As Integer
    Public Property Tipo As String

    Public Sub New(tipoIdentId As Integer, tipo As String)
        If tipo Is Nothing Then
            Throw New ArgumentNullException(NameOf(tipo))
        End If

        Me.TipoIdentId = tipoIdentId
        Me.Tipo = tipo
    End Sub

    Public Sub New(tipo As String)
        If tipo Is Nothing Then
            Throw New ArgumentNullException(NameOf(tipo))
        End If

        Me.Tipo = tipo
    End Sub
End Class
