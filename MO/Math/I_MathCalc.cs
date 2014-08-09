using System;
namespace MO
{
    public interface I_MathCalc
    {
        double AddNumbers(double a, double b);
        double DateDifference(DateTime startDate, DateTime endDate);
        double SubtractNumbers(double a, double b);
        double SubtractNumbersAbs(double a, double b);
    }
}
