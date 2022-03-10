using System.Collections.Concurrent;
using WinFormsSampleApp.Models;

namespace WinFormsSampleApp.Services.Tasks;

sealed class MockTaskService : ITaskService
{
    readonly ConcurrentDictionary<int, TaskEntry> _tasks = new();
    int _currentId = 0;

    public MockTaskService()
    {
        CreateTaskCore(new TaskEntry(0, "Do the dishes"));
        CreateTaskCore(new TaskEntry(0, "Walk the dog"));
        CreateTaskCore(new TaskEntry(0, "Check email"));
    }

    public async Task<TaskEntry?> GetTask(int id)
    {
        return await Delay(() => _tasks.TryGetValue(id, out var task)
            ? task
            : null
        );
    }

    public async Task<IEnumerable<TaskEntry>> GetTasks()
    {
        return await Delay(() => _tasks.Values);
    }

    public async Task<int> CreateTask(TaskEntry task)
    {
        return await Delay(() => CreateTaskCore(task));
    }

    public async Task<bool> UpdateTask(TaskEntry task)
    {
        return await Delay(() =>
        {
            if (!_tasks.TryGetValue(task.Id, out var existing)) return false;
            _tasks.TryUpdate(task.Id, task, existing);
            return true;
        });
    }

    public async Task DeleteTask(int id)
    {
        await Delay(() => _tasks.TryRemove(id, out _));
    }

    public async Task DeleteTasks(IEnumerable<int> ids)
    {
        await Delay(() =>
        {
            foreach (var id in ids) _tasks.TryRemove(id, out _);
        });
    }

    int CreateTaskCore(TaskEntry entry)
    {
        var id = Interlocked.Increment(ref _currentId);
        _tasks.TryAdd(id, entry with { Id = id });
        return id;
    }

    static async Task Delay(Action callback)
    {
        await Task.Run(() =>
        {
            Sleep();
            callback();
        });
    }

    static async Task<T> Delay<T>(Func<T> callback)
    {
        return await Task.Run(() =>
        {
            Sleep();
            return callback();
        });
    }

    static void Sleep() => Thread.Sleep(Random.Shared.Next(3000));
}
