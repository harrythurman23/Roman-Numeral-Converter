using System;

namespace Roman_Numeral_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter your number to be converted: ");
            input = Console.ReadLine();
            int userint = Convert.ToInt32(input);

            string result = ConvertToRoman(userint);
            Console.WriteLine(input + " written in Roman Numberals is " + result);
            Console.ReadLine();
        }
        static string ConvertToRoman(int number)
        {
            string roman = "";
            while (number >= 100)
            {
                number = number - 100;
                roman = roman + "C";
            }
            if (number >= 90)
            {
                number = number - 90;
                roman = roman + "xc";
            }
            if (number >= 50)
            {
                number = number - 50;
                roman = roman + "l";
            }
            if (number >= 40)
            {
                number = number - 40;
                roman = roman + "xl";
            }
            while (number >= 10)
            {
                number = number - 10;
                roman = roman + "x";
            }
            if (number >= 9)
            {
                number = number - 9;
                roman = roman + "ix";
            }
            if (number >= 5)
            {
                number = number - 5;
                roman = roman + "v";
            }
            if (number >= 4)
            {
                number = number - 4;
                roman = roman + "iv";
            }
            while (number >= 1)
            {
                number = number - 1;
                roman = roman + "i";
            }
            return roman;
        }
    }
}
