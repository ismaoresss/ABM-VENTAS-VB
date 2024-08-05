Imports System.Data.SqlClient
Public Class ClienteNegocio

    Public Function ListaCliente() As List(Of Cliente)
        Dim lista As New List(Of Cliente)
        Dim cmd As New SqlCommand
        Try
            abrirConexion()
            cmd = New SqlCommand("select ID, Cliente, Telefono, Correo from clientes", conexion)
            cmd.CommandType = CommandType.Text

            Using datos As SqlDataReader = cmd.ExecuteReader()
                While datos.Read()
                    Dim clien As New Cliente()
                    clien.Id = Convert.ToInt32(datos("ID"))
                    clien.Cliente = datos("Cliente").ToString()
                    clien.Telefono = datos("Telefono").ToString()
                    clien.Correo = datos("Correo").ToString()

                    lista.Add(clien)
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
    Public Function AltaCliente(ByRef parametros As Cliente) As Boolean
        Try
            abrirConexion()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("Insert into clientes(Cliente,Telefono,Correo) values (@cliente,@telefono,@correo)", conexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@cliente", parametros._Cliente)
            cmd.Parameters.AddWithValue("@telefono", parametros._Telefono)
            cmd.Parameters.AddWithValue("@correo", parametros._Correo)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            CerrarConexion()
        End Try
    End Function
    Public Function MostrarUsuarios(ByRef dt As DataTable) As DataTable
        Try
            abrirConexion()
            Dim da As New SqlDataAdapter("Select * FROM clientes", conexion)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            CerrarConexion()
        End Try
    End Function

    Public Function ModificarCliente(ByRef parametros As Cliente) As Boolean
        Try
            abrirConexion()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("UPDATE clientes SET Cliente = @cliente, Telefono = @telefono, Correo = @correo WHERE ID = @clienteId", conexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@clienteId", parametros._Id)
            cmd.Parameters.AddWithValue("@cliente", parametros._Cliente)
            cmd.Parameters.AddWithValue("@telefono", parametros._Telefono)
            cmd.Parameters.AddWithValue("@correo", parametros._Correo)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            CerrarConexion()
        End Try
    End Function

    Public Function ExisteCliente(ByVal idCliente As Integer) As Boolean
        Try
            abrirConexion()
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM Clientes WHERE ID = @id", conexion)
            cmd.CommandType = CommandType.Text

            cmd.Parameters.AddWithValue("@id", idCliente)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            CerrarConexion()
        End Try
    End Function

End Class


