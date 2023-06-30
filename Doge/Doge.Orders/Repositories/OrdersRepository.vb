Imports Doge.Model

Public Class OrdersRepository
    Implements IOrdersRepository
    Private ReadOnly ordersContext As OrdersDbContext


    Public Sub Add(entity As Order) Implements IRepository(Of Order, String).Add
        Throw New NotImplementedException()
    End Sub

    Public Sub Remove(entity As Order) Implements IRepository(Of Order, String).Remove
        Throw New NotImplementedException()
    End Sub

    Public Function FindAll() As IEnumerable(Of Order) Implements IOrdersRepository.FindAll
        Throw New NotImplementedException()
    End Function

    Public Function Find(text As String) As IEnumerable(Of Order) Implements IOrdersRepository.Find
        Throw New NotImplementedException()
    End Function

    Public Function GetById(id As String) As Order Implements IRepository(Of Order, String).GetById
        Throw New NotImplementedException()
    End Function
End Class
