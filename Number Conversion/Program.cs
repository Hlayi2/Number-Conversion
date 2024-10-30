using System;                
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Conversion      
{
    public class NumberToWordsConverter    
    {
        /// <summary>
        /// Declares a method that takes an integer and returns it as words.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string ConvertToWords(int number)   
        {
            // Arrays for word representations
            string[] ones = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                         "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
           
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            

            if (number == 0) return "Zero";    

            if (number < 20)                   
                return ones[number - 1];

            // Checks if the number is between 20 and 99.
            if (number < 100)                 
                return tens[number / 10] + (number % 10 > 0 ? "-" + ones[number % 10 - 1] : "");


            // Checks if the number is between 100 and 9999
            if (number < 1000)                 
                return ones[number / 100 - 1] + " Hundred" + (number % 100 > 0 ? " " + ConvertToWords(number % 100) : "");
            
            return ones[number / 1000 - 1] + " Thousand" + (number % 1000 > 0 ? " " + ConvertToWords(number % 1000) : "");

        }

        // Main method: program execution starts here.
        
        static void Main(string[] args)        
        {
            while (true)                       
            {
                Console.Write("\nPlease enter a number (0-9999) or press Enter to exit: ");
               

                string input = Console.ReadLine();   

                if (string.IsNullOrEmpty(input)) break;
                

                if (int.TryParse(input, out int number))  
                {
                    // Checks if the number is within the valid range (0-9999).
                    if (number >= 0 && number <= 9999)    
                        Console.WriteLine(ConvertToWords(number));    
                    else
                        Console.WriteLine("The numbers should not Exceed 4 digits. Please enter a number between 0 and 9999");
                    
                }
                else
                    Console.WriteLine("Invalid input");    
            }
        }
    }
}
