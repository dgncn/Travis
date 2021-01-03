using System;
using System.Collections.Generic;
using System.Text;

namespace TravisCalculator
{
    public abstract class BaseCalc
    {
        public virtual int Add(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        public bool IsNegativeNumber(int number)
        {
            if (number < 0)
                return true;
            else
                return false;
        }
    }
}
