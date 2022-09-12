Imports Microsoft.Reporting.WinForms
Imports CapaNegocio

Public Class frmReporteCalculoAction
    ReadOnly utils As New Utils
    Private Sub btnGenerarCalculo_Click(sender As Object, e As EventArgs) Handles btnGenerarCalculo.Click
        Dim frm = New frmRVacacionesCalc()

        Dim rptds As ReportDataSource
        Dim dt As DataTable

        Dim FechaIni As Date = utils.ParsearFecha(dtpFechaIni.Value)
        Dim FechaCorte As Date = utils.ParsearFecha(dtpFechaFin.Value)

        Dim objCNVacaciones As New CNVacaciones

        With frm
            dt = objCNVacaciones.ObtenerCalculoDeVacaciones(FechaIni, FechaCorte)
            rptds = New ReportDataSource("DataSet1", dt)
            .ReportViewer1.LocalReport.DataSources.Add(rptds)
            'rptds = Nothing
            .Show()
        End With

    End Sub
End Class