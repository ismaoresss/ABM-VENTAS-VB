Imports System.Data.SqlClient
Public Class VentasNegocio
    Public Function ListaVentas() As List(Of Ventas)
        Dim lista As New List(Of Ventas)
        Dim cmd As New SqlCommand
        Try
            abrirConexion()
            cmd = New SqlCommand("select ID, IDCliente, Fecha, Total from ventas", conexion)
            cmd.CommandType = CommandType.Text

            Using datos As SqlDataReader = cmd.ExecuteReader()
                While datos.Read()
                    Dim Vent As New Ventas()
                    Vent._Id = Convert.ToInt32(datos("ID"))
                    Vent._IdCliente = Convert.ToInt32(datos("IDCliente"))
                    Vent._Cliente._Id = Convert.ToInt32(datos("IDCliente"))
                    Vent._Fecha = Convert.ToDateTime(datos("Fecha"))
                    Vent._Total = Convert.ToDouble(datos("Total"))

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
    Public Function AltaVenta(ByRef parametros As Ventas) As Boolean
        Try
            abrirConexion()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("insert Ventas (IdCliente, Fecha, Total) VALUES (@idcliente, @fecha, @total)", conexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@idcliente", parametros._Cliente._Id)
            cmd.Parameters.AddWithValue("@fecha", parametros._Fecha)
            cmd.Parameters.AddWithValue("@total", parametros._Total)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            CerrarConexion()
        End Try
    End Function
    Public Function MostrarVentas(ByRef dt As DataTable) As DataTable
        Try
            abrirConexion()
            Dim da As New SqlDataAdapter("Select * FROM Ventas", conexion)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            CerrarConexion()
        End Try
    End Function

    Public Function ModificarVenta(ByRef parametros As Ventas) As Boolean
        Try
            abrirConexion()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("update Ventas set IdCliente = @idCliente, Fecha = @fecha, Total = @total where ID = @id", conexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@idCliente", parametros._Cliente._Id)
            cmd.Parameters.AddWithValue("@fecha", parametros._Fecha)
            cmd.Parameters.AddWithValue("@total", parametros._Total)
            cmd.Parameters.AddWithValue("@id", parametros._Id)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            CerrarConexion()
        End Try
    End Function
    Public Function DevolverId() As Integer
        Dim Id As Integer
        Try
            abrirConexion()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("SELECT TOP 1 ID FROM Ventas ORDER BY ID DESC", conexion)
            cmd.CommandType = CommandType.Text

            Using datos As SqlDataReader = cmd.ExecuteReader()
                While datos.Read()
                    Id = Convert.ToInt32(datos("ID"))
                End While
                Return Id
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            CerrarConexion()
        End Try
    End Function
End Class
