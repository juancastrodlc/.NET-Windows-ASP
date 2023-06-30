Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration
Imports System.Runtime.Remoting.Contexts
Imports Doge.Model

Public Class OrdersDbContext
    Inherits DbContext

    Protected Sub New()
        MyBase.New($"name={NameOf(OrdersDbContext)}")
    End Sub

    Public Property Orders As DbSet(Of Order)
    Protected Sub CreateTables()
        Const sqlTextCreateTables = "
        CREATE TABLE IF NOT EXISTS Orders
        (
            OrderId String PRIMARY KEY NOT NULL,
            Street TEXT NOT NULL,
            Number INTEGER NOT NULL,
            Ext TEXT,
            ExtraLine TEXT,
            PostalCode TEXT NOT NULL,
            City TEXT NOT NULL,
            State TEXT NOT NULL,
            DeliverBy DATETIME NOT NULL,
            Created DATETIME NOT NULL
        );
        CREATE INDEX IF NOT EXISTS indexAddress ON Orders (PostalCode, Number, Ext);
        "

        Dim connectionString = Database.Connection.ConnectionString
        Using dbConnection = New SQLite.SQLiteConnection(connectionString)
            dbConnection.Open()
            Using dbCommand = dbConnection.CreateCommand()
                dbCommand.CommandText = sqlTextCreateTables
                dbCommand.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub Seed()
        Orders.Add(New Model.Order With {
            .OrderId = "ORD-827328738394616457",
            .Number = "86",
            .Street = "Randall Mill Lane Lutherville",
            .City = "Timonium",
            .State = "MD",
            .PostalCode = "21093",
            .DeliveryBy = Date.UtcNow.AddMinutes(3),
.Created = Date.UtcNow})

        Orders.Add(New Model.Order With {
            .OrderId = "ORD-8189310825445357906",
            .Number = "9848",
            .Street = "NW. Roberts St.",
            .City = "Sidney",
            .State = "OH",
            .PostalCode = "45365",
            .DeliveryBy = Date.UtcNow.AddDays(4).AddHours(10).AddMinutes(25),
            .Created = Date.UtcNow})

        Context.Orders.AddOrUpdate(New Model.Order With {
            .OrderId = "ORD-8189310825445357906",
            .Number = "9693",
            .Street = "Stonybrook St.",
            .City = "Mobile",
            .State = "AL",
            .PostalCode = "36605",
            .DeliveryBy = Date.UtcNow.AddHours(10).AddMinutes(25),
            .Created = Date.UtcNow})
    End Sub
    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        CreateTables()
        OnModelCreatingTable(modelBuilder.Entity(Of Order))
        MyBase.OnModelCreating(modelBuilder)

    End Sub

    Private Sub OnModelCreatingTable(orders As EntityTypeConfiguration(Of Order))
        orders.ToTable(NameOf(OrdersDbContext.Orders)).HasKey(Function(order) order.OrderId)
        orders.[Property](Function(order) order.Street).IsRequired()
        orders.[Property](Function(order) order.Number).IsRequired()
        orders.[Property](Function(order) order.Ext).IsOptional()
        orders.[Property](Function(order) order.Extraline).IsOptional()
        orders.[Property](Function(order) order.DeliveryBy).IsRequired()
        orders.[Property](Function(order) order.PostalCode).IsRequired()
        orders.[Property](Function(order) order.City).IsRequired()
        orders.[Property](Function(order) order.State).IsRequired()
        orders.[Property](Function(order) order.Created).IsRequired()
    End Sub

    Public Shared Sub PreventDatabaseDrop()
        Database.SetInitializer(Of OrdersDbContext)(Nothing)
    End Sub
End Class
