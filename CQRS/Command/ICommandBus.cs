namespace CQRS;

public interface ICommandBus
{
    void Dispatch<T>(T command) where T : class;
}

