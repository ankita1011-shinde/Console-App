using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro20Apr.ArrayString
{
    //find maximum and minimum from array
    class MaxMinArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            
            int max = arr[0];
           
            Console.WriteLine("Enter array elements");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");

            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (max<arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("maximum element is: "+max);
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimum element is: "+min);
        }
    }
}
