using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro20Apr.ArrayString
{
    class Example
    {
        static void Main(string[] args)
        {


            string[] a = { "ankita", "Rohit", "jaya", "Mahalaxmi" };
            string longword = a[0];

            for (int i = 0; i<a.Length;i++)
            {
                if(longword.Length<=a[i].Length)
                {
                    longword = a[i];
                }
            }
            Console.WriteLine("Longest word is: "+longword);
            Console.WriteLine();
            string shortword = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if(shortword.Length>=a[i].Length)
                {
                    shortword = a[i];
                }
            }
            Console.WriteLine("Shortest word is: "+shortword);

        }
    }
}
