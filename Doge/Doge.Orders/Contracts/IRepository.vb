Public Interface IRepository(Of TEntity As Class, In TKey)
    Function GetById(id As TKey) As TEntity
    Sub Add(entity As TEntity)
    Sub Remove(entity As TEntity)
End Interface
