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
            //tested locally with some sample value- works fine here
            string result = Converter.ConvertNumberToString(67474764);
        }
    }
}
