using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Employeer
{
    public enum Quality
    {
        None,Junior=1,Middle,Senior
    };
    class Programmer : Employ
    {
        public new int testNewBar { set; get; } = 100;
        public new void TestNMewMethod()
        {
            WriteLine("Programmer: Test New Method...");
        }
        public Programmer(string nm = "Unknown", decimal salary = -1, Quality quality = Quality.None) : base(name, salary)
        {
            Quality = quality;
        }
        
        public Quality Quality {set;get;}
        public override string ToString()
        {
            return base.ToString() + "\t" + Quality;
        }
        public override decimal RealSalary()
        {
            return base.RealSalary() * (int)Quality;
        }
    }
}
