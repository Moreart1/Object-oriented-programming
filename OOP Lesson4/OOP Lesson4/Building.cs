using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson4
{
    class Building
    {
        /// <summary>
        ///  Номер здания
        /// </summary>
      private  int _id_Building;


        /// <summary>
        /// высота 
        /// </summary>
      private  float _height;


        /// <summary>
        /// этаж
        /// </summary>
      private  int _floor;


        /// <summary>
        /// Колличество квартир
        /// </summary>
      private  int _flat;

        /// <summary>
        /// Колличество подъездов
        /// </summary>
      private  int _entrance;

        static int counter = 1; //счетчик

        public void AddTest(float height,int floor,int flat,int entrance)
        {
            _id_Building = CounterPlus(counter);
            _height = height;
            _floor = floor;
            _flat = flat;
            _entrance = entrance;

        }
        public void Add(int apartments_on_the_floor, int floor,int entrance)
        {
            _id_Building = counter++;
            _floor = floor;
            _entrance = entrance;
            _flat = apartments_on_the_floor * _floor * _entrance; //Вычисление колличества квартир во всем доме
            BuildingHeight(_floor);
        }

        /// <summary>
        /// Высота одного этажа
        /// </summary>
        /// <param name="floor"></param>
        public void BuildingHeight(int floor)
        {
            _floor = floor;
            _height = (floor * 3); //высота одного этажа
        }
        public void Print()
        {

            Console.WriteLine($"Уникальный номер здания: {_id_Building}; высота здания: {_height}; этажность: {_floor}; количество квартир: {_flat}; количество подъездов: {_entrance};");
        }

        /// <summary>
        /// Счетчик номера здания
        /// </summary>
        /// <param name="counter"></param>
        /// <returns></returns>
        public int CounterPlus(int counter)
        {
            return counter++;
        }
    }
}
