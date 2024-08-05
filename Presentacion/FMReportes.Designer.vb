<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMReportes
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
        Me.lblreporte = New System.Windows.Forms.Label()
        Me.dgvProduc = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btnvolver = New System.Windows.Forms.Button()
        CType(Me.dgvProduc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblreporte
        '
        Me.lblreporte.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblreporte.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblreporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblreporte.ForeColor = System.Drawing.Color.White
        Me.lblreporte.Location = New System.Drawing.Point(0, 0)
        Me.lblreporte.Name = "lblreporte"
        Me.lblreporte.Size = New System.Drawing.Size(734, 107)
        Me.lblreporte.TabIndex = 537
        Me.lblreporte.Text = "REPORTE"
        Me.lblreporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvProduc
        '
        Me.dgvProduc.AllowUserToAddRows = False
        Me.dgvProduc.AllowUserToDeleteRows = False
        Me.dgvProduc.AllowUserToResizeRows = False
        Me.dgvProduc.BackgroundColor = System.Drawing.Color.White
        Me.dgvProduc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduc.Location = New System.Drawing.Point(62, 212)
        Me.dgvProduc.Name = "dgvProduc"
        Me.dgvProduc.ReadOnly = True
        Me.dgvProduc.RowHeadersVisible = False
        Me.dgvProduc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduc.Size = New System.Drawing.Size(611, 209)
        Me.dgvProduc.TabIndex = 565
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(48, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(638, 77)
        Me.Label1.TabIndex = 566
        Me.Label1.Text = " Lista de productos con sus cantidades totales vendidas mensualmente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btnvolver
        '
        Me.Btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnvolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btnvolver.Location = New System.Drawing.Point(62, 427)
        Me.Btnvolver.Name = "Btnvolver"
        Me.Btnvolver.Size = New System.Drawing.Size(172, 40)
        Me.Btnvolver.TabIndex = 567
        Me.Btnvolver.Text = "Volver"
        Me.Btnvolver.UseVisualStyleBackColor = True
        '
        'FMReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 528)
        Me.Controls.Add(Me.Btnvolver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvProduc)
        Me.Controls.Add(Me.lblreporte)
        Me.Name = "FMReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        CType(Me.dgvProduc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblreporte As Label
    Friend WithEvents dgvProduc As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnvolver As Button
End Class
