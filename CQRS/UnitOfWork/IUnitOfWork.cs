namespace CQRS;

public interface IUnitOfWork
{    
    void Begin();
    void Commit();
    void Rollback();
    void Save();
    void Dispose();
}

