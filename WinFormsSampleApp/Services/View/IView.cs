namespace WinFormsSampleApp.Services.View;

interface IViewParams<TParams>
{
    TParams Params { get; }
}

interface IViewBase
{
    public string Title => "";

    Task UnloadView();
}

interface IView<TParams> : IViewBase
{
    Task<Control> LoadView(IViewParams<TParams> viewParams);
}

readonly struct NoParams {}

interface IView : IView<NoParams> {}

