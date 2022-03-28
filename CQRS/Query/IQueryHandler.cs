namespace CQRS;

public interface IQueryHandler<TQuery, TResult> where TQuery : class where TResult : class
{
    IEnumerable<TResult> Handle(TQuery query);
}