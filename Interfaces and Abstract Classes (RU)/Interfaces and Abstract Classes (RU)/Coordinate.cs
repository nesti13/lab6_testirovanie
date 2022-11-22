using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_and_Abstract_Classes__RU_
{
    public struct Coordinate
    {
        public int x;
        public int y;
        public int z;
        public Coordinate(int x, int y, int z)
        {
            if (x > 0){
                this.x = x; }
            else
            {
                this.x = 0;
            }
            if (y > 0)
            {
                this.y = y;
            }
            else
            {
                this.y = 0;
            }
            if (z > 0)
            {
                this.z = z;
            }
            else
            {
                this.z = 0;
            }
        }
        public void Print() => Console.WriteLine($"x: {x}  y: {y}");
    }
}
