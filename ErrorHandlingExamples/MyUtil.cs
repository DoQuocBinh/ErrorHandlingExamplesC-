using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandlingExamples
{
    class MyUtil
    {
        public static string InputACountryName()
        {
            string userInput = "";
            List<String> country = new List<string>();
            country.Add("Vietnam"); country.Add("Lao");
            Console.WriteLine("Enter a secrete country name:");
            userInput = Console.ReadLine();
            if (!country.Contains(userInput))
            {
                throw new NotValidCountryNameException("The country name is not in our secrete!");
            }
            return userInput;           
        }
        /// <summary>
        /// Throw FormatException when the number is not integer
        /// </summary> 
        /// <returns>An integer</returns>
        public static int UserInputToInt()
        {
            int number=0;
            try
            {
                Console.WriteLine("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException ex)
            {
                Console.WriteLine("FormatException in MyUtil class");
                throw ex;
            }
            return number;
            
        }

    }
}
