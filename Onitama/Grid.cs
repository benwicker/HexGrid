using System;

namespace Onitama
{
    public class Grid {
        public Grid()
        {
            Map = new Tile[5,5];
            for (var i = 0; i < 5; i++) {
                for (var j = 0; j < 5; j++) {
                    Map[i, j] = new Tile(i, j);
                }
            }
        }

        public Tile[,] Map { get; set; }

        public void PrintMap() {
            Console.Clear();
            for (var y = 0; y < 5; y++) {
                for (var x = 0; x < 5; x++) {
                    Map[x, y].Print();
                    Console.Write(" ");
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}