Imports System.Data.SqlClient
Public Class FMClientes
    Private listaClient As List(Of Cliente)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Close()
    End Sub

    Private Sub btnAltaLogica_Click(sender As Object, e As EventArgs) Handles btnAltaLogica.Click
        dgvclientes.Visible = False
        panelAltaCliente.Visible = True
        btnGuardarCambios.Visible = False
        btnAceptar.Visible = True
    End Sub

    Private Sub mostrarUsuarios()
        Dim funcion As New ClienteNegocio
        Dim estilo As New Funciones
        Dim dt As New DataTable
        listaClient = funcion.ListaCliente()
        funcion.MostrarUsuarios(dt)
        estilo.Multilinea(dgvclientes)
        dgvclientes.DataSource = dt
    End Sub
    Private Sub Limpiar()
        txtCliente.Clear()
        txtcorreo.Clear()
        txttelefono.Clear()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If String.IsNullOrWhiteSpace(txtCliente.Text) Then
            MessageBox.Show("Por favor, ingrese el nombre del cliente.")
            txtCliente.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txttelefono.Text) Then
            MessageBox.Show("Por favor, ingrese el Telefono del cliente.")
            txttelefono.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txttelefono.Text) Then
            MessageBox.Show("Por favor, ingrese un número de teléfono válido.")
            txttelefono.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtcorreo.Text) Then
            MessageBox.Show("Por favor, ingrese el Correo del cliente.")
            txtcorreo.Focus()
            Exit Sub
        End If


        Dim parametros As New Cliente()
        Dim funcion As New ClienteNegocio()
        parametros._Cliente = txtCliente.Text
        parametros._Telefono = txttelefono.Text
        parametros._Correo = txtcorreo.Text
        If (funcion.AltaCliente(parametros) = True) Then
            MessageBox.Show("Cliente guardado con éxito.")
            mostrarUsuarios()
            Limpiar()
            panelAltaCliente.Visible = False
            dgvclientes.Visible = True
        Else
            MessageBox.Show("Error al guardar el cliente.")
        End If
    End Sub

    Private Sub dgvclientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclientes.CellContentClick

    End Sub

    Private Sub FMClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lista As List(Of Cliente) = New List(Of Cliente)
        cboFiltro.Text = "Cliente"
        txtbuscar.Text = texto
        txtbuscar.ForeColor = Color.Black
        Try
            Dim funcion As New ClienteNegocio()
            listaClient = funcion.ListaCliente()
            dgvclientes.DataSource = lista
            mostrarUsuarios()
            'dgvclientes.Columns(1).Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub


    Private Sub dgvclientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclientes.CellClick
        If e.ColumnIndex = Me.dgvclientes.Columns.Item("Eli").Index Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Realmente desea eliminar este Cliente?", "Eliminando Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    Dim cmd As New SqlCommand
                    abrirConexion()
                    cmd = New SqlCommand("DELETE FROM clientes WHERE ID = @IdCliente", conexion)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.AddWithValue("@IdCliente", dgvclientes.SelectedCells.Item(1).Value)

                    cmd.ExecuteNonQuery()
                    CerrarConexion()
                    mostrarUsuarios()


                Catch ex As Exception : MsgBox(ex.Message)

                End Try
            Else
                MessageBox.Show("Cancelando eliminación de Cliente", "Eliminando Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If
    End Sub

    Private Sub dgvclientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclientes.CellDoubleClick
        Try
            panelAltaCliente.Visible = True
            btnGuardarCambios.Visible = True
            dgvclientes.Visible = False
            btnAceptar.Visible = False
            txtCliente.Text = dgvclientes.SelectedCells.Item(2).Value
            txttelefono.Text = dgvclientes.SelectedCells.Item(3).Value
            txtcorreo.Text = dgvclientes.SelectedCells.Item(4).Value
            Lblidcliente.Text = dgvclientes.SelectedCells.Item(1).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        panelAltaCliente.Visible = False
        dgvclientes.Visible = True
    End Sub

    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        If String.IsNullOrWhiteSpace(txtCliente.Text) Then
            MessageBox.Show("Por favor, ingrese el nombre del cliente.")
            txtCliente.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txttelefono.Text) Then
            MessageBox.Show("Por favor, ingrese el Telefono del cliente.")
            txttelefono.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txttelefono.Text) Then
            MessageBox.Show("Por favor, ingrese un número de teléfono válido.")
            txttelefono.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtcorreo.Text) Then
            MessageBox.Show("Por favor, ingrese el Correo del cliente.")
            txtcorreo.Focus()
            Exit Sub
        End If

        Dim parametros As New Cliente()
        Dim funcion As New ClienteNegocio()
        parametros._Id = Lblidcliente.Text
        parametros._Cliente = txtCliente.Text
        parametros._Telefono = txttelefono.Text
        parametros._Correo = txtcorreo.Text
        If (funcion.ModificarCliente(parametros) = True) Then
            MessageBox.Show("Cliente Modificado con éxito.")
            mostrarUsuarios()
            Limpiar()
            panelAltaCliente.Visible = False
            dgvclientes.Visible = True
        Else
            MessageBox.Show("Error al Modificar el cliente.")
        End If
    End Sub

    Private Sub cbCampo_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblTituloCliente_Click(sender As Object, e As EventArgs) Handles LblTituloCliente.Click

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        Dim funcion As New ClienteNegocio
        dgvclientes.DataSource = funcion.ListaCliente()
        mostrarUsuarios()
    End Sub

    Private Const texto As String = "Buscar Cliente..."
    Private Sub txtbuscar_GotFocus(sender As Object, e As EventArgs) Handles txtbuscar.GotFocus
        If txtbuscar.Text = texto Then
            txtbuscar.Text = ""
            txtbuscar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtbuscar_LostFocus(sender As Object, e As EventArgs) Handles txtbuscar.LostFocus
        If String.IsNullOrWhiteSpace(txtbuscar.Text) Then
            txtbuscar.Text = texto
            txtbuscar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Dim estilo As New Funciones
        If txtbuscar.Text <> "" And txtbuscar.Text <> texto Then
            Dim filtro As String = txtbuscar.Text.ToLower()
            Dim filtrada As New List(Of Cliente)

            If filtro.Length() > 2 Then
                If cboFiltro.Text = "Cliente" Then
                    filtrada = listaClient.FindAll(Function(x) x.Cliente.ToLower().Contains(filtro.ToLower()))

                ElseIf cboFiltro.Text = "Telefono" Then
                    filtrada = listaClient.FindAll(Function(x) x.Telefono.ToLower().Contains(filtro.ToLower()))

                Else
                    filtrada = listaClient.FindAll(Function(x) x.Correo.ToLower().Contains(filtro.ToLower()))
                End If

            Else
                filtrada = listaClient
            End If

            dgvclientes.DataSource = Nothing
            dgvclientes.DataSource = filtrada
            dgvclientes.Columns(1).Visible = False
        End If
    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub cboFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltro.SelectedIndexChanged

    End Sub
End Class
