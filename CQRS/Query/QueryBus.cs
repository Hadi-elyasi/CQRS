namespace CQRS;

public class QueryBus : IQueryBus
{

    public IEnumerable<TResult> Dispatch<TQuery, TResult>(TQuery query)
        where TQuery : class
        where TResult : class
    {
        IQueryHandler<TQuery, TResult> handler = null;
        try
        {
            handler = QueryHandlerFactory.CreateHandler<TQuery,TResult>();
            return handler.Handle(query);
        }
        catch (Exception ex)
        {
            throw new QueryHandlerException($"Exception Raised during handler creation: {ex.Message}");
        }
        finally
        {
            if (handler != null)
                ServiceLocator.Current.Release(handler);
        }
    }
}