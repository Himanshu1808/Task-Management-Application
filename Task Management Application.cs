using System;
using System.Collections.Generic;
using System.Linq;

public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
}

public class TaskRepository
{
    private List<Task> tasks;

    public TaskRepository()
    {
        tasks = new List<Task>();
    }

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void UpdateTask(Task task)
    {
        var existingTask = tasks.FirstOrDefault(t => t.Id == task.Id);
        if (existingTask != null)
        {
            existingTask.Title = task.Title;
            existingTask.Description = task.Description;
            existingTask.IsCompleted = task.IsCompleted;
        }
    }

    public void DeleteTask(int taskId)
    {
        var task = tasks.FirstOrDefault(t => t.Id == taskId);
        if (task != null)
        {
            tasks.Remove(task);
        }
    }

    public List<Task> GetTasks()
    {
        return tasks;
    }
}

public class Program
{
    private static TaskRepository taskRepository = new TaskRepository();

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Task Management Application");
            Console.WriteLine("1. Create Task");
            Console.WriteLine("2. Update Task");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. Mark Task as Completed");
            Console.WriteLine("5. View All Tasks");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateTask();
                    break;
                case "2":
                    UpdateTask();
                    break;
                case "3":
                    DeleteTask();
                    break;
                case "4":
                    MarkTaskAsCompleted();
                    break;
                case "5":
                    ViewAllTasks();
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void CreateTask()
    {
        Console.WriteLine("Enter task details:");

        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Task task = new Task()
        {
            Id = taskRepository.GetTasks().Count + 1,
            Title = title,
            Description = description,
            IsCompleted = false
        };

        taskRepository.AddTask(task);

        Console.WriteLine("Task created successfully.");
        Console.WriteLine();
    }

    private static void UpdateTask()
    {
        Console.Write("Enter the task ID to update: ");
        int taskId = int.Parse(Console.ReadLine());

        var task = taskRepository.GetTasks().FirstOrDefault(t => t.Id == taskId);

        if (task != null)
        {
            Console.Write("Enter new title (leave empty to keep the existing value): ");
            string newTitle = Console.ReadLine();
            if (!string.IsNullOrEmpty(newTitle))
            {
                task.Title = newTitle;
            }

            Console.Write("Enter new description (leave empty to keep the existing value): ");
            string newDescription = Console.ReadLine();
            if (!string.IsNullOrEmpty(newDescription))
            {
                task.Description = newDescription;
            }

            Console.WriteLine("Task updated successfully.");
        }
        else
        {
            Console.WriteLine("Task not found.");
        }

        Console.WriteLine();
    }

    private static void DeleteTask()
    {
        Console.Write("Enter the task ID to delete: ");
        int taskId = int.Parse(Console.ReadLine());

        taskRepository.DeleteTask(taskId);

        Console.WriteLine("Task deleted successfully.");
        Console.WriteLine();
    }

    private static void MarkTaskAsCompleted()
    {
        Console.Write("Enter the task ID to mark as completed: ");
        int taskId = int.Parse(Console.ReadLine());

        var task = taskRepository.GetTasks().FirstOrDefault(t => t.Id == taskId);

        if (task != null)
        {
            task.IsCompleted = true;
            Console.WriteLine("Task marked as completed.");
        }
        else
        {
            Console.WriteLine("Task not found.");
        }

        Console.WriteLine();
    }

    private static void ViewAllTasks()
    {
        var tasks = taskRepository.GetTasks();

        Console.WriteLine("All Tasks:");

        foreach (var task in tasks)
        {
            Console.WriteLine($"Task ID: {task.Id}");
            Console.WriteLine($"Title: {task.Title}");
            Console.WriteLine($"Description: {task.Description}");
            Console.WriteLine($"Is Completed: {(task.IsCompleted ? "Yes" : "No")}");
            Console.WriteLine();
        }
    }
}
