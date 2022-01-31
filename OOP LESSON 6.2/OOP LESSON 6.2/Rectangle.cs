using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LESSON_6._2
{
    class Rectangle:Point,IPrint
    {
        public double Width { get { return Math.Abs(RightUpper.X - LeftLower.X); } }
        public double Height { get { return Math.Abs(RightUpper.Y - LeftLower.Y); } }

        public Point RightUpper { get; set;}
        public Point RightLower { get; set;}
        public Point LeftUpper { get; set;}
        public Point LeftLower { get; set;}

        public override void MovementHorizon(int x)
        {
            RightUpper.X += x;
            RightLower.X += x;
            LeftLower.X += x;
            LeftUpper.X += x;
        }

        public override void MovementVertical(int y)
        {
            RightUpper.Y += y;
            RightLower.Y += y;
            LeftLower.Y += y;
            LeftUpper.Y += y;
        }
        public override double Area()
        {
            return Width * Height;
        }
        public override void Print()
        {
            Console.WriteLine($"Цвет: {Color}, Состояние:{Status},Высота {Height},Длина:{Width}");
            Console.WriteLine($"Координаты прямоугольника :Левый верхний угол: {LeftUpper},Правый верхний угол {RightUpper},Левый нижний угол {LeftLower},Правый нижний угол {RightLower}");
        }

    }
}
