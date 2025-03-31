using System;
using System.Collections.Generic;

class TaskManager {
        static List<string> tasks = new List<string>();
        static List<bool> taskStatus = new List<bool>();

        static void AddTask() {
            Console.WriteLine("Enter task description:");
            string task = Console.ReadLine();
            tasks.Add(task);
            taskStatus.Add(false);
            Console.WriteLine("Task Added Successfully");
        }

        static void CompleteTask() {
            int taskCount = tasks.Count;;

            if (taskCount == 0)
            {
                Console.WriteLine("No tasks available to complete.");
                return;
            }

            Console.WriteLine("Enter task number to mark as completed:");
            if (
                int.TryParse(Console.ReadLine(), out int taskNumber)
                && taskNumber > 0
                && taskNumber <= tasks.Count
            )
            {
                taskStatus[taskNumber - 1] = true;
                Console.WriteLine($"Task '{tasks[taskNumber - 1]}' marked as completed.");
            }
            else {
                Console.WriteLine("Invalid task number.");
            }
        }

        static void ViewTasks() {
            if (tasks.Count == 0) {
                Console.WriteLine("No tasks available.");
                return;
            }

            Console.WriteLine("Tasks:");
            for (var i = 0; i < tasks.Count; i++)
            {
                // Operador ternário
                // Se true -> "Completed" // Se false -> "Pending"
                string status = taskStatus[i] ? "Completed" : "Pending";
                Console.WriteLine($"{i + 1} {tasks[i] - {status}}");
            }
        }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Task Manager");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Mark Task as Completed");
            Console.WriteLine("3. View Tasks");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    CompleteTask();
                    break;
                case "3":
                    ViewTasks();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            
        }
    }
}