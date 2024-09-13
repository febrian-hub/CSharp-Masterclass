using System;
using System.Collections.Generic;

namespace TodoManager
{
    class Program

    {

        static void Main(string[] args)
        {
            List<string> todos = new List<string>();
            string userInput;

            while (true)
            {
                PrintMenu();
                userInput = Console.ReadLine().ToUpper();

                switch (userInput)
                {
                    case "S":
                        SeeAllTodos(todos);
                        break;
                    case "A":
                        AddTodo(todos);
                        break;
                    case "R":
                        RemoveTodo(todos);
                        break;
                    case "E":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO");
            Console.WriteLine("[E]xit");
        }

        static void SeeAllTodos(List<string> todos)
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");
            }
            else
            {
                for (int i = 0; i < todos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todos[i]}");
                }
            }
        }

        static void AddTodo(List<string> todos)
        {
            while (true)
            {
                Console.WriteLine("Enter the TODO description:");
                string description = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(description))
                {
                    Console.WriteLine("The description cannot be empty.");
                }
                else if (todos.Contains(description))
                {
                    Console.WriteLine("The description must be unique.");
                }
                else
                {
                    todos.Add(description);
                    Console.WriteLine($"TODO successfully added: {description}");
                    break;
                }
            }
        }

        static void RemoveTodo(List<string> todos)
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");
                return;
            }

            while (true)
            {
                Console.WriteLine("Select the index of the TODO you want to remove:");
                SeeAllTodos(todos);
                string input = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Selected index cannot be empty.");
                }
                else if (int.TryParse(input, out int index) && index > 0 && index <= todos.Count)
                {
                    string removedTodo = todos[index - 1];
                    todos.RemoveAt(index - 1);
                    Console.WriteLine($"TODO removed: {removedTodo}");
                    break;
                }
                else
                {
                    Console.WriteLine("The given index is not valid.");
                }
            }
        }
    }
}
