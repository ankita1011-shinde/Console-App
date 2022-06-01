using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro20Apr.ArrayString
{
    //Count odd even elements from array
    class OddEvenCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            int evencount=0;
            int oddcount = 0;

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
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evencount++;
                }

                else
                    oddcount++;
            }
            Console.WriteLine("evencount is: "+evencount);
            Console.WriteLine("Oddcount is: "+oddcount);
        }
    }
}
