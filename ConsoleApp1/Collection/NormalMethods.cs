using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LogicalPro20Apr.Collection
{
    class NormalMethods
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Ankita");
            al.Add("95");
            al.Add("Pune");
            al.Add("ankitashinde@gmail");
            al.Add("Rohit");
            for(int i= 1;i<5;i++)
            {
                al.Add(i);
            }
            al.Insert(1, "Patil");
            al.Remove("Rohit");
            al.RemoveRange(1, 3);
            al.RemoveAt(1);
            al.Insert(1,"Rohit");
            al.AddRange(al);

            for(int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }


        }
    }
}
