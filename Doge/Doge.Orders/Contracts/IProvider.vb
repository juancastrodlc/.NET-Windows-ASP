Namespace Doge.Orders.Contracts
    Public Interface IProvider(Of TRequest, TResponse)
        Function ProvideAsync(ByVal request As TRequest) As Task(Of TResponse)
    End Interface

End Namespace
