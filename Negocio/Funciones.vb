Public Class Funciones
    Public Sub Multilinea(ByRef List As DataGridView)
        List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        List.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        List.EnableHeadersVisualStyles = False
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.White
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Font = New Font("Segoe UI", 10, FontStyle.Regular Or
        FontStyle.Bold)
        List.ColumnHeadersDefaultCellStyle = styCabeceras


    End Sub

End Class
