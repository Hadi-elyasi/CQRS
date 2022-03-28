using System.Diagnostics;

namespace CQRS;

public static class ServiceLocator
{
    public static IServiceLocator Current { get; private set; }
    public static void Set(IServiceLocator locator)
    {
        Debug.Assert(Current == null);
        //#if DEBUG
        //            if (Current != null) throw new Exception(); 
        //#endif

        Current = locator;
    }
}

