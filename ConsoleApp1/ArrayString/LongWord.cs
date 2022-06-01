using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro20Apr.ArrayString
{
    //Find Longest word from string
    class LongWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any sentence");
            string str = Console.ReadLine();

            string[] s = str.Split(" ");
            string longestword = s[0]; // i am live in maharashtra
                                       //s[0]=i
                                       //s[1]=am
                                       //s[2]=live
                                       //s[3]=in
                                       //s[4]=maharashtra

            for (int i=0;i<s.Length;i++)
            {
                if(longestword.Length<=s[i].Length)
                {
                    longestword = s[i];
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Longest word is: "+longestword);
        }
    }
    //find avg of digit which are present in string
    class Average
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any sentence");
            string str = Console.ReadLine();
            double sum=0, avg=0, c = 0;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]>='0' && str[i]<='9')
                {
                    double x = (double)(char.GetNumericValue(str[i]));
                    sum = sum + x;
                    c++;
                }
            }
            Console.WriteLine(sum+"  "+c);
            avg =sum/c;
            Console.WriteLine(avg);
        }
    }
}
