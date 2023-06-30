Imports Doge.Model
Imports Doge.Orders.Doge.Orders.Contracts
Namespace Doge.Orders.Providers
    Public Class OrdersProvider
        Implements IProvider(Of Object, IEnumerable(Of Order))

        Public Sub New(ByVal unitOfWork As IUnitOfWork)

        End Sub

        Public Async Function ProvideAsync(request As Object) As Task(Of IEnumerable(Of Order)) Implements IProvider(Of Object, IEnumerable(Of Order)).ProvideAsync
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
