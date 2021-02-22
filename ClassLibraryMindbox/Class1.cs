using System;

namespace ClassLibraryMindbox
{
    public class Class1
    {
        public double AreaOfCircle (double R)
        {
            double S = Math.PI * Math.Pow(R, 2); 
            return S;
        }

        public double AreaOfTriangle(double L1, double L2, double L3)
        {
            double P = (L1 + L2 + L3) / 2;
            double S = Math.Sqrt(P * (P - L1) * (P - L2) * (P - L3));
            return S;
        }

    }
}
