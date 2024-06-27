﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_2
{
    abstract class Sum {

        public abstract int SumOfTwo(int a, int b);
        public abstract int SumOfThree(int a, int b,int c);
    }

    internal class Calculate : Sum
    {
        public int a, b, c;

        public override int SumOfTwo(int a, int b) { return (a + b); }
        public override int SumOfThree(int a, int b, int c) { return a + b + c; }
         
    }
}
