Public Class VentasItems
    Dim Id As Integer
    Dim Venta As Ventas
    Dim Producto As Product
    Dim PrecioUnitario As Double
    Dim Cantidad As Double
    Dim PrecioTotal As Double
    Dim NombreProducto As String

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim otro As VentasItems = TryCast(obj, VentasItems)
        If otro Is Nothing Then
            Return False
        End If
        Return Me._Id = otro._Id
    End Function

    Public Sub New()
        Id = 0
        Venta = New Ventas
        Producto = New Product
        PrecioUnitario = 0
        Cantidad = 0
        PrecioTotal = 0
    End Sub
    Public Sub New(ByVal idVI As Integer, ByVal vent As Ventas, ByVal product As Product, ByVal PU As Double, ByVal cant As Double, ByVal PrecTotal As Double)
        Id = idVI
        Venta = vent
        Producto = product
        PrecioUnitario = PU
        Cantidad = cant
        PrecioTotal = PrecTotal
    End Sub

    Public Property _Id As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property
    Public Property _Ventas As Ventas
        Get
            Return Venta
        End Get
        Set(value As Ventas)
            Venta = value
        End Set
    End Property
    Public Property _Producto As Product
        Get
            Return Producto
        End Get
        Set(value As Product)
            Producto = value
        End Set
    End Property
    Public Property _PrecioUnitario As Double
        Get
            Return PrecioUnitario
        End Get
        Set(value As Double)
            PrecioUnitario = value
        End Set
    End Property
    Public Property _Cantidad As Double
        Get
            Return Cantidad
        End Get
        Set(value As Double)
            Cantidad = value
        End Set
    End Property
    Public Property _PrecioTotal As Double
        Get
            Return PrecioTotal
        End Get
        Set(value As Double)
            PrecioTotal = value
        End Set
    End Property

    Public Property _NombreProducto As String
        Get
            Return NombreProducto
        End Get
        Set(value As String)
            NombreProducto = value
        End Set
    End Property


End Class
