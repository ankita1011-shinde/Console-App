using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro20Apr.ArrayString
{
    class Employee
    {
        int id;
        string name;
        int salary;

        public Employee()
        {

        }
        public Employee(int id,string nm,int sal)
        {
            this.Id = id;
            this.Name = nm;
            this.Salary = sal;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
    }
    class program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[5]
            {
                new Employee { Id = 1, Name = "Ankita", Salary = 50000 },
                new Employee { Id = 2, Name = "jaya", Salary = 5000 },
                new Employee { Id = 3, Name = "vijay", Salary = 20000 },
                new Employee { Id = 4, Name = "pravin", Salary = 25000 },
                 new Employee{ Id = 5, Name = "rohit", Salary = 75000 },

                    
            };
            
            
        }
    }
}
