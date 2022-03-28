using Microsoft.Extensions.DependencyInjection;

namespace CQRS;
public class MicrosoftIOCServiceLocator : IServiceLocator
{
    private readonly IServiceCollection _services;
    public static ServiceProvider _serviceProvider;
    public MicrosoftIOCServiceLocator(IServiceCollection services)
    {
        _services = services;

    }

    public T Resolve<T>()
    {
        try
        {
            _serviceProvider = _services.BuildServiceProvider();
            return _serviceProvider.GetService<T>();
        }
        catch (Exception ex)
        {

            throw;
        }

    }

    public void Release(object obj)
    {
        // ToDo dispose obj
    }
}

