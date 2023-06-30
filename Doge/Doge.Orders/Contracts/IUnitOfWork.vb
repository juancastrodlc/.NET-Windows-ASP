Namespace Doge.Orders.Contracts
    Public Interface IUnitOfWork
        Inherits IDisposable
        Function CompleteWorkAsync() As Task

    End Interface

End Namespace
