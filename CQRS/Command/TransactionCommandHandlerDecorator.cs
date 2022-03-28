namespace CQRS;
public class TransactionCommandHandlerDecorator<T> : ICommandHandler<T> where T : class
{
    private readonly ICommandHandler<T> _targetHandler;
    private readonly IUnitOfWork _unitOfWork;

    public TransactionCommandHandlerDecorator(ICommandHandler<T> targetHandler,
        IUnitOfWork unitOfWork)
    {
        _targetHandler = targetHandler;
        _unitOfWork = unitOfWork;
    }

    public void Handle(T command)
    {
        //ToDo: Implementing unitofwork
        _targetHandler.Handle(command);


        _unitOfWork.Begin();
        try
        {
            _targetHandler.Handle(command);
            _unitOfWork.Commit();
        }
        catch (Exception e)
        {
            _unitOfWork.Rollback();
            throw;
        }
    }
}

