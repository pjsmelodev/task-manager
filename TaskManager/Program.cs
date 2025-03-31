using System;
using System.Collections.Generic;

class TaskManager {
        static List<string> tasks = new List<string>();
        static List<bool> taskStatus = new List<bool>();

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