using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOCR.Lib
{
    public class Row
    {
        public int[] Digits { get; }

        public Row(int[] digits)
        {
            Digits = digits;
        }
        public override string ToString()
        {
            return string.Join("", Digits);
        }
    }
}
