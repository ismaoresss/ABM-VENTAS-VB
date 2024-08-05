Public Class Ventas
    Dim Id As Integer
    Dim Cliente As Cliente
    Dim IdCliente As Integer
    Dim Fecha As DateTime
    Dim Total As Double

    Public Sub New()
        Id = 0
        IdCliente = 0
        Cliente = New Cliente
        Fecha = New DateTime
        Total = 0
    End Sub
    Public Sub New(ByVal IdV As Integer, ByVal Client As Cliente, ByVal fec As DateTime, ByVal Tot As Double, ByVal IdC As Integer)
        Id = IdV
        IdCliente = IdC
        Cliente = Client
        Fecha = fec
        Total = Tot
    End Sub

    Public Property _Id As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property
    Public Property _IdCliente As Integer
        Get
            Return IdCliente
        End Get
        Set(value As Integer)
            IdCliente = value
        End Set
    End Property
    Public Property _Cliente As Cliente
        Get
            Return Cliente
        End Get
        Set(value As Cliente)
            Cliente = value
        End Set
    End Property
    Public Property _Fecha As DateTime
        Get
            Return Fecha
        End Get
        Set(value As DateTime)
            Fecha = value
        End Set
    End Property
    Public Property _Total As Double
        Get
            Return Total
        End Get
        Set(value As Double)
            Total = value
        End Set
    End Property

End Class
