using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# To-Do List App!");

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1 - Add Task");
                Console.WriteLine("2 - View Tasks");
                Console.WriteLine("3 - Exit");

                Console.Write("Option: ");
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
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Enter task description: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task added.");
        }

        static void ViewTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks yet.");
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
