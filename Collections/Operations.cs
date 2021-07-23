using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Operations
    {
        public static void ListFunction()
        {
            //Initializing list
            List<string> list = new List<string>();
            //Adding objects to list 
            list.Add("Vivek");
            list.Add("Harish");
            list.Add("Sathyabama");
           

            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
            //Printing Number of elements in the list using count
            Console.WriteLine("Number of Elements in the list are :"+list.Count);

            // Capacity - returns the number of elements list can contain
            Console.WriteLine(list.Capacity);
        }
        public static void StackFunction()
        {
            //Initialising stack collection
            Stack<int> id = new Stack<int>();
            //Adding elements using push operation
            id.Push(11);
            id.Push(13);
            id.Push(29);
            id.Push(21);
            //deleting element from stack using pop 
            int del = id.Pop();

            Console.WriteLine("Elements in stack are :");
            foreach (int i in id)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Popped element is :" + del);
            //returns true if the given input is present in stack.
            Console.WriteLine(id.Contains(10));
        }
    }
}
