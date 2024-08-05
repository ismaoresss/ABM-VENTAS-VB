Imports System.Data.SqlClient
Public Class ItemVentasNegocio
    Public Function ListaItems() As List(Of VentasItems)
        Dim lista As New List(Of VentasItems)
        Dim cmd As New SqlCommand
        Try
            abrirConexion()
            cmd = New SqlCommand("select ID, IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal from ventasitems", conexion)
            cmd.CommandType = CommandType.Text

            Using datos As SqlDataReader = cmd.ExecuteReader()
                While datos.Read()
                    Dim Vent As New VentasItems()
                    Vent._Ventas = New Ventas
                    Vent._Producto = New Product
                    Vent._Id = Convert.ToInt32(datos("ID"))
                    Vent._Ventas._Id = Convert.ToInt32(datos("IDVenta"))
                    Vent._Producto._Id = Convert.ToInt32(datos("IDProducto"))
                    Vent._PrecioUnitario = Convert.ToDouble(datos("PrecioUnitario"))
                    Vent._Cantidad = Convert.ToInt32(datos("Cantidad"))
                    Vent._PrecioTotal = Convert.ToDouble(datos("PrecioTotal"))

                    lista.Add(Vent)
                End While
            End Using
            Return lista
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Return Nothing
        Finally
            CerrarConexion()
        End Try
    End Function

    Public Function AgregarItem(ByRef parametros As VentasItems) As Boolean
        Try
            abrirConexion()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("Insert ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@idventa, @idproducto, @preciouni, @cantidad, @preciototal)", conexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@idventa", parametros._Ventas._Id)
            cmd.Parameters.AddWithValue("@idproducto", parametros._Producto._Id)
            cmd.Parameters.AddWithValue("@preciouni", parametros._PrecioUnitario)
            cmd.Parameters.AddWithValue("@cantidad", parametros._Cantidad)
            cmd.Parameters.AddWithValue("@preciototal", parametros._PrecioTotal)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            CerrarConexion()
        End Try
    End Function
End Class
