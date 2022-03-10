using WinFormsSampleApp.Services;
using WinFormsSampleApp.Services.View;
using WinFormsSampleApp.Views;

namespace WinFormsSampleApp;

static class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        ApplicationConfiguration.Initialize();
        Injector.ConfigureServices();

        var form = new ViewHostForm();
        form.Visible = false;
        form.Load += LoadMainView;

        Application.Run(form);
    }

    static void LoadMainView(object? o, EventArgs _)
    {
        if (o is not ViewHostForm form) return;
        form.Load -= LoadMainView;

        var viewService = Injector.Get<IViewService>();
        viewService.SetViewHost(form);
        viewService.LoadView<TaskListView>();

        form.Visible = true;
    }
}
