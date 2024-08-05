<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMVentas))
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Btnvolver = New System.Windows.Forms.Button()
        Me.btnAltaLogica = New System.Windows.Forms.Button()
        Me.Panelbuscador = New System.Windows.Forms.Panel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboFiltro = New System.Windows.Forms.ComboBox()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.Eli = New System.Windows.Forms.DataGridViewImageColumn()
        Me.panelAltaventa = New System.Windows.Forms.Panel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnMayor = New System.Windows.Forms.Button()
        Me.btnMenor = New System.Windows.Forms.Button()
        Me.dgvVentasAgregadas = New System.Windows.Forms.DataGridView()
        Me.dgvproductos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.panelModVenta = New System.Windows.Forms.Panel()
        Me.Lblidventa = New System.Windows.Forms.Label()
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumCliente = New System.Windows.Forms.TextBox()
        Me.LBLID = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txttotalModificar = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Panelbuscador.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAltaventa.SuspendLayout()
        CType(Me.dgvVentasAgregadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelModVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(0, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(794, 107)
        Me.Label25.TabIndex = 536
        Me.Label25.Text = "VENTAS"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btnvolver
        '
        Me.Btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnvolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btnvolver.Location = New System.Drawing.Point(548, 413)
        Me.Btnvolver.Name = "Btnvolver"
        Me.Btnvolver.Size = New System.Drawing.Size(172, 40)
        Me.Btnvolver.TabIndex = 561
        Me.Btnvolver.Text = "Volver"
        Me.Btnvolver.UseVisualStyleBackColor = True
        '
        'btnAltaLogica
        '
        Me.btnAltaLogica.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAltaLogica.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAltaLogica.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaLogica.Location = New System.Drawing.Point(109, 413)
        Me.btnAltaLogica.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAltaLogica.Name = "btnAltaLogica"
        Me.btnAltaLogica.Size = New System.Drawing.Size(116, 40)
        Me.btnAltaLogica.TabIndex = 552
        Me.btnAltaLogica.Text = "Alta "
        Me.btnAltaLogica.UseVisualStyleBackColor = False
        '
        'Panelbuscador
        '
        Me.Panelbuscador.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panelbuscador.Controls.Add(Me.txtbuscar)
        Me.Panelbuscador.Controls.Add(Me.PictureBox1)
        Me.Panelbuscador.Controls.Add(Me.cboFiltro)
        Me.Panelbuscador.Location = New System.Drawing.Point(109, 12)
        Me.Panelbuscador.Name = "Panelbuscador"
        Me.Panelbuscador.Size = New System.Drawing.Size(646, 76)
        Me.Panelbuscador.TabIndex = 565
        '
        'txtbuscar
        '
        Me.txtbuscar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtbuscar.ForeColor = System.Drawing.Color.Black
        Me.txtbuscar.Location = New System.Drawing.Point(72, 36)
        Me.txtbuscar.Multiline = True
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(481, 27)
        Me.txtbuscar.TabIndex = 539
        Me.txtbuscar.Text = "Buscar Cliente..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 539
        Me.PictureBox1.TabStop = False
        '
        'cboFiltro
        '
        Me.cboFiltro.FormattingEnabled = True
        Me.cboFiltro.Items.AddRange(New Object() {"IdCliente", "Año"})
        Me.cboFiltro.Location = New System.Drawing.Point(72, 9)
        Me.cboFiltro.Name = "cboFiltro"
        Me.cboFiltro.Size = New System.Drawing.Size(481, 21)
        Me.cboFiltro.TabIndex = 41
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToDeleteRows = False
        Me.dgvVentas.AllowUserToResizeRows = False
        Me.dgvVentas.BackgroundColor = System.Drawing.Color.White
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eli})
        Me.dgvVentas.Location = New System.Drawing.Point(109, 110)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.ReadOnly = True
        Me.dgvVentas.RowHeadersVisible = False
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(611, 296)
        Me.dgvVentas.TabIndex = 564
        '
        'Eli
        '
        Me.Eli.HeaderText = ""
        Me.Eli.Image = CType(resources.GetObject("Eli.Image"), System.Drawing.Image)
        Me.Eli.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eli.Name = "Eli"
        Me.Eli.ReadOnly = True
        '
        'panelAltaventa
        '
        Me.panelAltaventa.BackColor = System.Drawing.Color.White
        Me.panelAltaventa.Controls.Add(Me.btnEliminar)
        Me.panelAltaventa.Controls.Add(Me.Button1)
        Me.panelAltaventa.Controls.Add(Me.txtTotal)
        Me.panelAltaventa.Controls.Add(Me.btnFinalizar)
        Me.panelAltaventa.Controls.Add(Me.Label6)
        Me.panelAltaventa.Controls.Add(Me.btnMayor)
        Me.panelAltaventa.Controls.Add(Me.btnMenor)
        Me.panelAltaventa.Controls.Add(Me.dgvVentasAgregadas)
        Me.panelAltaventa.Controls.Add(Me.dgvproductos)
        Me.panelAltaventa.Controls.Add(Me.Label4)
        Me.panelAltaventa.Controls.Add(Me.Panel1)
        Me.panelAltaventa.Controls.Add(Me.lblProducto)
        Me.panelAltaventa.Controls.Add(Me.btnAceptar)
        Me.panelAltaventa.Location = New System.Drawing.Point(134, 94)
        Me.panelAltaventa.Name = "panelAltaventa"
        Me.panelAltaventa.Size = New System.Drawing.Size(571, 653)
        Me.panelAltaventa.TabIndex = 566
        Me.panelAltaventa.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(239, 467)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(73, 54)
        Me.btnEliminar.TabIndex = 613
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(488, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 612
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(116, 527)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(443, 35)
        Me.txtTotal.TabIndex = 611
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnFinalizar.FlatAppearance.BorderSize = 0
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFinalizar.ForeColor = System.Drawing.Color.White
        Me.btnFinalizar.Location = New System.Drawing.Point(151, 597)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(263, 49)
        Me.btnFinalizar.TabIndex = 610
        Me.btnFinalizar.Text = "Finalizar Venta"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(30, 527)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 29)
        Me.Label6.TabIndex = 609
        Me.Label6.Text = "Total:"
        '
        'btnMayor
        '
        Me.btnMayor.BackColor = System.Drawing.Color.Transparent
        Me.btnMayor.BackgroundImage = CType(resources.GetObject("btnMayor.BackgroundImage"), System.Drawing.Image)
        Me.btnMayor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMayor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMayor.ForeColor = System.Drawing.Color.White
        Me.btnMayor.Location = New System.Drawing.Point(35, 467)
        Me.btnMayor.Name = "btnMayor"
        Me.btnMayor.Size = New System.Drawing.Size(62, 38)
        Me.btnMayor.TabIndex = 608
        Me.btnMayor.UseVisualStyleBackColor = False
        '
        'btnMenor
        '
        Me.btnMenor.BackColor = System.Drawing.Color.Transparent
        Me.btnMenor.BackgroundImage = CType(resources.GetObject("btnMenor.BackgroundImage"), System.Drawing.Image)
        Me.btnMenor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenor.ForeColor = System.Drawing.Color.White
        Me.btnMenor.Location = New System.Drawing.Point(474, 467)
        Me.btnMenor.Name = "btnMenor"
        Me.btnMenor.Size = New System.Drawing.Size(62, 38)
        Me.btnMenor.TabIndex = 605
        Me.btnMenor.UseVisualStyleBackColor = False
        '
        'dgvVentasAgregadas
        '
        Me.dgvVentasAgregadas.AllowUserToAddRows = False
        Me.dgvVentasAgregadas.AllowUserToDeleteRows = False
        Me.dgvVentasAgregadas.AllowUserToResizeRows = False
        Me.dgvVentasAgregadas.BackgroundColor = System.Drawing.Color.White
        Me.dgvVentasAgregadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentasAgregadas.Location = New System.Drawing.Point(35, 360)
        Me.dgvVentasAgregadas.Name = "dgvVentasAgregadas"
        Me.dgvVentasAgregadas.ReadOnly = True
        Me.dgvVentasAgregadas.RowHeadersVisible = False
        Me.dgvVentasAgregadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentasAgregadas.Size = New System.Drawing.Size(501, 101)
        Me.dgvVentasAgregadas.TabIndex = 604
        '
        'dgvproductos
        '
        Me.dgvproductos.AllowUserToAddRows = False
        Me.dgvproductos.AllowUserToDeleteRows = False
        Me.dgvproductos.AllowUserToResizeRows = False
        Me.dgvproductos.BackgroundColor = System.Drawing.Color.White
        Me.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvproductos.Location = New System.Drawing.Point(35, 144)
        Me.dgvproductos.Name = "dgvproductos"
        Me.dgvproductos.ReadOnly = True
        Me.dgvproductos.RowHeadersVisible = False
        Me.dgvproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvproductos.Size = New System.Drawing.Size(501, 170)
        Me.dgvproductos.TabIndex = 603
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(216, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 29)
        Me.Label4.TabIndex = 602
        Me.Label4.Text = "Productos:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtCliente)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 50)
        Me.Panel1.TabIndex = 597
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCliente.Location = New System.Drawing.Point(229, 11)
        Me.txtCliente.Multiline = True
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(113, 30)
        Me.txtCliente.TabIndex = 597
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(58, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 595
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 30)
        Me.Label1.TabIndex = 596
        Me.Label1.Text = "ID:"
        '
        'lblProducto
        '
        Me.lblProducto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblProducto.ForeColor = System.Drawing.Color.White
        Me.lblProducto.Location = New System.Drawing.Point(0, 0)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(571, 46)
        Me.lblProducto.TabIndex = 536
        Me.lblProducto.Text = "ABM VENTA"
        Me.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnAceptar.Location = New System.Drawing.Point(35, 320)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 39
        Me.btnAceptar.Text = "Agregar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'panelModVenta
        '
        Me.panelModVenta.BackColor = System.Drawing.Color.White
        Me.panelModVenta.Controls.Add(Me.Lblidventa)
        Me.panelModVenta.Controls.Add(Me.btnGuardarCambios)
        Me.panelModVenta.Controls.Add(Me.Label2)
        Me.panelModVenta.Controls.Add(Me.txtNumCliente)
        Me.panelModVenta.Controls.Add(Me.LBLID)
        Me.panelModVenta.Controls.Add(Me.btnCancelar)
        Me.panelModVenta.Controls.Add(Me.lbltotal)
        Me.panelModVenta.Controls.Add(Me.txttotalModificar)
        Me.panelModVenta.Controls.Add(Me.txtfecha)
        Me.panelModVenta.Controls.Add(Me.lblfecha)
        Me.panelModVenta.Location = New System.Drawing.Point(181, 110)
        Me.panelModVenta.Name = "panelModVenta"
        Me.panelModVenta.Size = New System.Drawing.Size(424, 231)
        Me.panelModVenta.TabIndex = 567
        Me.panelModVenta.Visible = False
        '
        'Lblidventa
        '
        Me.Lblidventa.Location = New System.Drawing.Point(19, 63)
        Me.Lblidventa.Name = "Lblidventa"
        Me.Lblidventa.Size = New System.Drawing.Size(10, 10)
        Me.Lblidventa.TabIndex = 538
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCambios.ForeColor = System.Drawing.Color.LimeGreen
        Me.btnGuardarCambios.Location = New System.Drawing.Point(106, 176)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(134, 23)
        Me.btnGuardarCambios.TabIndex = 537
        Me.btnGuardarCambios.Text = "Guardar Cambios"
        Me.btnGuardarCambios.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(424, 46)
        Me.Label2.TabIndex = 536
        Me.Label2.Text = "MODIFICAR VENTA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumCliente
        '
        Me.txtNumCliente.Location = New System.Drawing.Point(184, 75)
        Me.txtNumCliente.Name = "txtNumCliente"
        Me.txtNumCliente.Size = New System.Drawing.Size(137, 20)
        Me.txtNumCliente.TabIndex = 45
        '
        'LBLID
        '
        Me.LBLID.AutoSize = True
        Me.LBLID.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLID.Location = New System.Drawing.Point(103, 78)
        Me.LBLID.Name = "LBLID"
        Me.LBLID.Size = New System.Drawing.Size(65, 13)
        Me.LBLID.TabIndex = 44
        Me.LBLID.Text = "Id cliente:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(318, 176)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 40
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(103, 130)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(39, 13)
        Me.lbltotal.TabIndex = 36
        Me.lbltotal.Text = "Total:"
        '
        'txttotalModificar
        '
        Me.txttotalModificar.Location = New System.Drawing.Point(184, 127)
        Me.txttotalModificar.Name = "txttotalModificar"
        Me.txttotalModificar.Size = New System.Drawing.Size(137, 20)
        Me.txttotalModificar.TabIndex = 35
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(184, 101)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(137, 20)
        Me.txtfecha.TabIndex = 34
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(103, 104)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(45, 13)
        Me.lblfecha.TabIndex = 33
        Me.lblfecha.Text = "Fecha:"
        '
        'FMVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(794, 795)
        Me.Controls.Add(Me.panelModVenta)
        Me.Controls.Add(Me.panelAltaventa)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.Panelbuscador)
        Me.Controls.Add(Me.Btnvolver)
        Me.Controls.Add(Me.btnAltaLogica)
        Me.Controls.Add(Me.Label25)
        Me.Name = "FMVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FMVentas"
        Me.Panelbuscador.ResumeLayout(False)
        Me.Panelbuscador.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAltaventa.ResumeLayout(False)
        Me.panelAltaventa.PerformLayout()
        CType(Me.dgvVentasAgregadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelModVenta.ResumeLayout(False)
        Me.panelModVenta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label25 As Label
    Friend WithEvents Btnvolver As Button
    Private WithEvents btnAltaLogica As Button
    Friend WithEvents Panelbuscador As Panel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboFiltro As ComboBox
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents Eli As DataGridViewImageColumn
    Friend WithEvents panelAltaventa As Panel
    Friend WithEvents lblProducto As Label
    Private WithEvents btnAceptar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvproductos As DataGridView
    Private WithEvents btnMenor As Button
    Friend WithEvents dgvVentasAgregadas As DataGridView
    Private WithEvents btnMayor As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Private WithEvents btnEliminar As Button
    Friend WithEvents panelModVenta As Panel
    Friend WithEvents Lblidventa As Label
    Private WithEvents btnGuardarCambios As Button
    Friend WithEvents Label2 As Label
    Private WithEvents txtNumCliente As TextBox
    Private WithEvents LBLID As Label
    Private WithEvents btnCancelar As Button
    Private WithEvents lbltotal As Label
    Private WithEvents txttotalModificar As TextBox
    Private WithEvents txtfecha As TextBox
    Private WithEvents lblfecha As Label
End Class
