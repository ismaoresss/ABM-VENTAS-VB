Imports System.Configuration
Imports System.Data.SqlClient
Module AccesoDatos
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
    Public conexion As New SqlConnection(connectionString)

    Public Sub abrirConexion()
        If conexion.State = 0 Then
            conexion.Open()
        End If
    End Sub
    Sub CerrarConexion()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub

End Module

