<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMClientes))
        Me.dgvclientes = New System.Windows.Forms.DataGridView()
        Me.Eli = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnAltaLogica = New System.Windows.Forms.Button()
        Me.LblTituloCliente = New System.Windows.Forms.Label()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.panelAltaCliente = New System.Windows.Forms.Panel()
        Me.Lblidcliente = New System.Windows.Forms.Label()
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lblcliente = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.Panelbuscador = New System.Windows.Forms.Panel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboFiltro = New System.Windows.Forms.ComboBox()
        CType(Me.dgvclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAltaCliente.SuspendLayout()
        Me.Panelbuscador.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvclientes
        '
        Me.dgvclientes.AllowUserToAddRows = False
        Me.dgvclientes.AllowUserToDeleteRows = False
        Me.dgvclientes.AllowUserToResizeRows = False
        Me.dgvclientes.BackgroundColor = System.Drawing.Color.White
        Me.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvclientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eli})
        Me.dgvclientes.Location = New System.Drawing.Point(113, 142)
        Me.dgvclientes.Name = "dgvclientes"
        Me.dgvclientes.ReadOnly = True
        Me.dgvclientes.RowHeadersVisible = False
        Me.dgvclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvclientes.Size = New System.Drawing.Size(609, 307)
        Me.dgvclientes.TabIndex = 0
        '
        'Eli
        '
        Me.Eli.HeaderText = ""
        Me.Eli.Image = CType(resources.GetObject("Eli.Image"), System.Drawing.Image)
        Me.Eli.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eli.Name = "Eli"
        Me.Eli.ReadOnly = True
        '
        'btnAltaLogica
        '
        Me.btnAltaLogica.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAltaLogica.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAltaLogica.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaLogica.Location = New System.Drawing.Point(113, 459)
        Me.btnAltaLogica.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAltaLogica.Name = "btnAltaLogica"
        Me.btnAltaLogica.Size = New System.Drawing.Size(116, 40)
        Me.btnAltaLogica.TabIndex = 29
        Me.btnAltaLogica.Text = "Alta "
        Me.btnAltaLogica.UseVisualStyleBackColor = False
        '
        'LblTituloCliente
        '
        Me.LblTituloCliente.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblTituloCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblTituloCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTituloCliente.ForeColor = System.Drawing.Color.White
        Me.LblTituloCliente.Location = New System.Drawing.Point(0, 0)
        Me.LblTituloCliente.Name = "LblTituloCliente"
        Me.LblTituloCliente.Size = New System.Drawing.Size(800, 123)
        Me.LblTituloCliente.TabIndex = 535
        Me.LblTituloCliente.Text = "CLIENTES"
        Me.LblTituloCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnvolver
        '
        Me.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnvolver.Location = New System.Drawing.Point(550, 459)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(172, 40)
        Me.btnvolver.TabIndex = 536
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'panelAltaCliente
        '
        Me.panelAltaCliente.BackColor = System.Drawing.Color.White
        Me.panelAltaCliente.Controls.Add(Me.Lblidcliente)
        Me.panelAltaCliente.Controls.Add(Me.btnGuardarCambios)
        Me.panelAltaCliente.Controls.Add(Me.Label2)
        Me.panelAltaCliente.Controls.Add(Me.txtCliente)
        Me.panelAltaCliente.Controls.Add(Me.lblcliente)
        Me.panelAltaCliente.Controls.Add(Me.btnCancelar)
        Me.panelAltaCliente.Controls.Add(Me.btnAceptar)
        Me.panelAltaCliente.Controls.Add(Me.lblCorreo)
        Me.panelAltaCliente.Controls.Add(Me.txtcorreo)
        Me.panelAltaCliente.Controls.Add(Me.txttelefono)
        Me.panelAltaCliente.Controls.Add(Me.lblTelefono)
        Me.panelAltaCliente.Location = New System.Drawing.Point(216, 175)
        Me.panelAltaCliente.Name = "panelAltaCliente"
        Me.panelAltaCliente.Size = New System.Drawing.Size(424, 231)
        Me.panelAltaCliente.TabIndex = 537
        Me.panelAltaCliente.Visible = False
        '
        'Lblidcliente
        '
        Me.Lblidcliente.Location = New System.Drawing.Point(19, 63)
        Me.Lblidcliente.Name = "Lblidcliente"
        Me.Lblidcliente.Size = New System.Drawing.Size(10, 10)
        Me.Lblidcliente.TabIndex = 538
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
        Me.Label2.Text = "ABM CLIENTE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(184, 75)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(137, 20)
        Me.txtCliente.TabIndex = 45
        '
        'lblcliente
        '
        Me.lblcliente.AutoSize = True
        Me.lblcliente.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcliente.Location = New System.Drawing.Point(103, 78)
        Me.lblcliente.Name = "lblcliente"
        Me.lblcliente.Size = New System.Drawing.Size(52, 13)
        Me.lblcliente.TabIndex = 44
        Me.lblcliente.Text = "Cliente:"
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
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(103, 130)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(52, 13)
        Me.lblCorreo.TabIndex = 36
        Me.lblCorreo.Text = "Correo:"
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(184, 127)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(137, 20)
        Me.txtcorreo.TabIndex = 35
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(184, 101)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(137, 20)
        Me.txttelefono.TabIndex = 34
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(103, 104)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(60, 13)
        Me.lblTelefono.TabIndex = 33
        Me.lblTelefono.Text = "Telefono:"
        '
        'Panelbuscador
        '
        Me.Panelbuscador.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panelbuscador.Controls.Add(Me.txtbuscar)
        Me.Panelbuscador.Controls.Add(Me.PictureBox1)
        Me.Panelbuscador.Controls.Add(Me.cboFiltro)
        Me.Panelbuscador.Location = New System.Drawing.Point(113, 12)
        Me.Panelbuscador.Name = "Panelbuscador"
        Me.Panelbuscador.Size = New System.Drawing.Size(646, 76)
        Me.Panelbuscador.TabIndex = 538
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
        Me.cboFiltro.Items.AddRange(New Object() {"Cliente", "Telefono", "Correo"})
        Me.cboFiltro.Location = New System.Drawing.Point(72, 9)
        Me.cboFiltro.Name = "cboFiltro"
        Me.cboFiltro.Size = New System.Drawing.Size(481, 21)
        Me.cboFiltro.TabIndex = 41
        '
        'FMClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 526)
        Me.Controls.Add(Me.Panelbuscador)
        Me.Controls.Add(Me.panelAltaCliente)
        Me.Controls.Add(Me.dgvclientes)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.LblTituloCliente)
        Me.Controls.Add(Me.btnAltaLogica)
        Me.Name = "FMClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.dgvclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAltaCliente.ResumeLayout(False)
        Me.panelAltaCliente.PerformLayout()
        Me.Panelbuscador.ResumeLayout(False)
        Me.Panelbuscador.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvclientes As DataGridView
    Private WithEvents btnAltaLogica As Button
    Friend WithEvents LblTituloCliente As Label
    Friend WithEvents btnvolver As Button
    Friend WithEvents panelAltaCliente As Panel
    Friend WithEvents Label2 As Label
    Private WithEvents txtCliente As TextBox
    Private WithEvents lblcliente As Label
    Private WithEvents btnCancelar As Button
    Private WithEvents btnAceptar As Button
    Private WithEvents lblCorreo As Label
    Private WithEvents txtcorreo As TextBox
    Private WithEvents txttelefono As TextBox
    Private WithEvents lblTelefono As Label
    Friend WithEvents Eli As DataGridViewImageColumn
    Private WithEvents btnGuardarCambios As Button
    Friend WithEvents Lblidcliente As Label
    Friend WithEvents Panelbuscador As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboFiltro As ComboBox
    Friend WithEvents txtbuscar As TextBox
End Class
