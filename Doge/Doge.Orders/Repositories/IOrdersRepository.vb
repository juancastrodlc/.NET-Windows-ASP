Imports Doge.Model

Public Interface IOrdersRepository
    Inherits IRepository(Of Order, String)
    Function FindAll() As IEnumerable(Of Order)
    Function Find(text As String) As IEnumerable(Of Order)
End Interface
