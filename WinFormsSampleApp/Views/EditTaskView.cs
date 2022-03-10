using WinFormsSampleApp.Models;
using WinFormsSampleApp.Services.Tasks;
using WinFormsSampleApp.Services.View;

namespace WinFormsSampleApp.Views;

sealed partial class EditTaskView : UserControl, IView<TaskEntry?>
{
    readonly ITaskService _taskService;
    readonly IViewService _viewService;
    int? _taskId;

    public string Title => _taskId is null ? "Create task" : "Edit task";

    public EditTaskView(
        ITaskService taskService,
        IViewService viewService)
    : this()
    {
        _taskService = taskService;
        _viewService = viewService;
        _messageInput.TextChanged += MessageChanged;
        _okButton.Click += CreateTask;
        _cancelButton.Click += Cancel;
    }

#pragma warning disable CS8618
    EditTaskView() => InitializeComponent();
#pragma warning restore CS8618

    public Task<Control> LoadView(IViewParams<TaskEntry?> p)
    {
        if (p.Params is TaskEntry task)
        {
            _taskId = task.Id;
            _messageInput.Text = task.Message;
        }

        return Task.FromResult<Control>(this);
    }

    public Task UnloadView() => Task.CompletedTask;

    void MessageChanged(object? _, EventArgs __)
    {
        _okButton.Enabled = !string.IsNullOrWhiteSpace(_messageInput.Text);
    }

    async void CreateTask(object? _, EventArgs __)
    {
        if (string.IsNullOrWhiteSpace(_messageInput.Text)) return;

        try
        {
            Enabled = false;

            if (_taskId is null)
            {
                await _taskService.CreateTask(
                    new TaskEntry(0, _messageInput.Text));
            }
            else
            {
                if (!await _taskService.UpdateTask(
                    new TaskEntry(_taskId.Value, _messageInput.Text)))
                {
                    // TODO: There should be proper UI feedback for this,
                    // maybe a message box service.
                    throw new ApplicationException("Failed to update task");
                }
            }

            _viewService.LoadView<TaskListView>();
        }
        catch (Exception)
        {
            Enabled = true;
            throw;
        }
    }

    void Cancel(object? _, EventArgs __)
    {
        _viewService.LoadView<TaskListView>();
    }
}
