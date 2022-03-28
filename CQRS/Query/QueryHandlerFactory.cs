
namespace CQRS;

public class QueryHandlerFactory
{
    public static IQueryHandler<TQuery, TResult> CreateHandler<TQuery, TResult>() 
        where TQuery : class where TResult : class
    {

        return ServiceLocator.Current.Resolve<QueryHandlerDecorator<TQuery, TResult>>();
    }


}