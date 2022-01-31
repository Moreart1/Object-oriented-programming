using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LESSON_6._2
{
    class Point : Figure, IPrint
    {
        
        public double X { get; set; }
        public double Y { get; set; }
        public override void MovementHorizon(int x)
        {
            X += x;
        }
        public override void MovementVertical(int y)
        {
            Y += y;
        }
        public override double Area()
        {
            return 0;
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        public virtual void Print()
        {
            Console.WriteLine($"Цвет фигуры : {Color}, Состояние фигуры : {Status}, Координаты точки X:{X},Координаты точки Y: {Y}");
        }
    }
}
