﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckExample1
{
    public class FlyNoWay:iFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly :( ");
        }
    }
}
