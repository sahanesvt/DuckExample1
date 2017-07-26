using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckExample1
{
    public class Squeak:iQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
