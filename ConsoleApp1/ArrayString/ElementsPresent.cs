using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro20Apr.ArrayString
{
    //check given num is present in array
    class ElementsPresent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            int c = 0;
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("Enter the num which you want to check");
            int n=Convert.ToInt32(Console.ReadLine());
            bool isPresent = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (n == arr[i])
                {
                    isPresent = true;
                    c++;

                }
            }
                if (isPresent)
                {
                    Console.WriteLine("Present..in "+c+" Times");
                }

                else
                {
                    Console.WriteLine("Not present");
                }
            
        }
    }
}
