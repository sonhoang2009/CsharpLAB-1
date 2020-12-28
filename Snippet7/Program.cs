using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet7
{
    class Employee
    {
        private int _id;
        private string _name;
            
        public Employee()
        {
            _id = -1;
            _name = null;
        }

        public Employee(int id, string name)
        {
            this._id = id;
            this._name = name;
        }
        static void Main(string[] args)
        {
            Employee objEmp = new Employee(101, "David Smith");
            Console.WriteLine("Employee ID : {0} \nEmployee Name : {1}", objEmp._id, objEmp._name);

            Console.ReadKey();
        }
    }
}
