using System;
using System.Xml.Schema;

namespace Bin2Dec
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("Введите число в двоичной системе счисления, используя не более 8 симоволов:");
           string StrNumber = Console.ReadLine();
           double number = returnInt(StrNumber);
            Console.WriteLine($"Вы ввели число в двоичной системе: {StrNumber} . Это же число в десятичнной системе: {number}");
        }

        public static int returnInt(string strNumber)
        {

            var decimalNumber = 0;
            for (int index = strNumber.Length-1 ; index >= 0; index--)
            {
                string str = strNumber[index].ToString();
                int value = int.Parse(str);
                decimalNumber += value * (int)Math.Pow(2, strNumber.Length - 1 - index);
            }
            return decimalNumber;
        }


    }
}
