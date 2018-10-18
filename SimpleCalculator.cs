using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleClalculator
{
    class SimpleCalculator
    {
        private double a;
        private double b;

        private void setAB()
        {
            Console.Write("Set A: ");
            this.a = double.Parse(Console.ReadLine());
            Console.Write("Set B: ");
            this.b = double.Parse(Console.ReadLine());
        }


        public double addition()
        {
            this.setAB();
            return (a + b);
        }

        public double subtraction()
        {
            this.setAB();
            return (a - b);
        }

        public double multiplication()
        {
            this.setAB();
            return (a * b);
        }

        public double division()
        {
            this.setAB();
            return (a/b);
        }
    }
}
