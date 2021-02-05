using System;
using System.Collections.Generic;

namespace VezbanjeNaCas
{
    public class Wrapper : IWrapper
    {
        public void WrapString(string theString, int scanner)
        {
            int indexOfString;
            int begin = 0;
            List<char> letters = new List<char>();
            if (scanner < 0)
            {
                scanner *= (-1);
                indexOfString = theString.Length - 1;
                while (begin < scanner)
                {
                    if (indexOfString < 0)
                        indexOfString = theString.Length - 1;

                    letters.Add(theString[indexOfString]);
                    if (letters.Count > theString.Length)
                        letters.RemoveRange(0, letters.Count - theString.Length);

                    indexOfString--;
                    begin++;
                }
                letters.Reverse();

                foreach (var item in letters)
                    Console.Write(item);
                string theSubstring2 = theString.Substring(0, theString.Length - letters.Count);
                Console.Write(theSubstring2);
            }
            else
            {
                indexOfString = 0;
                while (begin < scanner)
                {
                    if (indexOfString == theString.Length)
                        indexOfString = 0;

                    letters.Add(theString[indexOfString]);
                    if (letters.Count > theString.Length)
                        letters.RemoveRange(0, letters.Count - theString.Length);

                    indexOfString++;
                    begin++;
                }
                if (scanner < theString.Length)
                {
                    string theSubstring = theString.Substring(letters.Count, theString.Length - letters.Count);
                    Console.Write(theSubstring);
                }
                foreach (var item in letters)
                    Console.Write(item);
            }



        }
    }
}
