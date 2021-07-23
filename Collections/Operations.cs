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
    }
}
