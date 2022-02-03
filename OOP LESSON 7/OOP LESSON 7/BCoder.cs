using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LESSON_7
{
    class BCoder : ICoder
    {
        private static readonly int[] LowerCaseRange = { 'a', 'z' }; // массив нижнего регистра
        private static readonly int[] UpperCaseRange = { 'A', 'Z' }; // массив верхнего регистра

        private static bool IsLowerCase(char symbol) => symbol >= LowerCaseRange[0] && symbol <= LowerCaseRange[1];

        private static bool IsUpperCase(char symbol) => symbol >= UpperCaseRange[0] && symbol <= UpperCaseRange[1];

        /// <summary>
        /// Зашифровываем наш алфавит выполняя замену каждой буквы, стоящей в алфавите на i-й позиции, на букву того же регистра, расположенную в алфавите на i-й позиции с конца алфавита.
        /// </summary>
        /// <param name="toEncode"></param>
        /// <returns></returns>
        public string Encode(string toEncode)
        {
            var data = toEncode.AsSpan();
            var sb = new StringBuilder(toEncode.Length);

            foreach (var symbol in data)
            {
                if (IsLowerCase(symbol))
                {
                    var rangeFromStart = symbol - LowerCaseRange[0];
                    if (rangeFromStart == 0)
                    {
                        sb.Append((char)LowerCaseRange[1]);
                        continue;
                    }
                    sb.Append((char)(LowerCaseRange[1] - rangeFromStart));
                    continue;
                }


                if (IsUpperCase(symbol))
                {
                    var rangeFromStart = symbol - UpperCaseRange[0];
                    if (rangeFromStart == 0)
                    {
                        sb.Append((char)UpperCaseRange[1]);
                        continue;
                    }
                    sb.Append((char)(UpperCaseRange[1] - rangeFromStart));
                }
            }

            return sb.ToString();
        }

       /// <summary>
       /// Зашифровываем наш алфавит
       /// </summary>
       /// <param name="toDecode"></param>
       /// <returns></returns>
        public string Decode(string toDecode)
        {
            var data = toDecode.AsSpan();
            var sb = new StringBuilder(toDecode.Length);

            foreach (var symbol in data)
            {
                if (IsLowerCase(symbol))
                {
                    var rangeFromEnd = LowerCaseRange[1] - symbol;
                    if (rangeFromEnd == 0)
                    {
                        sb.Append((char)LowerCaseRange[0]);
                        continue;
                    }
                    sb.Append((char)(LowerCaseRange[0] + rangeFromEnd));
                    continue;
                }

                if (IsUpperCase(symbol))
                {
                    var rangeFromEnd = UpperCaseRange[1] - symbol;
                    if (rangeFromEnd == 0)
                    {
                        sb.Append((char)UpperCaseRange[0]);
                        continue;
                    }
                    sb.Append((char)(UpperCaseRange[0] + rangeFromEnd));
                }
            }

            return sb.ToString();
        }

    }
}
