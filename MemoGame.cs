using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemGame
{
    class Class1
    {

        static void Main()
        {
            //-----------------  EPISODE 1  ----------------------
            int UserNum = 0;
            Console.WriteLine("Please enter an even number between 2-8:");
            do
            {
                UserNum = Convert.ToInt32(Console.ReadLine());
                if ((UserNum % 2 != 0 || UserNum < 0 || UserNum > 8)) Console.WriteLine("Please try again");

            } while (UserNum % 2 != 0 || UserNum < 0 || UserNum > 8);

            int[,] Mat = new int[UserNum, UserNum];
            int NumOfCards = Mat.Length, NumOfPairs = Mat.Length / 2;
            int Row=0, Column=0, Counter = 0;
            for (int i = 1; i <= NumOfPairs; i++)//i=first card-----
            {
                do
                {
                    Random rnd = new Random();
                    Row = rnd.Next(0, UserNum);
                    Column = rnd.Next(0, UserNum);
                }
                while (Mat[Row, Column] != 0);
                if (Mat[Row, Column] == 0)
                {
                    Mat[Row, Column] = i;
                }
          
                do
                {
                    Random rnd2 = new Random();
                    Row = rnd2.Next(0, UserNum);
                    Column = rnd2.Next(0, UserNum);
                }
                while (Mat[Row, Column] != 0);
                if (Mat[Row, Column] == 0)
                {
                    Mat[Row, Column] = i;
                }

            }

            //The cards placement works 100%.
            Console.WriteLine("This is the matrix:");
            Console.WriteLine();

            for (int j = 0; j < UserNum; j++)//Print the matrix:
            {
                for (int k = 0; k < UserNum; k++)
                {
                    Console.Write("   ");
                    if (Mat[j, k] < 10) Console.Write(" "); // Makes the marix much more organized.
                    Console.Write(Mat[j, k]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();

            //-----------------  EPISODE 2  ----------------------

            int UserNum_Row = 0, UserNum_Col = 0, UserNum_Row2 = 0, UserNum_Col2 = 0, User_Points = 0;
            int Value_Of_Second_card = 0, Value_Of_First_card = 0;
            Console.WriteLine("Please enter cell  No. of the first card: ||  (the numbers have to be between 0-4):");
            do
            {
                do
                {

                    do     //Flipping the first card:
                    {
                        Console.WriteLine("Lets flip the first card:");
                        Console.WriteLine("Enter the Row No.: ");
                        UserNum_Row = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Column No.: ");
                        UserNum_Col = Convert.ToInt32(Console.ReadLine());
                        if (UserNum_Row < 0 || UserNum_Row > 3 || UserNum_Col < 0 || UserNum_Col > UserNum) Console.WriteLine("Please try again:");

                    } while (UserNum_Row < 0 || UserNum_Row > 3 || UserNum_Col < 0 || UserNum_Col > UserNum);
                    Console.WriteLine($"The first card is: {Mat[UserNum_Row, UserNum_Col]}");
                    Value_Of_First_card = Mat[UserNum_Row, UserNum_Col];

                    Console.WriteLine("Please enter cell  No. of the second card: ||  (the numbers have to be between 0-4):");
                    do     //Flipping the second card:
                    {
                        Console.WriteLine("Enter the Row No.: ");
                        UserNum_Row2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Column No.: ");
                        UserNum_Col2 = Convert.ToInt32(Console.ReadLine());
                        if (UserNum_Row2 < 0 || UserNum_Row2 > 3 || UserNum_Col2 < 0 || UserNum_Col2 > UserNum) Console.WriteLine("Please try again:");

                    } while (UserNum_Row2 < 0 || UserNum_Row2 > 3 || UserNum_Col2 < 0 || UserNum_Col2 > UserNum);
                    Console.WriteLine($"The second card is: {Mat[UserNum_Row2, UserNum_Col2]}");
                    Value_Of_Second_card = Mat[UserNum_Row2, UserNum_Col2];

                } while (Value_Of_First_card != Value_Of_Second_card && (Value_Of_First_card !=0|| Value_Of_Second_card !=0 ));//Flip the cards untill we get same values
                                                                                                                             //Or the values equal to 0.

                if (Value_Of_First_card == Value_Of_Second_card)        //user gets points if the cards are equals.
                {
                    Console.WriteLine("Wow!!! One point for you.");
                    Console.WriteLine();
                    User_Points++;
                    Mat[UserNum_Row, UserNum_Col] = 0;
                    Mat[UserNum_Row2, UserNum_Col2] = 0;
                }
            } while (User_Points != 8);
        }

    }
}
