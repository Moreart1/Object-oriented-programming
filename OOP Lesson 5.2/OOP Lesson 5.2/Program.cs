using System;

namespace OOP_Lesson_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumbers complex1 = new(3, 0);
            ComplexNumbers complex2 = new(2, 3);
            ComplexNumbers complex3 = new(8, 4);
            ComplexNumbers complex4 = new(9, 6);
            ComplexNumbers complex5 = new(1, 5);

            Console.WriteLine(complex4);
            
            Console.WriteLine("Сравнение комплексных чисел");
            Console.WriteLine(complex4==complex1);
            Console.WriteLine(complex3 != complex1);
            Console.WriteLine("Сложение и вычитание комплексных чисел");
            Console.WriteLine(complex1 + complex5);
            Console.WriteLine(complex4 - complex3);
            Console.WriteLine("Умножение и деление комплексных чисел");
            Console.WriteLine(complex1 * complex2);
            Console.WriteLine(complex2 / complex1);
            
        }
    }
}
