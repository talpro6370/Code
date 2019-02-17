using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas_Project
{
    public class MyCanvas
    {
        public const int MAXWIDTH= 800;
        public const int MAXHEIGHT= 600;
        private static int buttonIndex = 0;
        private static int MaxButtons = 3;
        private static MyButton[] button = new MyButton[MaxButtons]; 
        
        
        public static bool CreateNewButton(int x1, int x2, int y1, int y2)
        {
            
            if (button[buttonIndex]==null)
            {
                Point p1 = new Point(x1, y1);
                Point p2 = new Point(x2, y2);
                MyButton b = new MyButton(p1,p2);
                if (b.SetTopLeft(p1) == false && b.SetBottomRight(p2) == false)
                {
                    button[buttonIndex]=null;
                    return false;
                }
                button[buttonIndex] = b;
                buttonIndex++;
                return true;
            }
            
            return false;
        }
        public static bool MoveButton(int buttonNumber,int x, int y)
        {
            int newTopLeftX = button[buttonNumber].GetTopLeft().GetX() + x;
            int newTopLeftY= button[buttonNumber].GetTopLeft().GetY() + y;
            int newBottomRightX= button[buttonNumber].GetBottomRight().GetX() + x;
            int newBottomRightY = button[buttonNumber].GetBottomRight().GetY() + y;
            if (newBottomRightX - newTopLeftX <= MAXWIDTH && newTopLeftY - newBottomRightY <= MAXHEIGHT)
            {
                Point p1 = new Point(newTopLeftX, newTopLeftY); // New top left point -after the moving.
                Point p2 = new Point(newBottomRightX, newBottomRightY); // New bottom right point -after the moving.
                button[buttonNumber].SetTopLeft(p1);
                button[buttonNumber].SetBottomRight(p2);
                return true;
            }
            return false;
        }
        public static bool DeleteLastButton()
        {
            if(button[buttonIndex-1]==null)
            return false;
            else
            {
                button[buttonIndex-1] = null;
                buttonIndex--;
                return true;
            }
        }
        public static void ClearAllButtons()
        {
              bool g = CreateNewButton(2, 4, 5, 3);
            for(int i=0;i<button.Length;i++)
            {
                if(button[i]!=null)
                button[i] = null;
                buttonIndex = 0;
            }
        }
        public static int GetCurrentNumOfButtons()
        {
            return buttonIndex;
        }
        public static int GetMaxNumOfButtons()
        {
            return MaxButtons;
        }
        public static int GetTheMaxWidthOfAButton()
        {
            int max = 0;
            int firstNum = button[0].GetWidth();
            if (buttonIndex==0) return 0;
            for(int i=0;i<button.Length;i++)
            {
                max = button[i].GetWidth();
                if (firstNum < max) firstNum = max;
            }
            return firstNum;
        }
        public static int GetTheMaxHeighthOfAButton()
        {
            int max = 0;
            int firstNum = button[0].getHeight();
            if (buttonIndex == 0) return 0;
            for (int i = 0; i < buttonIndex; i++)
            {
                max = button[i].getHeight();
                if (firstNum < max) firstNum = max;
            }
            return firstNum;
        }
        public static bool IsPointInsideAButton(int x,int y)
        {
            return true;
        }
        public static bool CheckIfAnyButtonIsOverlapping()
        {
            return true;
        }
        public override string ToString()
        {
            return $"Max width= {MAXHEIGHT} \nMax height= {MAXHEIGHT} ";
        }
        public static void Print()
        {
            for (int i = 0; i < button.Length; i++)
            {
                if (button[i] == null) Console.WriteLine($"Button number {i+1}: This button is empty or deleted");
                else
                Console.WriteLine($"Button number {i+1}: {button[i]}");
            }
            
        }
    }
}
