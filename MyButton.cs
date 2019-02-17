using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas_Project
{
    internal class MyButton
    {
        protected Point topLeft;
        protected Point bottomRight;
        private int width;
        private int height;

        internal MyButton(Point topLeft, Point bottomRight)
        {
                
                this.bottomRight = bottomRight;
                SetTopLeft(topLeft);
                SetBottomRight(bottomRight);            
        }
        internal int GetWidth()
        {
            return this.width;
        }
        internal int getHeight()
        {
            return this.height;
        }
        internal bool SetTopLeft(Point topLeft)
        {
            //if (topLeft.GetX() - bottomRight.GetX() < 0 && bottomRight.GetY()-topLeft.GetY()<0) return false;
            if (topLeft.GetX() >this.bottomRight.GetX()|| (topLeft.GetY() < bottomRight.GetY())) return false;
            this.topLeft = topLeft;
            this.width = (bottomRight.GetX() - topLeft.GetX());
            this.height = (topLeft.GetY() - bottomRight.GetY());
            return true;
        }
        internal bool SetBottomRight(Point bottomRight)
        {
            if (topLeft == null) return false;
            if (bottomRight.GetX() < topLeft.GetX()|| bottomRight.GetY() > topLeft.GetY()) return false;
            this.bottomRight = bottomRight;
            this.width = (bottomRight.GetX() - topLeft.GetX());
            this.height = (topLeft.GetY() - bottomRight.GetY());
            return true;
        }
        internal Point GetTopLeft()
        {
            return this.topLeft;
        }
        internal Point GetBottomRight()
        {
            return this.bottomRight;
        }
        public override string ToString()
        {
            return $"\nWidth: {GetWidth()} \nHeight: {getHeight()} \nTop left is:\n{GetTopLeft()} \nBottom right is: \n{GetBottomRight()}";
        }
    }
}
