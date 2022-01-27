using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_5._1
{
   public class RationalNumbers
    {
        private int _numerator;

        private int _denominator;
        
        private const string zero = "0";
        public int Numerator
        {
            get { return _numerator; }
        }

        public int Denominator
        {
            get { return _denominator; }
        }


        public RationalNumbers(int numerator,int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен нулю");

            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }

            _numerator = numerator;
            _denominator = denominator;

            ReduceToLowestTerms();
        }

      

        public static bool operator ==(RationalNumbers r1,RationalNumbers r2)
        {
            return (r1._numerator == r2._numerator && r1._denominator == r2._denominator);
        }
        public static bool operator !=(RationalNumbers r1, RationalNumbers r2)
        {
            return (r1._numerator != r2._numerator && r1._denominator != r2._denominator);
        }

        public static bool operator >(RationalNumbers r1,RationalNumbers r2)
        {
            double number1 = (double)r1._numerator / (double)r1._denominator;
            double number2 = (double)r2._numerator / (double)r2._denominator;
            return (number1 > number2);
        }

        public static bool operator <(RationalNumbers r1, RationalNumbers r2)
        {
            double number1 = (double)r1._numerator / (double)r1._denominator;
            double number2 = (double)r2._numerator / (double)r2._denominator;
            return (number1 < number2);
        }

        public static bool operator >=(RationalNumbers r1, RationalNumbers r2)
        {
            double number1 = (double)r1._numerator / (double)r1._denominator;
            double number2 = (double)r2._numerator / (double)r2._denominator;
            return (number1 >= number2);
        }

        public static bool operator <=(RationalNumbers r1, RationalNumbers r2)
        {
            double number1 = (double)r1._numerator / (double)r1._denominator;
            double number2 = (double)r2._numerator / (double)r2._denominator;
            return (number1 <= number2);           
        }

        public static RationalNumbers operator +(RationalNumbers r1,RationalNumbers r2)
        {
          return new RationalNumbers((r1._numerator * r2._denominator)+ (r2._numerator * r1._denominator), r1._denominator * r2._denominator);        
        }      

        public static RationalNumbers operator -(RationalNumbers r1, RationalNumbers r2)
        {
            return new RationalNumbers((r1._numerator * r2._denominator) - (r2._numerator * r1._denominator), r1._denominator * r2._denominator);
        }

        public static RationalNumbers operator *(RationalNumbers r1, RationalNumbers r2)
        {
            return new RationalNumbers(r1._numerator * r2._numerator, r1._denominator * r2._denominator);
        }

        public static RationalNumbers operator /(RationalNumbers r1, RationalNumbers r2)
        {
            return new RationalNumbers(r1._numerator * r2._denominator, r1._denominator * r2._numerator);
        }
        public static RationalNumbers operator ++(RationalNumbers r1)
        {
            r1._numerator++;
            r1._denominator++;
            return r1;
        }
            
        public static RationalNumbers operator --(RationalNumbers r1)
        {
            r1._numerator--;
            r1._denominator--;
            return r1;
        }
        public static RationalNumbers operator %(RationalNumbers r1, RationalNumbers r2)
        {
            return new RationalNumbers((r1._numerator * r2._denominator) % (r1._denominator * r2._numerator), r1._denominator * r2._denominator);
        }

        public static explicit operator int(RationalNumbers r1)
        {
            return (int)r1._numerator;
        }


        public static explicit operator float(RationalNumbers r1)
        {
            return (float)r1._numerator;
        }

        public override string ToString()
        {
            if (_numerator != 0)
            {
                string str = $"{_numerator}/{_denominator}";
                return str;
            }
            else
            {
                return zero;
            }
        }

        private static int GetGCD(int term1, int term2)
        {
            if (term2 == 0)
                return term1;
            else
                return GetGCD(term2, term1 % term2);
        }

        private void ReduceToLowestTerms()
        {
            int greatestCommonDivisor = RationalNumbers.GetGCD(_numerator, _denominator);
            _numerator /= greatestCommonDivisor;
            _denominator /= greatestCommonDivisor;
        }
   
    }
}
