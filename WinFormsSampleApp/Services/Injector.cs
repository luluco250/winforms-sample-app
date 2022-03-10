using Microsoft.Extensions.DependencyInjection;
using WinFormsSampleApp.Services.Tasks;
using WinFormsSampleApp.Services.View;

namespace WinFormsSampleApp.Services;

static class Injector
{
    static IServiceProvider? _provider;

    public static T Get<T>()
    {
        if (_provider is null) throw NotConfigured();

        return _provider.GetService<T>()
            ?? throw new InvalidOperationException(
                $"Service {typeof(T)} not registered"
            );
    }

    public static T Resolve<T>()
    {
        if (_provider is null) throw NotConfigured();

        return ActivatorUtilities.CreateInstance<T>(_provider);
    }

    public static void ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddSingleton<IViewService, ViewService>();
        services.AddSingleton<ITaskService, MockTaskService>();

        _provider = services.BuildServiceProvider();
    }

    static InvalidOperationException NotConfigured()
    {
        return new InvalidOperationException("Services not configured");
    }
}
