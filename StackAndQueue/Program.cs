using System;
using System.Collections;

namespace StackAndQueue
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Data Structure Stack And Queue Problems");

            bool check = true;

            Start:
            while (check)
            {
                
                Console.WriteLine("Please Select Options :\n" +
                    "1)Elements added using Linked List in Stack using Push method\n");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        StackLinkedList stack = new StackLinkedList();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Pushing Elements in the Stack as :\n");
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        Console.WriteLine("::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Element in stack given as :\n" );
                        stack.Display();
                        Console.WriteLine("::::::::::::::::::::::::::::::::::::::");
                        break;
                    default:
                        Console.WriteLine("Please Enter Proper Option");
                        break;
                        goto Start;
                }
            }


        }
    }
}