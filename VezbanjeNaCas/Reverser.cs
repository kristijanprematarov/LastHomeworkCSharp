using System;
using System.Linq;

namespace VezbanjeNaCas
{
    public class Reverser : IReverser
    {
        public string ReverseAdd(int original)
        {
            if (original < 0)
                throw new InvalidProgramException("The number is a negative integer.");

            string reversed = new string(original.ToString().ToCharArray().Reverse().ToArray());

            return reversed + original;
        }
    }
}
