using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.Json;

namespace TaskTracker
{
    public class TaskManager
    {
        private const string FilePath = "tasks.json";
        private List<Task> _tasks;

        public TaskManager()
        {
            _tasks = LoadTasks();
        }

        private List<Task> LoadTasks()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    // Create an empty file if it doesn't exist
                    File.WriteAllText(FilePath, "[]");
                    return new List<Task>();
                }

                var jsonData = File.ReadAllText(FilePath);

                // If the file is empty, return an empty list
                if (string.IsNullOrWhiteSpace(jsonData))
                {
                    return new List<Task>();
                }

                // Deserialize the tasks from JSON
                return JsonSerializer.Deserialize<List<Task>>(jsonData) ?? new List<Task>();
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error loading tasks: Invalid JSON format. Resetting tasks.json.");
                Console.WriteLine(ex.Message);
                // Reset the file to an empty JSON array
                File.WriteAllText(FilePath, "[]");
                return new List<Task>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading tasks.");
                Console.WriteLine(ex.Message);
                return new List<Task>();
            }
        }

        private void SaveTasks()
        {
            try
            {
                var jsonData = JsonSerializer.Serialize(_tasks, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(FilePath, jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving tasks.");
                Console.WriteLine(ex.Message);
            }
        }

        public void AddTask(string description)
        {
            int newId = _tasks.Count + 1;
            var newTask = new Task(newId, description);
            _tasks.Add(newTask);
            SaveTasks();
            Console.WriteLine($"Task added successfully (ID: {newId}).");
        }

        public void UpdateTask(int id, string newDescription)
        {
            var task = _tasks.Find(t => t.Id == id);
            if (task != null)
            {
                task.Description = newDescription;
                task.UpdatedAt = DateTime.Now;
                SaveTasks();
                Console.WriteLine($"Task updated successfully (ID: {id})");
            }
            else
            {
                Console.WriteLine($"Task with ID {id} not found.");
            }
        }

        public void DeleteTask(int id)
        {
            var task = _tasks.Find(t => t.Id == id);
            if (task != null)
            {
                _tasks.Remove(task);
                SaveTasks();
                Console.WriteLine($"Task deleted successfully (ID: {id})");
            }
            else
            {
                Console.WriteLine($"Task with ID {id} not found.");
            }
        }

        public void ChangeTaskStatus(int id, string newStatus)
        {
            var task = _tasks.Find(t => t.Id == id);
            if (task != null && (newStatus.Equals("Pending", StringComparison.OrdinalIgnoreCase) ||
                                 newStatus.Equals("In Progress", StringComparison.OrdinalIgnoreCase) ||
                                 newStatus.Equals("Done", StringComparison.OrdinalIgnoreCase)))
            {
                task.Status = newStatus;
                task.UpdatedAt = DateTime.Now;
                SaveTasks();
                Console.WriteLine($"Task {id} marked as {newStatus}.");
            }
            else
            {
                Console.WriteLine($"Task with ID {id} not found or invalid status.");
            }
        }

        public void MarkInProgress(int id)
        {
            ChangeTaskStatus(id, "In Progress");
        }

        public void MarkDone(int id)
        {
            ChangeTaskStatus(id, "Done");
        }

        public void ListTasks(string status = null)
        {
            foreach (var task in _tasks)
            {
                // If status is null, list all tasks
                if (status == null ||
                    task.Status.Equals(status, StringComparison.OrdinalIgnoreCase) ||
                    (status.Equals("todo", StringComparison.OrdinalIgnoreCase) && task.Status.Equals("Pending", StringComparison.OrdinalIgnoreCase)) ||
                    (status.Equals("in-progress", StringComparison.OrdinalIgnoreCase) && task.Status.Equals("In Progress", StringComparison.OrdinalIgnoreCase)) ||
                    (status.Equals("done", StringComparison.OrdinalIgnoreCase) && task.Status.Equals("Done", StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine(task);
                }
            }
        }
    }
}
