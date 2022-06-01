using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro20Apr.ExceptionHandling
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Division is " + a / b);
            }

            catch(DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero..."+e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid input... "+e.Message);
            }
        }
    }
    class Mobile
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("enter moblie no");
            float n = Convert.ToInt64(Console.ReadLine());
            int c = 0;

            while(n!=0)
            {
                c++;
                n = n / 10;
            }
            try
            {
                if (c==10)
                    Console.WriteLine("valid mobile no");
                else

                    throw new InvalidMobileException("Mobile no is should be 10 digit");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class InvalidMobileException:ApplicationException
    {
        public InvalidMobileException(string s) : base(s)
        { 
        }
    }

    class HandleCatch
    {
        static void Main(string[] args)
        {
           
            try
            {
                string s = null;

                Console.WriteLine(s.Substring(4));
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Please check the string s"+e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("continue");
        }
    }
    class MultipleException
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter two num");
                int n1 = Convert.ToInt32(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("div is: " + n1 / n2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("divident not be zero");
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Continue program...");
            }
        }
    }
}
