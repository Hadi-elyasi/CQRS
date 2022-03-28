using Microsoft.Extensions.DependencyInjection;

namespace CQRS;

public static class Bootstrapper
{

    public static void WireUp(IServiceCollection services)
    {
        services.AddTransient(typeof(TransactionCommandHandlerDecorator<>));
        ServiceLocator.Set(new MicrosoftIOCServiceLocator(services));
    }
}

