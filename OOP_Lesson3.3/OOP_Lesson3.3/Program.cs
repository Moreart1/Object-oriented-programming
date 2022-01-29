using System;
using System.Collections.Generic;

namespace OOP_Lesson3._3
{
    class Program
    {
        static List<string> data = new List<string>();
        static void Main(string[] args)
        {
            string _data1 = new string("Кучма Андрей Витальевич & Kuchma@mail.ru");
            string _data2 = new string("Мизинцев Павел Николаевич & Pasha@mail.ru");
            string s = _data1;
            string s2 = _data2;
            data.Add(_data1);
            data.Add(_data2);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            SearchMail(ref s);
            SearchMail2(ref s2);
        }
        public static void SearchMail(ref string s)
        {
            string[] words = s.Split(new char[] { '&' });

            s = words[1].Remove(0, 1);

            Console.WriteLine(s);
        }
        public static void SearchMail2(ref string s2)
        {
            string[] words = s2.Split(new char[] { '&' });

            s2 = words[1].Remove(0, 1);

            Console.WriteLine(s2);
        }
    }
}
