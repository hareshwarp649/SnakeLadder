using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class SnakeGame
    {
        public static void GameSnake()
        {
            int Position = 0;

            Random random = new Random();
            for (Position = 0; Position < 100; Position++)
            {

                int dieNum = random.Next(1, 7);
                Console.Write(" Player die Number " + dieNum);

                int option = random.Next(0, 3);
                if (option == 1)
                {
                    Position = Position + dieNum;
                    if (Position > 100)
                    {
                        Position = Position - dieNum;
                        Console.WriteLine("  | Option  Ladder : +" + dieNum + " |  Position : " + Position);
                    }
                    else
                    {
                        Console.WriteLine("  | Option Ladder : +" + dieNum + "  |  Player Position : " + Position);
                    }
                }
                else if (option == 2)
                {

                    if (Position < dieNum)
                    {
                        Position = 0;
                    }
                    else
                    {
                        Position = Position - dieNum;
                    }
                    Console.WriteLine("  Option Snake  : -" + dieNum + "  |  Player Position : " + Position);
                }
                else
                {
                    Console.WriteLine("   Option : No Play");
                }

                if (Position >= 100)
                {
                    Console.WriteLine(" Winning position reached..");
                }
            }
        }
    }
}
