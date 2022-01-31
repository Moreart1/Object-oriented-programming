using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LESSON_6._2
{
    class Circle: Point,IPrint
    {
        public double Radius { get; set; }
        public Point Center { get; set; } 

        public override void MovementHorizon(int x)
        {
            Center.X += x;
        }
        public override void MovementVertical(int y)
        {
            Center.Y += y;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override void Print()
        {
            Console.WriteLine($"Цвет: {Color},Состояние фигуры : {Status},Центр окружности {Center},Радиус окружности {Radius}");
        }
    }
}
