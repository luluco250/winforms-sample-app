using WinFormsSampleApp.Models;
using WinFormsSampleApp.Services.Tasks;
using WinFormsSampleApp.Services.View;

namespace WinFormsSampleApp.Views;

sealed partial class TaskListView : UserControl, IView
{
    readonly ITaskService _taskService;
    readonly IViewService _viewService;
    readonly CancellationTokenSource _cancel;

    public string Title => "Tasks";

    public TaskListView(
        ITaskService taskService,
        IViewService viewService)
    : this()
    {
        _taskService = taskService;
        _viewService = viewService;
        _cancel = new();
        _taskList.SelectedIndexChanged += SelectionChanged;
        _taskList.MouseDoubleClick += EditTask;
        _removeButton.Click += RemoveSelections;
        _addButton.Click += CreateTask;
    }

    // Required for designer support.
    // Ignore nullability checks as those are irrelevant at design-time.
#pragma warning disable CS8618
    TaskListView() => InitializeComponent();
#pragma warning restore CS8618

    public async Task<Control> LoadView(IViewParams<NoParams> _)
    {
        _taskList.Items.Clear();
        _taskList.DisplayMember = nameof(TaskEntry.Message);

        try
        {
            Enabled = false;

            var tasks = await _taskService.GetTasks();
            if (_cancel.IsCancellationRequested) return this;

            _taskList.Items.AddRange(tasks.ToArray());

            return this;
        }
        finally
        {
            Enabled = true;
        }
    }

    public async Task UnloadView()
    {
        _cancel.Cancel();
        await Task.CompletedTask;
    }

    void SelectionChanged(object? _, EventArgs __)
    {
        _removeButton.Enabled = _taskList.SelectedItems.Count > 0;
    }

    async void RemoveSelections(object? _, EventArgs __)
    {
        if (_taskList.SelectedItems.Count == 0) return;

        try
        {
            Enabled = false;

            await _taskService.DeleteTasks(
                _taskList
                .SelectedItems
                .Cast<TaskEntry>()
                .Select(x => x.Id)
            );

            if (_cancel.IsCancellationRequested) return;

            _taskList.BeginUpdate();
            for (var i = _taskList.SelectedIndices.Count - 1; i >= 0; --i)
            {
                _taskList.Items.RemoveAt(_taskList.SelectedIndices[i]);
            }
        }
        finally
        {
            _taskList.EndUpdate();
            Enabled = true;
        }
    }

    void CreateTask(object? _, EventArgs __)
    {
        _viewService.LoadView<EditTaskView, TaskEntry?>(null);
    }

    private void EditTask(object? _, MouseEventArgs e)
    {
        var index = _taskList.IndexFromPoint(e.Location);

        if (index > 0)
        {
            var task = (TaskEntry)_taskList.Items[index];
            _viewService.LoadView<EditTaskView, TaskEntry?>(task);
        }
    }
}
