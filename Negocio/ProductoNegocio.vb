Imports System.Data.SqlClient
Public Class ProductoNegocio
    Public Function ListaProduct() As List(Of Product)
        Dim lista As New List(Of Product)
        Dim cmd As New SqlCommand
        Try
            abrirConexion()
            cmd = New SqlCommand("select ID,Nombre,Precio,Categoria from productos", conexion)
            cmd.CommandType = CommandType.Text

            Using datos As SqlDataReader = cmd.ExecuteReader()
                While datos.Read()
                    Dim Prod As New Product()
                    Prod._Id = Convert.ToInt32(datos("ID"))
                    Prod._Nombre = datos("Nombre").ToString()
                    Prod._Precio = datos("Precio").ToString()
                    Prod._Categoria = datos("Categoria").ToString()

                    lista.Add(Prod)
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
    Public Function AltaProducto(ByRef parametros As Product) As Boolean
        Try
            abrirConexion()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("Insert into productos(Nombre,Precio,Categoria) values (@nombre,@precio,@categoria)", conexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@nombre", parametros._Nombre)
            cmd.Parameters.AddWithValue("@precio", parametros._Precio)
            cmd.Parameters.AddWithValue("@categoria", parametros._Categoria)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            CerrarConexion()
        End Try
    End Function
    Public Function MostrarProductos(ByRef dt As DataTable) As DataTable
        Try
            abrirConexion()
            Dim da As New SqlDataAdapter("Select * FROM productos", conexion)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            CerrarConexion()
        End Try
    End Function

    Public Function ModificarProducto(ByRef parametros As Product) As Boolean
        Try
            abrirConexion()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("UPDATE productos SET Nombre = @nombre, Precio = @precio, Categoria = @categoria WHERE ID = @productId", conexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@productId", parametros._Id)
            cmd.Parameters.AddWithValue("@nombre", parametros._Nombre)
            cmd.Parameters.AddWithValue("@precio", parametros._Precio)
            cmd.Parameters.AddWithValue("@categoria", parametros._Categoria)
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
