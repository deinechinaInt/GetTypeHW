using System;
using System.Globalization;

namespace GetTypeHW
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool success = false;
            while (!success)
            {
                Console.WriteLine("Input value:");
                var inputValue = Console.ReadLine();
                if (!string.IsNullOrEmpty(inputValue))
                {
                    success = true;                    
                    Console.WriteLine("Type is {0}", (ParseString(inputValue) ?? inputValue).GetType());
                    Console.ReadLine();
                }
            }
            
        }

        private static object ParseString(string str)
        {

            if (int.TryParse(str, NumberStyles.Integer, CultureInfo.InvariantCulture, out int intValue))
            {
                return intValue;
            }
            else if (double.TryParse(str, NumberStyles.Number, CultureInfo.InvariantCulture, out double doubleValue))
            {
                return doubleValue;
            }
            else if (char.TryParse(str, out char charValue))
            {
                return charValue;
            }
            else if (bool.TryParse(str, out bool boolValue))
            {
                return boolValue;
            }
            else if (DateTime.TryParse(str, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime))
            {
                return dateTime;
            }
            return null;
        }
    }
}
