namespace CQRS;

public interface IQueryBus
{
    IEnumerable<TResult> Dispatch<TQuery, TResult>(TQuery query) where TQuery : class where TResult : class;
}