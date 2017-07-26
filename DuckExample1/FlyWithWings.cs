using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckExample1
{
    public class FlyWithWings:iFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying with wings!");
        }
    }
}
