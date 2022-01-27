using System;

namespace OOP_Lesson_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumbers rational1 = new(5, 7);
            RationalNumbers rational2 = new(11, 30);
            RationalNumbers rational3 = new(5, 15);
            RationalNumbers rational4 = new(5, 7);
            RationalNumbers rational5 = new(5, 2);
            RationalNumbers rational6 = new(6, 8);
            RationalNumbers rational7 = new(3, 5);
            RationalNumbers rational8 = new(6, 3);
            RationalNumbers rational9 = new(2, 4);
            
            
            Console.WriteLine("Проверяем равна/не равна ли первая дробь второй ");
            Console.Write(rational1 == rational4);
            Console.Write("\t");
            Console.WriteLine(rational1 != rational4 );

            Console.WriteLine("Проверяем какая дробь больше");
            Console.Write(rational1 > rational2);
            Console.Write("\t");
            Console.WriteLine(rational5 < rational6);

            Console.WriteLine("Сложение и вычитание дробей");
            Console.Write(rational1 + rational3);
            Console.Write("\t");
            Console.WriteLine(rational7 - rational2);

            Console.WriteLine("Умножение и деление дробей");
            Console.Write(rational3 * rational4);
            Console.Write("\t");
            Console.WriteLine(rational9 / rational8);


            Console.WriteLine("Инкремент и декремент дроби");
            Console.Write(rational1++);
            Console.Write("\t");
            Console.WriteLine(rational1--);

            Console.WriteLine("Сравнение через метод Equals");
            Console.WriteLine(rational1.Equals(rational2));

            Console.WriteLine("Переопределение через метод ToString");
            Console.WriteLine(rational1.ToString());

            Console.WriteLine("Перегрузка операторов преобразования типов");
            Console.Write((float)rational1);
            Console.Write("\t");
            Console.WriteLine((int)rational7);

            Console.WriteLine("Остаток от деления");
            Console.Write(rational1 % rational1);
            Console.Write("\t");
            Console.WriteLine(rational9 % rational8);


          ;
            
        }
    }
}
