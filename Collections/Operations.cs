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

        public static void QueueFunction()
        {
            //initializing Queue
            Queue<string> vs = new Queue<string>();
            //Adding elements in to queue using Enqueue Operation
            vs.Enqueue("TVS");
            vs.Enqueue("BridgeLbs");
            vs.Enqueue("Dell");
            vs.Enqueue("Vivek");
            //returns true if the given input exist in the queue
            bool res = vs.Contains("Lenovo");
            Console.WriteLine(res);

            foreach (string str in vs)
            {
                Console.WriteLine(str);
            }
            //returning total count
            Console.WriteLine("Total Elements in Queue are :" + vs.Count);

        }

        public static void DictionaryFunction()
        {
            //Initialising Dictionary
            Dictionary<int, string> details = new Dictionary<int, string>();
            //Adding elements into Dictionary
            details.Add(112, "Vivek");
            details.Add(113, "Adutya");
            details.Add(114, "Pavani");
            //Chceking if the entered element is present in the dictionary
            bool res = details.ContainsKey(112);
            if (res)
            {
                Console.WriteLine("Value present in the key is" + details.GetValueOrDefault(112));
            }

            foreach (var i in details)
            {
                Console.WriteLine("Key is {0} , Value is {1}", i.Key, i.Value);
            }

            Console.WriteLine("Total elements in dictionay are" + details.Count);
        }

        public static void SetMethod()
        {
            //Initialising HashSet
            HashSet<int> set = new HashSet<int>();
            //Imserting elements into set
            set.Add(21);
            set.Add(28);
            set.Add(29);
            set.Add(44);
            set.Remove(28);

            foreach (var i in set)
            {
                Console.WriteLine(i);
            }
            //returining size of hashset
            Console.WriteLine("Number of elements in the list are :" + set.Count);
            
        }
    }
}
