using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro20Apr.ArrayString
{ //create array of 10 names and sort in descending order
    class Class2
    {
        static void Main(string[] args)
        {
            string[] nm = new string[10];
            Console.WriteLine($"Enter {10} names in array");
            for (int i = 0; i < nm.Length; i++)
            { 
                nm[i]=Console.ReadLine();
            }

            for (int i=0;i<nm.Length;i++)
            {
                Console.Write(nm[i]+" ");
            }

            

            
        }
    }
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1;
            Console.WriteLine("Enter number for fibonacci ");
            int count = Convert.ToInt32(Console.ReadLine());
            int n3;
            //Console.WriteLine(n1+" "+n2);

            for (int i = 1; i < count; i++)
            {
                
                n3 = n1 + n2;
                
                n1 = n2;
                n2 = n3;
               
            }
            Console.WriteLine(n1);

        }
    }

    class Test
    {
        public static void pupAge()
        {
            int age = 0;
            age = age + 7;
            Console.WriteLine("pupy age:" + age);
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            Test.pupAge();
        }
       
    }

    class Anagra
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            if(s1.Length==s2.Length)
            {
                char[] a1 = s1.ToCharArray();
                foreach(char ch in a1)
                {
                    int idx = s2.IndexOf('z');
                    if(idx!=-1)
                    {
                        s2 = s2.Substring(0, idx)+s2.Substring(idx+1);
                    }
                }
                if(s2.Length==0)
                    Console.WriteLine("Anagram");
                else
                    Console.WriteLine("Not");
            }
            else
                Console.WriteLine("NOt");

        }
    }

    class sustring
    {
        static void Main(string[] args)
        {
            int size=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j;
            int max = 0;
            int zero,ones;
            for (int i = 0; i < arr.Length; i++)
            {
                zero = 0;
                ones = 0;
                for (j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                        zero++;
                    else
                        ones++;
                    if(zero==ones)
                    {
                        max = max > (j - i + 1) ? max : j - i + 1;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
