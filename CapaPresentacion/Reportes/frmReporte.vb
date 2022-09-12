Public Class frmReporte
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.VP_ObtenerVacacionesConEmpleados' Puede moverla o quitarla según sea necesario.
        Me.VP_ObtenerVacacionesConEmpleadosTableAdapter.Fill(Me.DataSet1.VP_ObtenerVacacionesConEmpleados)

        Me.ReportViewer1.RefreshReport()
    End Sub

   
End Class