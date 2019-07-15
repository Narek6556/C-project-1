using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Employeer
{
    class Driver:Employ
    {
        public double Km { set; get; }
        public Driver(string name = "Unknown", decimal salary = -1,double km=1)
        {
            Km = km;
        }
        public override decimal RealSalary()
        {
            return base.RealSalary()*(decimal)Km;
        }
        public override string ToString()
        {
            return base.ToString()+"\t"+Km;
        }
    }
}
