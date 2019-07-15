using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Employeer
{
    class Malyar:Employ
    {
        public double Area { set; get; }
        public Malyar(string nm="Unknown",decimal sl=-1,double area=1):base(nm,sl)
        {
            Area = area;
        }
        public override string ToString()
        {
            return base.ToString() + "\t" + Area;
        }
        public override decimal RealSalary()
        {
            return base.RealSalary()*(decimal)Area;
        }
    }
}
