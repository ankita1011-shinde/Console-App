using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro20Apr.ArrayString
{
    //revesre  the string
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence");
            string str =Console.ReadLine();
            string s = " ";
            for(int i=0;i<str.Length;i++)
            {
                s = str[i] + s;
            }
            Console.WriteLine("Revrese string: "+s);
        }
    }
    //Reverse word in string
    class reverseWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence");
            string str = Console.ReadLine();

            string[] s = str.Split(" ");
            string word = " ";

            for(int i=0;i<s.Length;i++)
            {
                string s1 = s[i];
                string str1 = " ";
                for(int j=0; j<s1.Length;j++)
                {
                    str1 = s1[j] + str1;
                }
                word = word + str1 + " ";
            }
            Console.WriteLine(word);
        }
    }
}
