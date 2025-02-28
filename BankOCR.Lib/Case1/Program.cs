using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOCR.Lib
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileParser = new FileParser();
            var result = fileParser.Load("D:\\BankOCR\\BankOCR.Lib\\Case1\\2Row.txt");

            foreach (var row in result)
            {
                Console.WriteLine(row);
            }
        }
    }
}
