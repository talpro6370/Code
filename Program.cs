using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Canvas_Project;
namespace Client
{
   public class Program
    {
        static void Main(string[] args)
        {
           
            if (MyCanvas.CreateNewButton(2, 5, 4, 3) == true)
            {
                Console.WriteLine("Button has been created");
            }
            else Console.WriteLine("try again");
            if (MyCanvas.CreateNewButton(3, 40,8, 3) == true)
            {
                Console.WriteLine("Button has been created");
            }
            else Console.WriteLine("try again");
            MyCanvas.Print();
            Console.WriteLine("AFTER THE MOVMENT:");
            if (MyCanvas.GetCurrentNumOfButtons() > 0)
                MyCanvas.MoveButton(0, 70, 45);
            MyCanvas.Print();
            int maxHeight = MyCanvas.GetTheMaxHeighthOfAButton();
            Console.WriteLine($"The maximum height is: {maxHeight}");
            Console.WriteLine("");
            if (MyCanvas.GetCurrentNumOfButtons() > 0)
                MyCanvas.DeleteLastButton();
            Console.WriteLine("After deleting the last btn:");
            MyCanvas.Print();
            Console.WriteLine("After clearing all buttons:");
            MyCanvas.ClearAllButtons();
            MyCanvas.Print();
            
           
        }

    }
}
