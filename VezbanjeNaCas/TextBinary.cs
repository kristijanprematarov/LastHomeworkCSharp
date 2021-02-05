using System;
using System.Collections.Generic;

namespace VezbanjeNaCas
{
    public class TextBinary : ITextBinary
    {
        public void TextToBinary(string stringText)
        {
            string[] wordsFromString = stringText.Split(" ");
            for (int i = 0; i < wordsFromString.Length; i++)
            {
                if (wordsFromString[i].ToLower() == "zero")
                    wordsFromString[i] = "0";
                else if (wordsFromString[i].ToLower() == "one")
                    wordsFromString[i] = "1";
            }

            List<string> wordsBinaryList = new List<string>();
            for (int i = 0; i < wordsFromString.Length; i++)
            {
                if (wordsFromString[i] == "0" || wordsFromString[i] == "1")
                {
                    wordsBinaryList.Add(wordsFromString[i]);
                }
            }

            wordsBinaryList.RemoveRange(8, wordsBinaryList.Count - 8);

            foreach (string item in wordsBinaryList)
            {
                Console.Write(item);
            }

        }
    }
}
