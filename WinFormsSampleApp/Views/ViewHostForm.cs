using WinFormsSampleApp.Services.View;

namespace WinFormsSampleApp.Views;

sealed partial class ViewHostForm : Form, IViewHost
{
    private IViewBase? _currentView;

    public ViewHostForm() => InitializeComponent();

    public async Task LoadView<TView, TParams>(
        TView view,
        IViewParams<TParams> p)
    where TView : IView<TParams>
    {
        if (_currentView is not null) await _currentView.UnloadView();

        try
        {
            SuspendLayout();

            var control = await view.LoadView(p);
            Text = view.Title;
            control.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(control);

            _currentView = view;
        }
        finally
        {
            ResumeLayout();
        }
    }

    public void AttachViewControl(Control control)
    {
        Controls.Clear();
        Controls.Add(control);
        control.Dock = DockStyle.Fill;
    }

    public Control? DetachViewControl()
    {
        if (Controls.Count == 0) return null;

        var control = Controls[0];
        Controls.Clear();

        return control;
    }
}

