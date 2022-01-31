using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LESSON_6._2
{
    abstract class Figure
    {
        string color;
        string status;

        public abstract void MovementHorizon(int x);
        public abstract void MovementVertical(int y);

        public string Color
        {
            get
            {
                return color;
            }
            set 
            {
                color = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public abstract double Area();
    }

    interface IPrint
    {
        void Print();
    }

}
