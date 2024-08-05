<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMProduct))
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btnAltaLogica = New System.Windows.Forms.Button()
        Me.panelAltaProduct = New System.Windows.Forms.Panel()
        Me.LblidProducto = New System.Windows.Forms.Label()
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.txtcategoria = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.Eli = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panelbuscador = New System.Windows.Forms.Panel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboFiltro = New System.Windows.Forms.ComboBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.panelAltaProduct.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelbuscador.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label25.Size = New System.Drawing.Size(831, 109)
        Me.Label25.TabIndex = 536
        Me.Label25.Text = "PRODUCTOS"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnvolver
        '
        Me.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnvolver.Location = New System.Drawing.Point(548, 452)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(172, 40)
        Me.btnvolver.TabIndex = 561
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'btnAltaLogica
        '
        Me.btnAltaLogica.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAltaLogica.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAltaLogica.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaLogica.Location = New System.Drawing.Point(109, 452)
        Me.btnAltaLogica.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAltaLogica.Name = "btnAltaLogica"
        Me.btnAltaLogica.Size = New System.Drawing.Size(116, 40)
        Me.btnAltaLogica.TabIndex = 552
        Me.btnAltaLogica.Text = "Alta "
        Me.btnAltaLogica.UseVisualStyleBackColor = False
        '
        'panelAltaProduct
        '
        Me.panelAltaProduct.BackColor = System.Drawing.Color.White
        Me.panelAltaProduct.Controls.Add(Me.LblidProducto)
        Me.panelAltaProduct.Controls.Add(Me.btnGuardarCambios)
        Me.panelAltaProduct.Controls.Add(Me.lblProducto)
        Me.panelAltaProduct.Controls.Add(Me.txtnombre)
        Me.panelAltaProduct.Controls.Add(Me.lblNombre)
        Me.panelAltaProduct.Controls.Add(Me.btnCancelar)
        Me.panelAltaProduct.Controls.Add(Me.btnAceptar)
        Me.panelAltaProduct.Controls.Add(Me.lblCategoria)
        Me.panelAltaProduct.Controls.Add(Me.txtcategoria)
        Me.panelAltaProduct.Controls.Add(Me.txtprecio)
        Me.panelAltaProduct.Controls.Add(Me.lblPrecio)
        Me.panelAltaProduct.Location = New System.Drawing.Point(211, 173)
        Me.panelAltaProduct.Name = "panelAltaProduct"
        Me.panelAltaProduct.Size = New System.Drawing.Size(424, 231)
        Me.panelAltaProduct.TabIndex = 562
        Me.panelAltaProduct.Visible = False
        '
        'LblidProducto
        '
        Me.LblidProducto.Location = New System.Drawing.Point(19, 63)
        Me.LblidProducto.Name = "LblidProducto"
        Me.LblidProducto.Size = New System.Drawing.Size(10, 10)
        Me.LblidProducto.TabIndex = 538
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCambios.ForeColor = System.Drawing.Color.LimeGreen
        Me.btnGuardarCambios.Location = New System.Drawing.Point(112, 176)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(134, 23)
        Me.btnGuardarCambios.TabIndex = 537
        Me.btnGuardarCambios.Text = "Guardar Cambios"
        Me.btnGuardarCambios.UseVisualStyleBackColor = True
        '
        'lblProducto
        '
        Me.lblProducto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblProducto.ForeColor = System.Drawing.Color.White
        Me.lblProducto.Location = New System.Drawing.Point(0, 0)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(424, 46)
        Me.lblProducto.TabIndex = 536
        Me.lblProducto.Text = "ABM PRODUCTO"
        Me.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(184, 75)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(137, 20)
        Me.txtnombre.TabIndex = 45
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(103, 78)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 13)
        Me.lblNombre.TabIndex = 44
        Me.lblNombre.Text = "Nombre:"
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
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.LimeGreen
        Me.btnAceptar.Location = New System.Drawing.Point(31, 176)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 39
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.Location = New System.Drawing.Point(103, 130)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(68, 13)
        Me.lblCategoria.TabIndex = 36
        Me.lblCategoria.Text = "Categoria:"
        '
        'txtcategoria
        '
        Me.txtcategoria.Location = New System.Drawing.Point(184, 127)
        Me.txtcategoria.Name = "txtcategoria"
        Me.txtcategoria.Size = New System.Drawing.Size(137, 20)
        Me.txtcategoria.TabIndex = 35
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(103, 104)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(47, 13)
        Me.lblPrecio.TabIndex = 33
        Me.lblPrecio.Text = "Precio:"
        '
        'dgvProduct
        '
        Me.dgvProduct.AllowUserToAddRows = False
        Me.dgvProduct.AllowUserToDeleteRows = False
        Me.dgvProduct.AllowUserToResizeRows = False
        Me.dgvProduct.BackgroundColor = System.Drawing.Color.White
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eli})
        Me.dgvProduct.Location = New System.Drawing.Point(109, 149)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.ReadOnly = True
        Me.dgvProduct.RowHeadersVisible = False
        Me.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduct.Size = New System.Drawing.Size(611, 296)
        Me.dgvProduct.TabIndex = 563
        '
        'Eli
        '
        Me.Eli.HeaderText = ""
        Me.Eli.Image = CType(resources.GetObject("Eli.Image"), System.Drawing.Image)
        Me.Eli.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eli.Name = "Eli"
        Me.Eli.ReadOnly = True
        '
        'Panelbuscador
        '
        Me.Panelbuscador.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panelbuscador.Controls.Add(Me.txtbuscar)
        Me.Panelbuscador.Controls.Add(Me.PictureBox1)
        Me.Panelbuscador.Controls.Add(Me.cboFiltro)
        Me.Panelbuscador.Location = New System.Drawing.Point(134, 12)
        Me.Panelbuscador.Name = "Panelbuscador"
        Me.Panelbuscador.Size = New System.Drawing.Size(646, 76)
        Me.Panelbuscador.TabIndex = 564
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
        Me.cboFiltro.Items.AddRange(New Object() {"Nombre", "Categoria", "Precio"})
        Me.cboFiltro.Location = New System.Drawing.Point(72, 9)
        Me.cboFiltro.Name = "cboFiltro"
        Me.cboFiltro.Size = New System.Drawing.Size(481, 21)
        Me.cboFiltro.TabIndex = 41
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(184, 101)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(137, 20)
        Me.txtprecio.TabIndex = 34
        '
        'FMProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(831, 525)
        Me.Controls.Add(Me.Panelbuscador)
        Me.Controls.Add(Me.panelAltaProduct)
        Me.Controls.Add(Me.dgvProduct)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnAltaLogica)
        Me.Controls.Add(Me.Label25)
        Me.Name = "FMProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FMProduct"
        Me.panelAltaProduct.ResumeLayout(False)
        Me.panelAltaProduct.PerformLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelbuscador.ResumeLayout(False)
        Me.Panelbuscador.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label25 As Label
    Friend WithEvents btnvolver As Button
    Private WithEvents btnAltaLogica As Button
    Friend WithEvents panelAltaProduct As Panel
    Friend WithEvents LblidProducto As Label
    Private WithEvents btnGuardarCambios As Button
    Friend WithEvents lblProducto As Label
    Private WithEvents txtnombre As TextBox
    Private WithEvents lblNombre As Label
    Private WithEvents btnCancelar As Button
    Private WithEvents btnAceptar As Button
    Private WithEvents lblCategoria As Label
    Private WithEvents txtcategoria As TextBox
    Private WithEvents lblPrecio As Label
    Friend WithEvents dgvProduct As DataGridView
    Friend WithEvents Eli As DataGridViewImageColumn
    Friend WithEvents Panelbuscador As Panel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboFiltro As ComboBox
    Private WithEvents txtprecio As TextBox
End Class
