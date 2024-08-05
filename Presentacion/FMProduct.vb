Imports System.Data.SqlClient
Public Class FMProduct
    Private listaProducto As List(Of Product)

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Close()
    End Sub

    Private Sub FMProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lista As List(Of Product) = New List(Of Product)
        cboFiltro.Text = "Nombre"
        txtbuscar.Text = texto
        txtbuscar.ForeColor = Color.Black
        Try
            Dim funcion As New ProductoNegocio()
            listaProducto = funcion.ListaProduct()
            dgvProduct.DataSource = lista
            mostrarProducto()
            dgvProduct.Columns(1).Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Const texto As String = "Buscar Cliente..."


    Private Sub btnAltaLogica_Click(sender As Object, e As EventArgs) Handles btnAltaLogica.Click
        dgvProduct.Visible = False
        panelAltaProduct.Visible = True
        btnGuardarCambios.Visible = False
        btnAceptar.Visible = True
    End Sub
    Private Sub mostrarProducto()
        Dim funcion As New ProductoNegocio
        Dim estilo As New Funciones
        Dim dt As New DataTable
        listaProducto = funcion.ListaProduct()
        funcion.MostrarProductos(dt)
        estilo.Multilinea(dgvProduct)
        dgvProduct.Columns(1).Visible = False
        dgvProduct.DataSource = dt
    End Sub
    Private Sub Limpiar()
        txtnombre.Clear()
        txtcategoria.Clear()
        txtprecio.Clear()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If String.IsNullOrWhiteSpace(txtnombre.Text) Then
            MessageBox.Show("Por favor, ingrese el nombre del Producto.")
            txtnombre.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtprecio.Text) Then
            MessageBox.Show("Por favor, ingrese el Precio del Producto.")
            txtprecio.Focus()
            Exit Sub
        End If

        Dim precio As Decimal
        If Not Decimal.TryParse(txtprecio.Text, precio) Then
            MessageBox.Show("Por favor, ingrese un precio válido.")
            txtprecio.Focus()
            Exit Sub
        End If

        If precio <= 0 Then
            MessageBox.Show("El precio debe ser mayor a 0.")
            txtprecio.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtcategoria.Text) Then
            MessageBox.Show("Por favor, ingrese la categoria del Producto.")
            txtcategoria.Focus()
            Exit Sub
        End If


        Dim parametros As New Product()
        Dim funcion As New ProductoNegocio()
        parametros._Nombre = txtnombre.Text
        parametros._Precio = txtprecio.Text
        parametros._Categoria = txtcategoria.Text

        If (funcion.AltaProducto(parametros) = True) Then
            MessageBox.Show("Producto guardado con éxito.")
            mostrarProducto()
            Limpiar()
            panelAltaProduct.Visible = False
            dgvProduct.Visible = True
        Else
            MessageBox.Show("Error al guardar el Producto.")
        End If
    End Sub

    Private Sub dgvProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellContentClick

    End Sub

    Private Sub dgvProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellClick
        If e.ColumnIndex = Me.dgvProduct.Columns.Item("Eli").Index Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Realmente desea eliminar este Producto?", "Eliminando Producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    Dim cmd As New SqlCommand
                    abrirConexion()
                    cmd = New SqlCommand("DELETE FROM productos WHERE ID = @IdProducto", conexion)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.AddWithValue("@IdProducto", dgvProduct.SelectedCells.Item(1).Value)

                    cmd.ExecuteNonQuery()
                    CerrarConexion()
                    mostrarProducto()


                Catch ex As Exception : MsgBox(ex.Message)

                End Try
            Else
                MessageBox.Show("Cancelando eliminación de Producto", "Eliminando Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If
    End Sub

    Private Sub dgvProduct_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellDoubleClick
        Try
            panelAltaProduct.Visible = True
            btnGuardarCambios.Visible = True
            dgvProduct.Visible = False
            btnAceptar.Visible = False
            txtnombre.Text = dgvProduct.SelectedCells.Item(2).Value
            txtprecio.Text = dgvProduct.SelectedCells.Item(3).Value
            txtcategoria.Text = dgvProduct.SelectedCells.Item(4).Value
            LblidProducto.Text = dgvProduct.SelectedCells.Item(1).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        panelAltaProduct.Visible = False
        dgvProduct.Visible = True
    End Sub

    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        If String.IsNullOrWhiteSpace(txtnombre.Text) Then
            MessageBox.Show("Por favor, ingrese el nombre del Producto.")
            txtnombre.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtprecio.Text) Then
            MessageBox.Show("Por favor, ingrese el Precio del Producto.")
            txtprecio.Focus()
            Exit Sub
        End If

        Dim precio As Decimal
        If Not Decimal.TryParse(txtprecio.Text, precio) Then
            MessageBox.Show("Por favor, ingrese un precio válido.")
            txtprecio.Focus()
            Exit Sub
        End If

        If precio <= 0 Then
            MessageBox.Show("El precio debe ser mayor a 0.")
            txtprecio.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtcategoria.Text) Then
            MessageBox.Show("Por favor, ingrese la categoria del Producto.")
            txtcategoria.Focus()
            Exit Sub
        End If
        Dim parametros As New Product()
        Dim funcion As New ProductoNegocio()
        parametros._Id = LblidProducto.Text
        parametros._Nombre = txtnombre.Text
        parametros._Precio = txtprecio.Text
        parametros._Categoria = txtcategoria.Text
        If (funcion.ModificarProducto(parametros) = True) Then
            MessageBox.Show("Producto Modificado con éxito.")
            mostrarProducto()
            Limpiar()
            panelAltaProduct.Visible = False
            dgvProduct.Visible = True
        Else
            MessageBox.Show("Error al Modificar el Producto.")
        End If
    End Sub

    Private Sub txtbuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Dim estilo As New Funciones
        If txtbuscar.Text <> "" And txtbuscar.Text <> texto Then
            Dim filtro As String = txtbuscar.Text.ToLower()
            Dim filtrada As New List(Of Product)

            If filtro.Length() > 2 Then
                Select Case cboFiltro.Text
                    Case "Nombre"
                        filtrada = listaProducto.FindAll(Function(x) x._Nombre.ToLower().Contains(filtro.ToLower()))
                    Case "Categoria"
                        filtrada = listaProducto.FindAll(Function(x) x._Categoria.ToLower().Contains(filtro.ToLower()))
                    Case "Precio"
                        'Dim precioFiltro As Decimal
                        If IsNumeric(filtro) Then
                            filtrada = listaProducto.FindAll(Function(x) x._Precio.ToString("F2").StartsWith(filtro))
                        Else
                            MessageBox.Show("Por favor, ingrese un valor de precio válido")
                            filtrada = New List(Of Product)
                        End If
                    Case Else
                        filtrada = listaProducto
                End Select
            Else
                filtrada = listaProducto
            End If

            dgvProduct.DataSource = Nothing
            dgvProduct.DataSource = filtrada
            dgvProduct.Columns(1).Visible = False
        End If
    End Sub

    Private Sub cboFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltro.SelectedIndexChanged

    End Sub

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
End Class