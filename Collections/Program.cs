using System;
using System.Collections.Generic;

namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Collections Programs......");
            Console.WriteLine("Enter an option :");
            int options = Convert.ToInt32(Console.ReadLine());

            switch(options)
            {
                case 1:

                    Operations.ListFunction();
                    break;
                case 2:
                    Operations.StackFunction();
                    break;
                default:
                    Console.WriteLine("Enter valid option :");
                    break;
            }

         
        }

       
    }
       
}
        

        


