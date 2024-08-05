Public Class FMReportes

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim FuntReport As New ReporteNegocio
        Dim estilo As New Funciones
        Dim dt As DataTable = FuntReport.ObternerProductVendidoMensual()

        dgvProduc.DataSource = dt
        estilo.Multilinea(dgvProduc)
    End Sub

    Private Sub Btnvolver_Click(sender As Object, e As EventArgs) Handles Btnvolver.Click
        Close()
    End Sub
End Class