using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_5._2
{
  public  class ComplexNumbers
    {
        private double _materialPart;

        private double _imaginaryPart;

        public ComplexNumbers(double x, double bi)
        {
            _materialPart = x;
            _imaginaryPart = bi;
        }
        public static bool operator ==(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            if (cn1._materialPart == cn2._materialPart && cn1._imaginaryPart == cn2._imaginaryPart)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            return cn1._materialPart != cn2._materialPart && cn1._imaginaryPart != cn2._imaginaryPart;
        }

        public static ComplexNumbers operator +(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            ComplexNumbers cn3 = new(cn1._materialPart + cn2._materialPart, cn1._imaginaryPart + cn2._imaginaryPart);

            return cn3;
        }

        public static ComplexNumbers operator -(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            ComplexNumbers cn3 = new(cn1._materialPart - cn2._materialPart, cn1._imaginaryPart - cn2._imaginaryPart);

            return cn3;
        }

        public static ComplexNumbers operator *(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            ComplexNumbers cn3 = new(
                (cn1._materialPart * cn2._materialPart - cn1._imaginaryPart * cn2._imaginaryPart),+
                (cn1._materialPart * cn2._imaginaryPart + cn1._imaginaryPart * cn2._materialPart));

            return cn3;
        }

        public static ComplexNumbers operator /(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            ComplexNumbers cn3 = new(
                (cn1._materialPart * cn2._materialPart + cn1._imaginaryPart * cn2._imaginaryPart)
                / (cn2._materialPart * cn2._materialPart + cn2._imaginaryPart * cn2._imaginaryPart),
                (cn1._imaginaryPart * cn2._materialPart - cn1._materialPart * cn2._imaginaryPart)
                / (cn2._materialPart * cn2._materialPart + cn2._imaginaryPart * cn2._imaginaryPart));

            return cn3;
        }
        public override string ToString()
        {
            if (_materialPart != 0 && _imaginaryPart != 0)
            {
                return $" {_materialPart}+{_imaginaryPart}i ";
            }
            if (_materialPart != 0)
            {
                return $" {_imaginaryPart}i ";
            }
            return $" {_materialPart}";
        }
    }
}
