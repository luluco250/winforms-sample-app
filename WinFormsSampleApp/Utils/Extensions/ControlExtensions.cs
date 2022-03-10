namespace WinFormsSampleApp.Utils.Extensions;

static class ControlExtensions
{
    public static async Task InvokeAsync(
        this Control control,
        Action action)
    {
        await Task
            .Factory
            .FromAsync(control.BeginInvoke(action), control.EndInvoke);
    }

    public static async Task<TResult> InvokeAsync<TResult>(
        this Control control,
        Func<TResult> action)
    {
        return await Task
            .Factory
            .FromAsync(
                control.BeginInvoke(action),
                x => (TResult)control.EndInvoke(x)
            );
    }
}
