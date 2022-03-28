namespace CQRS;

public class CommandBus : ICommandBus
{
    public void Dispatch<T>(T command) where T : class
    {
        ICommandHandler<T> handler = null;
        try
        {
            handler = CommandHandlerFactory.CreateHandler<T>();
            handler.Handle(command);
        }
        catch (Exception ex)
        {

        }
        finally
        {
            if (handler != null)
                ServiceLocator.Current.Release(handler);
        }
    }


}


