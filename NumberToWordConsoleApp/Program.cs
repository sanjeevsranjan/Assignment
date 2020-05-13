using NumberToWord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWordConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Please not that i am not handling input data type validation and the max length of input from user.
            //Assuming user will input only number 
           
            int input;
            Console.Write("Enter a value ");
            input = Convert.ToInt32(Console.ReadLine());
            string result = Converter.ConvertNumberToString(input);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
