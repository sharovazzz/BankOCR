using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOCR.Lib
{
    public class FileParser
    {
        public List<Row> Load(string filePath)
        {
            List<Row> rows = new List<Row>();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден.");
                return rows;
            }

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length == 0)
            {
                Console.WriteLine("Файл пуст.");
                return rows;
            }

            for (int i = 0; i < lines.Length; i += 4)
            {
                Row row = ParseRow(lines[i], lines[i + 1], lines[i + 2]);
                rows.Add(row);
            }

            return rows;
        }

        private Row ParseRow(string line1, string line2, string line3)
        {
            List<int> digits = new List<int>();

            for (int i = 0; i < 27; i += 3)
            {
                string digit = line1.Substring(i, 3) + line2.Substring(i, 3) + line3.Substring(i, 3);
                int number = ParseDigit(digit);
                digits.Add(number);
            }

            return new Row(digits.ToArray());
        }

        private int ParseDigit(string digit)
        {
            switch (digit)
            {
                case " _ " +
                     "| |" +
                     "|_|": return 0;

                case "   " +
                     "  |" +
                     "  |": return 1;

                case " _ " +
                     " _|" +
                     "|_ ": return 2;

                case " _ " +
                     " _|" +
                     " _|": return 3;

                case "   " +
                     "|_|" +
                     "  |": return 4;

                case " _ " +
                     "|_ " +
                     " _|": return 5;

                case " _ " +
                     "|_ " +
                     "|_|": return 6;

                case " _ " +
                     "  |" +
                     "  |": return 7;

                case " _ " +
                     "|_|" +
                     "|_|": return 8;
                
                case " _ " +
                     "|_|" +
                     " _|": return 9;
                
                default:
                    Console.WriteLine("Некорректные данные.");
                    return -1;
            }
        }

    }
}
