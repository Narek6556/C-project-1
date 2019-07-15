using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Employeer
{
    class Employ
    {
        public int testNewBar { set; get; } = 10;
        public void TestNMewMethod ()
        {
            WriteLine("Employ: Test New Method...");
        }
        private decimal salary;
        public string Name { set; get; }
        public static decimal Tax { set; get; }
        
        public decimal Salary { get => salary; set => salary = value; }

        static Employ()
        {
            Write("Enter Taxes...");
            Tax = int.Parse(ReadLine());
        }
        public Employ(string name="Unknown",decimal salary=-1)
        {
            Salary = salary;
            Name = name;
        }
        public override string ToString()
        {
            return Name + "\t" + Salary;
        }
        public virtual  decimal RealSalary()
        {
            return Salary - (Salary * Tax / 100);
        }
        
    }
}
