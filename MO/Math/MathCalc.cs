using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;

namespace MO
{
    public class MathCalc : MO.I_MathCalc
    {

        public double AddNumbers(double a, double b) {
            return a + b;
        }

        public double SubtractNumbers(double a, double b)
        {
            return a - b;
        }

        public double SubtractNumbersAbs(double a, double b)
        {
            return Math.Abs(a - b);
        }

        public double DateDifference(DateTime startDate, DateTime endDate)
        {
            var DiffDate = Math.Abs((startDate - endDate).TotalDays);
            return DiffDate;

        }


    }
}
