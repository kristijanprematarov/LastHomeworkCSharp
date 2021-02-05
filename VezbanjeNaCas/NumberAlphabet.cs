using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VezbanjeNaCas
{
    public class NumberAlphabet : INumberAlphabet
    {
        public void AlphabetToNumber(string aString)
        {
            StringBuilder stringCharsToNumbers = new StringBuilder(aString.ToLower());
            stringCharsToNumbers.Replace("a", "1 ");
            stringCharsToNumbers.Replace("b", "2 ");
            stringCharsToNumbers.Replace("c", "3 ");
            stringCharsToNumbers.Replace("d", "4 ");
            stringCharsToNumbers.Replace("e", "5 ");
            stringCharsToNumbers.Replace("f", "6 ");
            stringCharsToNumbers.Replace("g", "7 ");
            stringCharsToNumbers.Replace("h", "8 ");
            stringCharsToNumbers.Replace("i", "9 ");
            stringCharsToNumbers.Replace("j", "10 ");
            stringCharsToNumbers.Replace("k", "11 ");
            stringCharsToNumbers.Replace("l", "12 ");
            stringCharsToNumbers.Replace("m", "13 ");
            stringCharsToNumbers.Replace("n", "14 ");
            stringCharsToNumbers.Replace("o", "15 ");
            stringCharsToNumbers.Replace("p", "16 ");
            stringCharsToNumbers.Replace("q", "17 ");
            stringCharsToNumbers.Replace("r", "18 ");
            stringCharsToNumbers.Replace("s", "19 ");
            stringCharsToNumbers.Replace("t", "20 ");
            stringCharsToNumbers.Replace("u", "21 ");
            stringCharsToNumbers.Replace("v", "22 ");
            stringCharsToNumbers.Replace("w", "23 ");
            stringCharsToNumbers.Replace("x", "24 ");
            stringCharsToNumbers.Replace("y", "25 ");
            stringCharsToNumbers.Replace("z", "26 ");

            Console.WriteLine(stringCharsToNumbers);
        }
    }
}
