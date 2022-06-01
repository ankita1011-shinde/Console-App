using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro20Apr.ArrayString
{
    //count num of vowel from the string
    class CountVowel
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter sentence");
            string str=Console.ReadLine();
            int vc = 0;
            int cc = 0;
            str=str.ToLower();
            Console.WriteLine(str);
            //char[] ch=str.ToCharArray();
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]=='a' || str[i]=='e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' )
                {
                    vc++;
                }
                else if(str[i]>='a' && str[i]<='z')
                {
                    cc++;
                }

            }

            Console.WriteLine("Total vowels are: "+vc);
            Console.WriteLine("Total Consonants are: "+cc);
        }

    }
}
