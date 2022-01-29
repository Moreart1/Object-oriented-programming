using System;

namespace OOP_Lesson4
{
    class Program
    {
        static void Main(string[] args)
        { 
            Building building = new();
            building.AddTest(4, 8, 7, 5);

            Building building2 = new();
            building2.Add(3, 4, 5);
            
            Building building3 = new();
            building3.Add(4, 6, 8);


            building.Print();
            building2.Print();
            building3.Print();
            
        }
    }
}
