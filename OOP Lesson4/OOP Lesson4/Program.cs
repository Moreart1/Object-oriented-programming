using System;

namespace OOP_Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Crteator.CreateBuild(3, 14, 15); //Первая цифра сколько квартир на одном этаже,вторая цифра сколько этажей и третья цифра кол-во подъездов...
            Crteator.CreateBuild(4, 6, 11);
            Crteator.CreateBuild(3, 16, 25);
            Crteator.CreateBuild(4, 2, 2);
            Crteator.CreateBuild(4, 5,6 );

            Crteator.HashtablePrint();

            Console.WriteLine();

            Crteator.DeleteBuild(2);

            Crteator.HashtablePrint();
            

        }
    }
}
