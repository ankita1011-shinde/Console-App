using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro20Apr.ArrayString
{

    class cource
    {
        static string course_name;
        static int course_fees;
    }
    class Student
    {
        string name;
        string address;
        float contact;

        public Student(string name, string address, float contact)
        {
            this.Name = name;
            this.Address = address;
            this.Contact = contact;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public float Contact { get => contact; set => contact = value; }
    }
        
    class Pro
    {

    }
    
}
