using TaskManager.Models;

namespace TaskManager.Services;

public class TaskService
{
    private List<TaskModel> _tasks = new();
    private int _nextId = 1;
    public List<TaskModel> GetAllTasks()
    {
        return _tasks;
    }

    public TaskModel GetTaskById(int id)
    {
        return _tasks.FirstOrDefault(t => t.Id == id);
    }



    public TaskModel CreateTask(string title, string description)
    {
        var task = new TaskModel
        {
            Id = _nextId,
            Title = title,
            Description = description,
            Status = false
        };

        _tasks.Add(task);
        _nextId++;

        return task;
    }

    public bool UpdateTask(int taskId, string title, string description, bool status)
    {
        var existingTask = GetTaskById(taskId);
        if (existingTask == null)
            return false;

        existingTask.Title = title;
        existingTask.Description = description;
        existingTask.Status = status;

        return true;
    }

    public bool DeleteTask(int taskId)
    {
        var task = GetTaskById(taskId);
        if (task == null)
            return false;

        _tasks.Remove(task);
        return true;
    }
}