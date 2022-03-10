namespace WinFormsSampleApp.Services.View;

interface IViewHost
{
    Task LoadView<TView, TParams>(TView view, IViewParams<TParams> p)
    where TView : IView<TParams>;

    void AttachViewControl(Control control);

    Control? DetachViewControl();
}
