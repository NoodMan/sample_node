using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demotest
{
    public class Calculator
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }
        public double Add(double numberOne, double numberTwo)
            {
                return numberOne + numberTwo;
            }

            public double Subtract(double numberOne, double numberTwo)
            {
                return numberOne - numberTwo;
            }

            public double Divide(double numberOne, double numberTwo)
            {
                if (numberTwo == 0)
                {
                    throw new DivideByZeroException();
                }
                return numberOne / numberTwo;
            }

            public double Multiply(double numberOne, double numberTwo)
            {
                return numberOne * numberTwo;
            }
    }

}
