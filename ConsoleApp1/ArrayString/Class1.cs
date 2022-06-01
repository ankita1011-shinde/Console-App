using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro20Apr.ArrayString
{
    //1.to find the duplicate words n their num of occurence in string
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence");
            string str =Console.ReadLine();

            str = str.ToLower();
            string [] s = str.Split(" ");
            string word = s[0];
            int c ;

            Console.WriteLine("duplicate words are:");
            for(int i=0;i<s.Length;i++)
            {
                c = 1;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i].Equals(s[j]))
                    {
                        c++;
                        s[j]="0";
                        
                    }
                }
                if(c>1 && s[i]!="0")
                    Console.WriteLine(s[i]+" occured in "+c+" times");
            }

            
        }
    }
    // 2.count the num of word in a string
    class WordCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence");
            string str = Console.ReadLine();

            str = str.ToLower();
            string[] word = str.Split(" ");
            int c = 0;
            for(int i=0;i<word.Length;i++)
            {
                c++;
            }
            Console.WriteLine("total words are: "+c);
        }
    }
    //3.Find Two two strings are anagram
    class Anagram 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st string");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd string");
            string s2 = Console.ReadLine();

            s1 = s1.ToLower();
            s2 = s2.ToLower();

            char[] a1 = s1.ToCharArray();
            char[] a2 = s2.ToCharArray();

            Array.Sort(a1);
            Array.Sort(a2);

            string ss1=new string(a1);
            string ss2=new string(a2);
            if(ss1==ss2)
            {
                Console.WriteLine("Anagram");
            }
            else
                Console.WriteLine("Not Anagram");


            
        }
    }
    //4.find total num of alphabet digit and special num
    class AlphabetDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s1 = Console.ReadLine();
            int ac = 0;
            int dc = 0;
            int c = 0;
            s1 = s1.ToLower();
             
            //char []ch=s1.ToCharArray();
            for(int i=0;i<s1.Length;i++)
            {
                if (s1[i] >= 'a' && s1[i] <= 'z')
                {
                    ac++;
                }
                else if (s1[i] >= '1' && s1[i] <= '9')
                {
                    dc++;
                }
                else
                {
                    c++;
                }
                    
                
                    
                
            }
            Console.WriteLine(" Alphabets" + ac);
            Console.WriteLine("digit" + dc);
            Console.WriteLine("spel "+c);
        }
    }
    //4.create array of 10 names and sort in descending order
    class Name
    {
        static void Main(string[] args)
        {
            string[] nm = new string[5];
            Console.WriteLine($"Enter {10} names in array");
            for (int i = 0; i < nm.Length; i++)
            {
                nm[i] = Console.ReadLine();
            }
         for(int i=0;i<nm.Length;i++)
            {
              for(int j=i+1;j<nm.Length;j++)
                {
                    if(nm[i].CompareTo(nm[j])<0)
                    {
                        string temp = nm[i];
                        nm[i] = nm[j];
                        nm[j] = temp;
                    }
                }
                Console.WriteLine();
                foreach(string s in nm)
                {
                    Console.Write(s+" ");
                }
                
            }
        }
    }
    //6.Convert uppercase to lowercase
    class UpperLower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence");
            string s= Console.ReadLine();

            s = s.ToLower();
            Console.WriteLine("Uppercase: "+s);
            s=s.ToUpper();
            Console.WriteLine("Lowercase: "+s);

        }
    }
    //7.Reverse the array itself..without using temp
    class ReverseArr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine($"Enter {size} elements ");
            for(int i=0;i<size;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Original Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
    //13.print uniwue elements in array
    class Unique
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine($"Enter {size} elements ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Original Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Unique elements");
            for(int i=0;i<arr.Length; i++)
            {
                int count = 0;
               
                for (int j = 0;j<arr.Length;j++)
                {
                    if (arr[i] == arr[j] && j < i)
                        break;
                        
                     else if(arr[i] ==arr[j])
                        count++;


                }
                        if (count==1)
                    Console.Write(arr[i]+" ");
                   
            }
            
        }
    }
    //Unique and  duplicate print once in hole string
    class UniqueString
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter string");
                string s1 = Console.ReadLine();
                string s2 = "   ";
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1.IndexOf(s1[i]) == -1)
                    {
                        //s2 = s1[i] + i;
        }   }   }   }
    }
    //Trim left spaces and after right spaces
    class LeftRightTrim
    {
        static void Main(string[] args)
        {
            string str = "   ankita  ";
            Console.WriteLine(str);


            Console.WriteLine("After left trim");

            string[] str1 = str.Split(" ");
            int j = 0;
            for(int i=0;i<str1.Length;i++)
            {
                if (str1[i].Length !=0)
                    {
                    j = i;
                    break;
                }
            }
            for(int k=j;k<str1.Length;k++)
            {
                Console.WriteLine(str1[k]+" ");
            }
        {

        }
        }
    }

    //find new word in given string
    class CheckWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter srting");
            string s = Console.ReadLine();// ankita

            Console.WriteLine("word"); //nit
            string s2 = Console.ReadLine();

            s = s.ToLower();
            int c = 0;
            bool ispresent;
            for(int i=0;i<s2.Length;i++)
            {
                ispresent = false;
                for (int j = 0; j < s.Length; j++)
                {


                    if (s[i] == s2[i])
                    {
                        ispresent =true; 
                    }

                }
                if(!ispresent)
                {
                    Console.WriteLine("string cant formed");
                    c++;
                }
               
            }
            if(c==0)
            {
                Console.WriteLine("the given string can be formed ");
            }
        }
    }
}
