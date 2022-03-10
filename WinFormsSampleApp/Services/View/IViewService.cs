namespace WinFormsSampleApp.Services.View;

interface IViewService
{
    void SetViewHost(IViewHost host);

    void LoadView<TView, TParams>(TParams viewParams)
    where TView : IView<TParams>;

    public sealed void LoadView<TView>()
    where TView : IView => LoadView<TView, NoParams>(default);
}
