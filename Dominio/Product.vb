Public Class Product
    Dim Id As Integer
    Dim Nombre As String
    Dim Precio As Double
    Dim Categoria As String
    Public Sub New()
        Id = 0
        Nombre = ""
        Precio = 0
        Categoria = ""
    End Sub
    Public Sub New(ByVal IdP As Integer, ByVal nom As String, ByVal prec As Double, ByVal categ As String)
        Id = IdP
        Nombre = nom
        Precio = prec
        Categoria = categ
    End Sub
    Public Property _Id As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property
    Public Property _Nombre As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property
    Public Property _Precio As Double
        Get
            Return Precio
        End Get
        Set(value As Double)
            Precio = value
        End Set
    End Property
    Public Property _Categoria As String
        Get
            Return Categoria
        End Get
        Set(value As String)
            Categoria = value
        End Set
    End Property
End Class
