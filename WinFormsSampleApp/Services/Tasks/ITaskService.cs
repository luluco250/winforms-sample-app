using WinFormsSampleApp.Models;

namespace WinFormsSampleApp.Services.Tasks;

interface ITaskService
{
    Task<TaskEntry?> GetTask(int id);

    Task<IEnumerable<TaskEntry>> GetTasks();

    Task<int> CreateTask(TaskEntry entry);

    Task<bool> UpdateTask(TaskEntry task);

    Task DeleteTask(int id);

    Task DeleteTasks(IEnumerable<int> ids);
}
