using System;

namespace GeometryLibrary
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Triangle : IShape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }

        public bool IsRightAngleTriangle()
        {
            return Math.Pow(side1, 2) + Math.Pow(side2, 2) == Math.Pow(side3, 2) ||
                   Math.Pow(side2, 2) + Math.Pow(side3, 2) == Math.Pow(side1, 2) ||
                   Math.Pow(side3, 2) + Math.Pow(side1, 2) == Math.Pow(side2, 2);
        }
    }
}

//Чтобы добавить новую фигуру, достаточно создать новый класс, реализующий интерфейс IShape и определить метод CalculateArea().