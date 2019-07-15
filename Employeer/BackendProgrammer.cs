using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Employeer
{
    class BackendProgrammer:Programmer
    {
        public new int testNewBar { set; get; } = 1000;
        public new void  TestNMewMethod()
        {
            WriteLine("BackendProgrammer: Test New Method...");
        }
        public BackendProgrammer(string name="Unknown",decimal salary=-1,Quality quality=Quality.None):base(name,salary)
        {
            Quality = quality;
        }
        public override decimal RealSalary()
        {
            return base.RealSalary()*2;
        }
    }
}
