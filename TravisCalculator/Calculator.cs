using System;
using System.Collections.Generic;
using System.Text;

namespace TravisCalculator
{
    public class Calculator : BaseCalc
    {
        public int Aggregation { get; set; }
        public Calculator()
        {
            Aggregation = Add(3, 4);
        }
    }
}
