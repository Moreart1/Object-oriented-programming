using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson4
{
   public class Building
    {
        /// <summary>
        ///  Номер здания
        /// </summary>
        public int _id_Building { get; set;}


        /// <summary>
        /// высота 
        /// </summary>
        public float _height { get; set; }


        /// <summary>
        /// этаж
        /// </summary>
        public int _floor { get; set; }


        /// <summary>
        /// Колличество квартир
        /// </summary>
        public int _flat { get; set; }

        /// <summary>
        /// Колличество подъездов
        /// </summary>
        public int _entrance { get; set; }

        public int apartments_on_the_floor { get; set;}

        public void Print()
        {

            Console.WriteLine($"Уникальный номер здания: {_id_Building}; высота здания: {_height}; этажность: {_floor}; количество квартир: {_flat}; количество подъездов: {_entrance};");
        }

        
    }
}
