Public Class FMMenuPrincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        FMClientes.ShowDialog()
    End Sub

    Private Sub Btnproductos_Click(sender As Object, e As EventArgs) Handles Btnproductos.Click
        FMProduct.ShowDialog()
    End Sub

    Private Sub Btnventas_Click(sender As Object, e As EventArgs) Handles Btnventas.Click
        FMVentas.ShowDialog()
    End Sub

    Private Sub Btnreportes_Click(sender As Object, e As EventArgs) Handles Btnreportes.Click
        FMReportes.ShowDialog()
    End Sub
End Class