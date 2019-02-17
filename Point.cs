using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas_Project
{
   internal class Point
    {
        private int x;
        private int y;

        internal Point(int x, int y)//ctor
        {
            SetX(x);
            SetY(y);
        }

        internal int GetX()
        {
            return this.x;
        }
        internal int GetY()
        {
            return this.y;
        }
        internal void SetX(int x)
        {
            if (x < 0 && x > 800) Console.WriteLine("The number is out of limit!");
            this.x = x;
        }
        internal void SetY(int y)
        {
            if (y < 0 && y > 800) Console.WriteLine("The number is out of limit!");
            this.y = y;
        }
        public override string ToString()
        {
            return $"X={this.GetX()}\nY={this.GetY()}";
        }

    }
}
