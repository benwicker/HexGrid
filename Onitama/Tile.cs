using System;

namespace Onitama
{
    public class Tile {
        public Tile(int x, int y)
        {
            Pos = new Point(x, y);
            Value = "0";
        }

        public Point Pos { get; set; }
        public string Value { get; set; } = "0";

        public void Print() {
            // Console.Write($"({X}, {Y})");
            Console.Write(Value);
        }
    }
}