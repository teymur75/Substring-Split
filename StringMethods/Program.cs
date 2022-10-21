
using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Stringi Split metodu
            string sentence = "Teymur Reh,im.li  Vuqar";
            char[] vid = { ' ', '.', ',' };

            string[] list = sentence.Split(vid);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            #endregion


            #region Int arrayden 5e bolunenleri gosterme
            int[] arr = { 25, 35, 45, 66, 34, 15 };
            foreach (var item in arr)
            {
                if (item % 10 == 5)
                {
                    Console.WriteLine(item);
                }
            }

            #endregion



            #region Strin arrayden sonu r ile biten sozleri goster
            string word = "Teymur";
            var result = word.Substring(word.Length - 1, 1);
            Console.WriteLine(result);

            string[] Arr = { "teymur", "anar", "resul" };
            foreach (var item in Arr)
            {
                if (item.Substring(item.Length - 1, 1) == "r")
                {
                    Console.WriteLine(item);
                }
            }
            #endregion


            #region Substirng
            string words = "Teymur";
            var result1=words.Substring(5, 1);
            Console.WriteLine(result1);
            #endregion
        }
    }
}
