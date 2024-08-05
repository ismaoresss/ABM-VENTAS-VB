Public Class Cliente
    Public Id As Integer
    Public Cliente As String
    Public Telefono As String
    Public Correo As String

    Public Sub New()
        Id = 0
        Cliente = ""
        Telefono = ""
        Correo = ""
    End Sub
    Public Sub New(ByVal IdC As Integer, ByVal clientes As String, ByVal tel As String, ByVal correos As String)
        Id = IdC
        Cliente = clientes
        Telefono = tel
        Correo = correos
    End Sub

    Public Property _Id As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property
    Public Property _Cliente As String
        Get
            Return Cliente
        End Get
        Set(value As String)
            Cliente = value
        End Set
    End Property
    Public Property _Telefono As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
        End Set
    End Property
    Public Property _Correo As String
        Get
            Return Correo
        End Get
        Set(value As String)
            Correo = value
        End Set
    End Property
End Class
