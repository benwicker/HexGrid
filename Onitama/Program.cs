using System;

namespace Onitama
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new Grid();
            grid.PrintMap();

            // add pawn to center of board
            grid.Map[2, 2].Value = "P";

            Console.ReadLine();
        }
    }
}
