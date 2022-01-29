using System;

namespace OOP_Lesson_3._2
{
    class Program
    {
        static string Rev(string str)
        {

            char[] reverse = str.ToCharArray();

            Array.Reverse(reverse);

            return new string(reverse);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");

            string line = Console.ReadLine();

            line = Rev(line);

            Console.WriteLine(line);
        }
    }
    }

