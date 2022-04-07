using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proect
{
    class Trigonometric_Form : Numbers
    {
        public double R { get; set; }
        public double Angle { get; set; }
        public Tuple<double, double> Multiplication()
        { 
            Angle = Angle1 + Angle2; 
            while (Angle > 360) Angle -= 360; 
            R = R1 * R2; 
            return Tuple.Create(Angle, R); 
        }
        public Tuple<double, double> Division() 
        { 
            Angle = Angle1 - Angle2; 
            R = R1 / R2;
            return Tuple.Create(Angle, R); 
        }
        public Tuple<double, double> Power() 
        { 
            Angle = Angle1 * N; 
            while (Angle > 360) Angle -= 360; 
            R = Math.Pow(R1, N); 
            return Tuple.Create(Angle, R); 
        }
        public Tuple<double, double> Root()
        {
            Angle = Angle1 / N;
            while (Angle > 360) Angle -= 360;
            R = Math.Pow(R1, 1.0/N);
            return Tuple.Create(Angle, R);
        }

    }
}
