using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckExample1
{
    public class ModelDuck:Duck
    {
        public ModelDuck()
        {
            _quackBehavior = new Squeak();
            _flyBehavior = new FlyNoWay();
        }
    }
}
