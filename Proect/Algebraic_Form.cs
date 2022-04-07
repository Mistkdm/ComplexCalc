using System;

namespace Proect
{
    class Algebraic_Form : Numbers
    {
        public double A { get; set; }
        public double B { get; set; }
        public Tuple<double, double> Addition()
        {
            A = A1 + A2; B = B1 + B2;
            return Tuple.Create(A, B);
        }
        public Tuple<double, double> Substruction()
        {
            A = A1 - A2;
            B = B1 - B2;
            return Tuple.Create(A, B);
        }
        public Tuple<double, double> Multiplication()
        { 
            A = A1 * A2 - (B1 * B2); 
            B = B1 * A2 + B2 * A1; 
            return Tuple.Create(A, B); 
        }
        public Tuple<double, double> Division() 
        { 
            A = Math.Round((A1 * A2 + B1 * B2) / (A2 * A2 * B2 * B2), 2); 
            B = Math.Round((B1 * A2 - A1 * B2) / (A2 * A2 * B2 * B2), 2); 
            return Tuple.Create(A, B); 
        }
    }
}
