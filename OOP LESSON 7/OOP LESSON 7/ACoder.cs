using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LESSON_7
{
    class ACoder:ICoder
    {       
        /// Защифровываем наш алфавит со сдвигом на 1 букву вперед     
        /// <param name="toEncode"></param>
        /// <returns></returns>     
        public string Encode(string toEncode)
        {
            var data = toEncode.AsSpan(); //Создаем новый диапазон строки и помещаем в переменную
            var sb = new StringBuilder(toEncode.Length); //длина строки
            foreach (var symbol in data)
            {
                sb.Append((char)(symbol + 1)); //добавляем  подстроку в переменную 
            }

            return sb.ToString();
        }
       
        /// Расшифровываем наш алфавит       
        /// <param name="toDecode"></param>
        /// <returns></returns>      
        public string Decode(string toDecode)
        {
            var data = toDecode.AsSpan();
            var sb = new StringBuilder(toDecode.Length);
            foreach (var symbol in data)
            {
                sb.Append((char)(symbol));
            }

            return sb.ToString();
        }
    }
}
