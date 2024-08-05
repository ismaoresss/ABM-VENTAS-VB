Imports System.Data.SqlClient
Public Class FMVentas
    Private listaventa As List(Of Ventas)
    Private listaProducto As List(Of Product)
    Private listaItems As New List(Of VentasItems)
    Private identificador As Integer
    Private totalVenta As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btnvolver.Click
        Close()
    End Sub

    Private Sub FMVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lista As List(Of Ventas) = New List(Of Ventas)

        Try

            'cboFiltro.Text = "IdCliente"
            txtbuscar.Text = texto
            txtbuscar.ForeColor = Color.Black
            Dim FuntVentas As New VentasNegocio
            listaventa = FuntVentas.ListaVentas()
            lista = FuntVentas.ListaVentas()
            mostrarventa()
            dgvVentas.Columns(1).Visible = False

            Dim producto As New Product
            Dim funtProd As New ProductoNegocio
            Dim estilo As New Funciones

            dgvproductos.DataSource = funtProd.ListaProduct()
            dgvproductos.Columns("_ID").Visible = False


            estilo.Multilinea(dgvproductos)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub mostrarventa()
        Dim funcion As New VentasNegocio
        Dim estilo As New Funciones
        Dim dt As New DataTable
        listaventa = funcion.ListaVentas()
        funcion.MostrarVentas(dt)
        estilo.Multilinea(dgvVentas)
        dgvVentas.DataSource = dt

    End Sub
    Private Sub mostrarProducto()
        Dim funcion As New ProductoNegocio
        Dim estilo As New Funciones
        Dim dt As New DataTable
        listaProducto = funcion.ListaProduct()
        funcion.MostrarProductos(dt)
        dgvproductos.Columns("_Id").Visible = False
        estilo.Multilinea(dgvproductos)
        dgvVentas.DataSource = dt
    End Sub


    Private Sub dgvProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellContentClick

    End Sub

    Private Sub dgvProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellClick
        If e.ColumnIndex = Me.dgvVentas.Columns.Item("Eli").Index Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Realmente desea eliminar esta venta?", "Eliminando venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    Dim cmd As New SqlCommand
                    abrirConexion()
                    cmd = New SqlCommand("DELETE FROM ventas WHERE ID = @Idventas", conexion)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.AddWithValue("@Idventas", dgvVentas.SelectedCells.Item(1).Value)

                    cmd.ExecuteNonQuery()
                    CerrarConexion()
                    mostrarventa()


                Catch ex As Exception : MsgBox(ex.Message)

                End Try
            Else
                MessageBox.Show("Cancelando eliminación de ventas", "Eliminando venta", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If
    End Sub

    Private Sub btnAltaLogica_Click(sender As Object, e As EventArgs) Handles btnAltaLogica.Click
        panelAltaventa.Visible = True
        Panelbuscador.Visible = False
        dgvVentas.Visible = False
        btnAltaLogica.Visible = False
        Btnvolver.Visible = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        panelAltaventa.Visible = False
        dgvVentas.Visible = True
        Panelbuscador.Visible = True
        btnAltaLogica.Visible = True
        Btnvolver.Visible = True
    End Sub
    Private Sub CalcularTotal()
        Dim Total As Double = listaItems.Sum(Function(item) item._PrecioTotal)
        txtTotal.Text = Total.ToString("C2")
        totalVenta = Total.ToString("C2")
    End Sub
    Private Sub CargaDgvAgregarVentas(lista As List(Of VentasItems))
        Dim estilo As New Funciones
        CalcularTotal()
        dgvVentasAgregadas.DataSource = Nothing
        dgvVentasAgregadas.DataSource = lista

        dgvVentasAgregadas.Columns(0).Visible = False
        dgvVentasAgregadas.Columns(1).Visible = False
        dgvVentasAgregadas.Columns(2).Visible = False

        estilo.Multilinea(dgvVentasAgregadas)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim item As New VentasItems
        Dim Producto As Product
        If listaItems Is Nothing Then
            listaItems = New List(Of VentasItems)
        End If

        If dgvproductos.CurrentRow IsNot Nothing Then
            Producto = dgvproductos.CurrentRow.DataBoundItem
            item._Producto._Nombre = Producto._Nombre
            item._NombreProducto = Producto._Nombre
            item._Producto._Id = Producto._Id
            item._PrecioUnitario = Producto._Precio
            item._Cantidad = 1
            item._PrecioTotal = Producto._Precio
            item._PrecioTotal = Producto._Precio

            Dim ItemExistente As VentasItems = listaItems.FirstOrDefault(Function(i) i._Producto._Id = item._Producto._Id)
            If ItemExistente IsNot Nothing Then
                ItemExistente._Cantidad += 1
                ItemExistente._PrecioTotal += Producto._Precio
            Else
                listaItems.Add(item)
            End If
            CargaDgvAgregarVentas(listaItems)
        Else
            MessageBox.Show("Por favor seleccione una fila", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnMayor_Click(sender As Object, e As EventArgs) Handles btnMayor.Click
        If dgvVentasAgregadas.CurrentRow IsNot Nothing Then
            Dim itemSelect As VentasItems = dgvVentasAgregadas.CurrentRow.DataBoundItem
            Dim itemExist As VentasItems = DirectCast(dgvVentasAgregadas.CurrentRow.DataBoundItem, VentasItems)
            itemExist._Cantidad += 1
            itemExist._PrecioTotal += itemSelect._PrecioUnitario
            CargaDgvAgregarVentas(listaItems)
        Else
            MessageBox.Show("Porfavor seleccione una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnMenor_Click(sender As Object, e As EventArgs) Handles btnMenor.Click
        If dgvVentasAgregadas.CurrentRow IsNot Nothing Then
            Dim ItemSelect As VentasItems = dgvVentasAgregadas.CurrentRow.DataBoundItem
            Dim listaFiltrada As New List(Of VentasItems)
            Dim Itemfiltrada As New VentasItems

            If ItemSelect._Cantidad > 1 Then
                Dim ItemExist As VentasItems = listaItems.FirstOrDefault(Function(i) i._Producto._Id = ItemSelect._Producto._Id)
                ItemExist._Cantidad -= 1
                ItemExist._PrecioTotal -= ItemSelect._PrecioUnitario
                CargaDgvAgregarVentas(listaItems)
            Else
                MessageBox.Show("No se puede tener un producto con cantidad menor a 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Else
            MessageBox.Show("Por favor seleccione una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvVentasAgregadas.CurrentRow IsNot Nothing Then
                Dim itemSelect As VentasItems = DirectCast(dgvVentasAgregadas.CurrentRow.DataBoundItem, VentasItems)
                listaItems.RemoveAll(Function(i) i._Producto._Id = itemSelect._Producto._Id)
                CargaDgvAgregarVentas(listaItems)
            Else
                MessageBox.Show("Por favor seleccione una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Dim b = True
        Dim b2 = False
        If String.IsNullOrEmpty(txtCliente.Text) Then
            MessageBox.Show("Por favor, complete el campo de Id Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            b = False
        End If
        Dim clien As New List(Of Cliente)
        Dim negocioC As New ClienteNegocio

        Dim negocioIV As New ItemVentasNegocio

        Dim idVenta As Integer
        If listaItems IsNot Nothing And listaItems.Count > 0 Then
            If b = True Then
                clien = negocioC.ListaCliente()
                For Each item As Cliente In clien
                    If item.Id = Convert.ToInt32(txtCliente.Text) Then
                        b2 = True
                    End If
                Next

                If b2 = True Then

                    Dim VentaNuevo As New Ventas
                    Dim negocioV As New VentasNegocio

                    VentaNuevo._Cliente._Id = Convert.ToInt32(txtCliente.Text)
                    VentaNuevo._Fecha = DateTime.Now
                    VentaNuevo._Total = totalVenta

                    negocioV.AltaVenta(VentaNuevo)
                    idVenta = negocioV.DevolverId()

                    For Each item As VentasItems In listaItems
                        item._Ventas._Id = idVenta
                        negocioIV.AgregarItem(item)
                    Next
                    MessageBox.Show("Agregado Exitosamente :)")
                    panelAltaventa.Visible = False
                    dgvVentas.Visible = True
                    Panelbuscador.Visible = True
                    btnAltaLogica.Visible = True
                    Btnvolver.Visible = True
                    mostrarventa()
                Else
                    MessageBox.Show("El IdCliente no existe en la base de datos..")
                End If
            End If
        Else
            MessageBox.Show("No hay ventas para cerrar..")
        End If
    End Sub

    Private Const texto As String = "Buscar Cliente..."

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Dim estilo As New Funciones
        Dim funciones As New VentasNegocio
        listaventa = funciones.ListaVentas
        If txtbuscar.Text <> "" AndAlso txtbuscar.Text <> texto Then
            Dim filtro As String = txtbuscar.Text.ToLower()
            Dim filtrada As New List(Of Ventas)

            If filtro.Length() >= 1 Then
                Select Case cboFiltro.Text
                    Case "IdCliente"
                        filtrada = listaventa.FindAll(Function(x) x._Cliente._Id.ToString().Contains(filtro.ToLower()))
                    Case "Año"
                        filtrada = listaventa.FindAll(Function(x) x._Fecha.ToString().Contains(filtro))
                    Case Else
                        filtrada = listaventa
                End Select
            Else
                filtrada = listaventa
            End If

            dgvVentas.DataSource = Nothing
            dgvVentas.DataSource = filtrada
            dgvVentas.Columns(1).Visible = False
            dgvVentas.Columns("_Cliente").Visible = False
        End If
    End Sub

    Private Sub txtbuscar_LostFocus(sender As Object, e As EventArgs) Handles txtbuscar.LostFocus
        If String.IsNullOrWhiteSpace(txtbuscar.Text) Then
            txtbuscar.Text = texto
            txtbuscar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtbuscar_GotFocus(sender As Object, e As EventArgs) Handles txtbuscar.GotFocus
        If txtbuscar.Text = texto Then
            txtbuscar.Text = ""
            txtbuscar.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Limpiar()
        txtNumCliente.Clear()
        txtfecha.Clear()
        txtTotal.Clear()
    End Sub

    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        If String.IsNullOrWhiteSpace(txtNumCliente.Text) Then
            MessageBox.Show("Por favor, ingrese un Numero de Cliente.")
            txtNumCliente.Focus()
            Exit Sub

        ElseIf Not IsNumeric(txtNumCliente.Text) Then
            MessageBox.Show("El Número de Cliente debe ser un valor numérico.")
            txtNumCliente.Focus()
            Exit Sub
        End If

        Dim funcionCliente As New ClienteNegocio()
        If Not funcionCliente.ExisteCliente(Convert.ToInt32(txtNumCliente.Text)) Then
            MessageBox.Show("El Número de Cliente no existe en la base de datos.")
            txtNumCliente.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtfecha.Text) Then
            MessageBox.Show("Por favor, ingrese una fecha.")
            txtfecha.Focus()
            Exit Sub
        ElseIf Not IsDate(txtfecha.Text) Then
            MessageBox.Show("La fecha ingresada no es válida.")
            txtfecha.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(txttotalModificar.Text) Then
            MessageBox.Show("Por favor, ingrese un total .")
            txttotalModificar.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txttotalModificar.Text) OrElse Convert.ToDouble(txttotalModificar.Text) <= 0 Then
            MessageBox.Show("El total debe ser un valor numérico positivo.")
            txttotalModificar.Focus()
            Exit Sub
        End If

        Dim parametros As New Ventas()
        Dim funcion As New VentasNegocio()
        parametros._Id = Convert.ToInt32(Lblidventa.Text)
        parametros._Cliente._Id = Convert.ToInt32(txtNumCliente.Text)
        parametros._Fecha = Convert.ToDateTime(txtfecha.Text)
        parametros._Total = Convert.ToDouble(txttotalModificar.Text)

        If (funcion.ModificarVenta(parametros) = True) Then
            MessageBox.Show("Venta Modificada con éxito.")
            mostrarventa()
            Limpiar()
            panelModVenta.Visible = False
            dgvVentas.Visible = True
            Panelbuscador.Visible = True
            btnAltaLogica.Visible = True
            Btnvolver.Visible = True
        Else
            MessageBox.Show("Error al Modificar la venta.")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        panelModVenta.Visible = False
        Panelbuscador.Visible = True
        dgvVentas.Visible = True
        btnAltaLogica.Visible = True
        Btnvolver.Visible = True

    End Sub

    Private Sub dgvVentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellDoubleClick
        Try
            panelModVenta.Visible = True
            panelAltaventa.Visible = False
            btnAltaLogica.Visible = False
            Btnvolver.Visible = False
            btnGuardarCambios.Visible = True
            dgvVentas.Visible = False
            txtNumCliente.Text = dgvVentas.SelectedCells.Item(2).Value
            txtfecha.Text = dgvVentas.SelectedCells.Item(3).Value
            txttotalModificar.Text = dgvVentas.SelectedCells.Item(4).Value
            Lblidventa.Text = dgvVentas.SelectedCells.Item(1).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub panelAltaProduct_Paint(sender As Object, e As PaintEventArgs) Handles panelAltaventa.Paint

    End Sub
End Class