using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class SnakeLadderGame
    {
        public static void GameSnakeLadder()
        {
            int Position = 0;
            const int Ladder = 1, Snake = 2;


            Random random = new Random();
            for (Position = 0; Position < 100; Position++)
            {

                int dieNum = random.Next(1, 7);
                Console.Write(" Player die Number " + dieNum);


                int option = random.Next(0, 3);
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        break;
                    case Ladder:
                        break;
                    case Snake:
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }

        }
    }
}
