using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        // In-memory task list
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Console To-Do List App ===");

            while (true)
            {
                ShowMenu();

                Console.Write("Choose an option (1-3): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        Console.WriteLine("Exiting... Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please choose 1, 2, or 3.");
                        break;
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Add a Task");
            Console.WriteLine("2 - View All Tasks");
            Console.WriteLine("3 - Exit");
        }

        static void AddTask()
        {
            Console.Write("Enter the task description: ");
            string task = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(task))
            {
                tasks.Add(task);
                Console.WriteLine("Task added successfully.");
            }
            else
            {
                Console.WriteLine("Task description cannot be empty.");
            }
        }

        static void ViewTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            Console.WriteLine("Your Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }
}
