using System;

namespace OOP_LESSON_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point();
            Point p3 = new Point();
            p3.X = 2; p3.Y = 3;
            Point p4 = new Point();
            p4.X = 1;p4.Y = 2;
            

            p1.X = 5; p1.Y = 3;
            p1.Color = "красный";p1.Status = "видимая";
            p2.X = 7; p2.Y = 5;
            p2.Color = "зеленый";p2.Status = "невидимая";
            p1.MovementHorizon(2);
            p1.MovementVertical(1);
            Console.WriteLine(p1.Area());
            p1.Print();
            Console.WriteLine();
            Console.WriteLine(p2.Area());
            p2.Print();
            Console.WriteLine();

            Circle c1 = new Circle();
            c1.Radius = 6;
            c1.Center = p2 ;
            c1.Color = "синий"; c1.Status = "видимый";         
            Console.WriteLine($"Площадь окружности равна : {c1.Area()}");
            c1.Print();
            Console.WriteLine();

            Rectangle r1 = new Rectangle();
            r1.LeftUpper = p1;           
            r1.RightUpper = p2;
            r1.LeftLower = p3;           
            r1.RightLower = p4;
            Console.WriteLine($"Площадь прямоугольника равна: {r1.Area()}") ;
            r1.Color = "синий"; r1.Status = "видимый";            
            r1.Print();

        }
    }
}
