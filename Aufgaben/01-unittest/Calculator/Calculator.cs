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
<<<<<<< HEAD

        public double Multiplikation(double faktor1, double faktor2) { 
            return faktor1 * faktor2; 
=======
        
        public double Multiply(double faktor_1, double faktor_2)
        {
            return faktor_1 * faktor_2;
        }

        public double Divide(double divisor_1, double divisor_2)
        {
            if (divisor_1 is 0 || divisor_2 is 0)
            {
                throw new ArgumentException();
            }

            return divisor_1 / divisor_2;
>>>>>>> cb5ed189f8dc581602651a4ecd28ac8fa8cebd50
        }
    }
}
