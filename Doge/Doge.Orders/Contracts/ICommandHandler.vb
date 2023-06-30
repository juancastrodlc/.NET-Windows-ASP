Namespace Doge.Orders.Contracts
    Public Interface ICommandHandler(Of TCommand)
        Function HandleAsync(ByVal command As TCommand) As Task

    End Interface
End Namespace
