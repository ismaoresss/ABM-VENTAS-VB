Imports System.Data.SqlClient
Public Class ReporteNegocio
    Public Function ObternerProductVendidoMensual() As DataTable
        Dim dt As New DataTable
        Try
            abrirConexion()
            Dim cmd As New SqlCommand("select P.Nombre as Producto,MONTH(v.Fecha) as Mes,SUM(vi.Cantidad) as 'Cantidad Total' from Ventas v
                                        inner join ventasitems vi on vi.IDVenta = v.ID
                                        inner join productos p on p.ID = vi.IDProducto
                                        group by p.Nombre,MONTH(v.Fecha)
                                        ORDER BY 
                                        p.Nombre, MONTH(v.Fecha)", conexion)
            cmd.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CerrarConexion()
        End Try
        Return dt
    End Function
End Class
