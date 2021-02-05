using System;
using System.Collections.Generic;

namespace VezbanjeNaCas
{
    public class Censored : ICensored
    {
        public void CensorUncensor(string originalString)
        {
            string censored = originalString.Replace('a', '*').Replace('e', '*').Replace('i', '*').Replace('o', '*').Replace('u', '*');
            Console.WriteLine("The censored string: {0}", censored);

            List<char> vowelsFromString = new List<char>();
            foreach (char item in originalString)
            {
                if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                    vowelsFromString.Add(item);
            }

            char[] censoredArray = censored.ToCharArray();
            List<char> censoredList = new List<char>();
            censoredList.AddRange(censoredArray);

            for (int i = 0; i < censoredList.Count; i++)
            {
                if (censoredList[i].Equals('*'))
                {
                    censoredList[i] = vowelsFromString[0];
                    vowelsFromString.RemoveAt(0);
                }
            }

            Console.WriteLine("Back to the original string with vowels in order:");

            foreach (char item in censoredList)
            {
                Console.Write(item);
            }
        }
    }
}
