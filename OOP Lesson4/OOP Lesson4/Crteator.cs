using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace OOP_Lesson4
{
    public class Crteator : Building
    {
        static int counter = 1;

        static Hashtable hashtable = new Hashtable();
        static ICollection key = hashtable.Keys;
      
        private Crteator()
        {

        }
        public static void CreateBuild(int Apartments_on_the_floor, int Floor, int Entrance)
        {
            Building building = new Building();
            building.apartments_on_the_floor = Apartments_on_the_floor;
            building._floor = Floor;
            building._entrance = Entrance;
            building._flat = Apartments_on_the_floor * Floor * Entrance;
            building._height = (Floor * 3);

            hashtable.Add(counter++, building);
        }

        public static void HashtablePrint()
        {
            foreach (var id in key)
            {
                var i = (Building)hashtable[id];

                Console.WriteLine($"Уникальный номер здания: {id} ; высота здания: {i._height}; этажность: {i._floor}; количество квартир: {i._flat}; количество подъездов: {i._entrance};");
            }
        }
        public static void DeleteBuild(int number)
        {
            for (int id = 0; id < hashtable.Keys.Count; id++)
            {
                if (id == number)
                {
                    hashtable.Remove(id);
                    break;
                }
            }
        }
    }
}
