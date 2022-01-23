using System;

namespace ShapeLib_MindBox
{
    public abstract class Shapes 
    {
        public abstract double GetArea();  
        public abstract void GetNameFigure();

    }
   
    
    public class Triangle : Shapes
    {
        private double FirstSide { get; set; }
        private double SecondSide { get; set; }
        private double ThirdSide { get; set; }

        public Triangle(double firstSide, double secondSide, double thirdSide) //: base ()
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public override double GetArea()
        {
            double P = (FirstSide + SecondSide + ThirdSide) / 2;
            double S = Math.Sqrt(P * (P - FirstSide) * (P - SecondSide) * (P - ThirdSide));
            return S;
        }

        public override void GetNameFigure()
        {
            if ((FirstSide * FirstSide + SecondSide * SecondSide == ThirdSide * ThirdSide)
               || (FirstSide * FirstSide + ThirdSide * ThirdSide == SecondSide * SecondSide)
               || (ThirdSide * ThirdSide + SecondSide * SecondSide == FirstSide * FirstSide))
                Console.WriteLine("Треугольник прямоугольный");
            else
                Console.WriteLine("Треугольник не прямоугольный");
        }
    }

    public class Circle : Shapes
    {
        private double Radius { get; set; }

        public Circle(double R)
        {
            Radius = R;
        }
        public override double GetArea()
        {
            double S = Math.PI * Math.Pow(Radius, 2);
            return S;
        }

        public override void GetNameFigure()
        {
            Console.WriteLine("Круг");
        }
    }
}
