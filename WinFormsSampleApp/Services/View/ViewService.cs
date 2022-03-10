using Microsoft.Extensions.DependencyInjection;

namespace WinFormsSampleApp.Services.View;

sealed record ViewParams<T>(T Params) : IViewParams<T>;

sealed class ViewService : IViewService
{
    IViewHost? _host;

    public void SetViewHost(IViewHost host)
    {
        if (_host == host) return;

        if (_host is not null)
        {
            var control = _host.DetachViewControl();
            if (control is not null) _host.AttachViewControl(control);
        }

        _host = host;
    }

    public void LoadView<TView, TParams>(TParams viewParams)
    where TView : IView<TParams>
    {
        if (_host is null)
        {
            throw new InvalidOperationException("No view host configured");
        }

        var view = Injector.Resolve<TView>();

        _host.LoadView(view, new ViewParams<TParams>(viewParams));
    }
}
