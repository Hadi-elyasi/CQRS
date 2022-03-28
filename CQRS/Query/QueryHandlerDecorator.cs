
namespace CQRS;

public class QueryHandlerDecorator<TQuery, TResult> :
    IQueryHandler<TQuery, TResult> where TQuery : class where TResult : class
{
    private readonly IQueryHandler<TQuery, TResult> _targetHandler;


    public QueryHandlerDecorator(IQueryHandler<TQuery, TResult> targetHandler)
    {
        this._targetHandler = targetHandler;

    }

    public IEnumerable<TResult> Handle(TQuery query)
    {
        //ToDo: Implementing unitofwork
        return _targetHandler.Handle(query);

    }
}