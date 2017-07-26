using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckExample1
{
    public abstract class Duck
    {
        internal iFlyBehavior _flyBehavior;
        internal iQuackBehavior _quackBehavior;
            
        public void swim()
        {
            Console.WriteLine("I am swimming!");
        }
        
        public void display()
        {
            Console.WriteLine("Look at this beautiful duck!");
        }

        public void performFly()
        {
            _flyBehavior.fly();
        }

        public void performQuack()
        {
            _quackBehavior.quack();
        }

        public void setFlyBehavior(iFlyBehavior flyBehavior)
        {
            this._flyBehavior = flyBehavior;
        }

        public void setQuackBehavior(iQuackBehavior quackBehavior)
        {
            this._quackBehavior = quackBehavior;
        }

        public Duck() { }
    }
}
