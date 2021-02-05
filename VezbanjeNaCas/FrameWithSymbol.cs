using System;

namespace VezbanjeNaCas
{
    public class FrameWithSymbol : IFrameWithSymbol
    {
        public void SymbolFrameMaker(int rows, int columns, string symbol)
        {
            if (rows < 3 || columns < 3)
            {
                throw new InvalidProgramException("\nROWS AND COLUMNS MUST BE ABOVE 3 SO YOU CAN PUT SOMETHING INSIDE FRAME." + "\n");
            }

            for (int y = 0; y < rows; y++)
            {
                Console.WriteLine("");
                for (int x = 0; x < columns; x++)
                {
                    if (y > 0 && x > 0)
                    {
                        if (y < rows - 1 && x < columns - 1)
                            Console.Write(" ");
                        else
                            Console.Write(symbol);
                    }
                    else
                        Console.Write(symbol);
                }
            }
        }
    }
}
