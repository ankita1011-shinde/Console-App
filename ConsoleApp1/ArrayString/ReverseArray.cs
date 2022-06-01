using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro20Apr.ArrayString
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter size of array");
             int size =Convert.ToInt32(Console.ReadLine());

             int[] arr = new int[size];
             Console.WriteLine("Enter array elements");
             for(int i=0;i<size;i++)
             {
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }
            Console.WriteLine("Original Array");
             for (int i = 0; i < arr.Length; i++)
             {
                 Console.Write(arr[i]+" ");
             }
            Console.WriteLine();
            Console.WriteLine("Reverse Array");
            
             for (int i =arr.Length-1; i>=0; i--)
             {
                 Console.Write(arr[i]+" ");
             }

            /*int[] a = { 23, 1, 4, 5, 65, 3, 6 };
            Console.WriteLine("Original array: ");
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Reverse array: ");
            for(int i=a.Length-1;i>=0; i--)
            {
                Console.Write(a[i]+" ");
            }*/
        }
    }
}
