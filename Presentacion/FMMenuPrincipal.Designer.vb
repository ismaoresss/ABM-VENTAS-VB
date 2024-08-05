<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMMenuPrincipal
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
        Me.Btnventas = New System.Windows.Forms.Button()
        Me.Btnproductos = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btnreportes = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btnventas
        '
        Me.Btnventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnventas.ForeColor = System.Drawing.Color.Black
        Me.Btnventas.Location = New System.Drawing.Point(366, 155)
        Me.Btnventas.Name = "Btnventas"
        Me.Btnventas.Size = New System.Drawing.Size(154, 79)
        Me.Btnventas.TabIndex = 4
        Me.Btnventas.Text = "Ventas"
        Me.Btnventas.UseVisualStyleBackColor = True
        '
        'Btnproductos
        '
        Me.Btnproductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnproductos.ForeColor = System.Drawing.Color.Black
        Me.Btnproductos.Location = New System.Drawing.Point(366, 23)
        Me.Btnproductos.Name = "Btnproductos"
        Me.Btnproductos.Size = New System.Drawing.Size(154, 79)
        Me.Btnproductos.TabIndex = 5
        Me.Btnproductos.Text = "Productos"
        Me.Btnproductos.UseVisualStyleBackColor = True
        '
        'BtnClientes
        '
        Me.BtnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.ForeColor = System.Drawing.Color.Black
        Me.BtnClientes.Location = New System.Drawing.Point(111, 155)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(154, 79)
        Me.BtnClientes.TabIndex = 6
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(691, 83)
        Me.Label2.TabIndex = 590
        Me.Label2.Text = "Menu Principal"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btnreportes
        '
        Me.Btnreportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnreportes.ForeColor = System.Drawing.Color.Black
        Me.Btnreportes.Location = New System.Drawing.Point(111, 23)
        Me.Btnreportes.Name = "Btnreportes"
        Me.Btnreportes.Size = New System.Drawing.Size(154, 79)
        Me.Btnreportes.TabIndex = 591
        Me.Btnreportes.Text = "Reportes"
        Me.Btnreportes.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Controls.Add(Me.Btnreportes)
        Me.Panel1.Controls.Add(Me.Btnventas)
        Me.Panel1.Controls.Add(Me.BtnClientes)
        Me.Panel1.Controls.Add(Me.Btnproductos)
        Me.Panel1.Location = New System.Drawing.Point(28, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(630, 306)
        Me.Panel1.TabIndex = 592
        '
        'FMMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(691, 444)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FMMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPrincipal"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btnventas As Button
    Friend WithEvents Btnproductos As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Btnreportes As Button
    Friend WithEvents Panel1 As Panel
End Class
