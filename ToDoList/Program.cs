using System;
using System.Collections.Generic;

namespace ToDoListTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the to do list program.");
            List<string> taskList = new List<string>();
            string option = "";

            while(option != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add a task to the list.");
                Console.WriteLine("Enter 2 to remove a task from the list,");
                Console.WriteLine("Enter 3 to view the list.");
                Console.WriteLine("Enter e to exit the program.");

                option = Console.ReadLine();

                if(option == "1")
                {
                    System.Console.WriteLine("Please enter the name of the task to add to the list.");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    System.Console.WriteLine("Task added to list.");
                }
                else if(option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        System.Console.WriteLine(i + " : " + taskList[i]);
                    }

                    System.Console.WriteLine("Please enter the number of the task to remove from the list.");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                }
                else if (option == "3")
                {
                    System.Console.WriteLine("Current tasks in the list :");

                    for (int i = 0; i < taskList.Count; i++)
                    {
                        System.Console.WriteLine(taskList[i]);
                    }
                }
                else if (option == "e")
                {
                    System.Console.WriteLine("Exiting the program");
                }
                else
                {
                    Console.WriteLine("Invalid option please try again.");
                }
            }
        }
    }
}