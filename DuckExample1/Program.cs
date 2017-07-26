using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();

            Duck modelDuck = new ModelDuck();
            modelDuck.performQuack();
            modelDuck.performFly();
            modelDuck.setFlyBehavior(new FlyRocketPowered());
            modelDuck.performFly();


            Console.ReadLine();   
        }
    }
}
