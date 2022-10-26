using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public double Multiplikation(double faktor1, double faktor2) { 
            return faktor1 * faktor2; 
        }
    }
}
