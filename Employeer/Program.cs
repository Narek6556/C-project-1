using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Employeer
{
    class Program
    {
        static void Main(string[] args)
        {
            Employ e;
            Write("Enter int from 1 to 4... ");
            int n = int.Parse(ReadLine());
            switch (n)
            {
                case 1:
                    e = new Programmer("Tom", 200000, Quality.Junior);
                    break;
                case 2:
                    e = new BackendProgrammer("Tom", 200000, Quality.Junior);
                    break;
                case 3:
                    e = new Malyar("Tom", 200000, 15.5);
                    break;
                case 4:
                    e = new Employ("Tom", 200000);
                    break;
                default:
                    e = null;
                    break;
            }
            WriteLine(e.RealSalary());
        }
        
            

    }

        
}
