using System.ComponentModel;

namespace ForLoopAssignment
{
    public class ForLoopAssignment
    {
        public static void Main(string[] args) 
        {
            DisplayNumbersFrom10To1InReverse();
            DisplayNumbersInRightAngleTriangle();
            DisplaySameNumberInARowInRightAngleTriangle();
            DisplayNumberFrom1To10WithSpacesInRightAngleTriangle();
            DisplaySameNumbersInRowInAPyramid();
            DisplayDiamondLikePattern();
        }

        // 1. Write a program in C# to display the numbers from 10 to 1 in a reverse order.
        static void DisplayNumbersFrom10To1InReverse()
        {
            Console.WriteLine("Task 1");
            for(int num = 10; num > 0; num--)
            {
                Console.WriteLine(num);
            }
        }

        // 2. Write a program in C# to display the pattern like right angle triangle with a number.
        static void DisplayNumbersInRightAngleTriangle()
        {
            Console.WriteLine("Task 2");
            int rowCounter, columnCounter;
            int rowsPattern = 10;

            for (rowCounter = 1; rowCounter <= rowsPattern; rowCounter++)
            {
                // Here columnCounter variable is outside the For loop since it needs to be reset or it won't print number correctly
                for (columnCounter = 1; columnCounter <= rowCounter; columnCounter++)
                {
                    Console.Write(columnCounter);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 3. Write a program in C# to make such a pattern like right angle triangle with a number which will repeat a number in a row.
        static void DisplaySameNumberInARowInRightAngleTriangle()
        {
            Console.WriteLine("Task 3");
            int rowCounter, columnCounter;
            int rowsPattern = 4;

            for (rowCounter = 1; rowCounter <= rowsPattern; rowCounter++)
            {
                // Here columnCounter is inside For loop since I don't need to reset the value as in task 2
                for (columnCounter = 1; columnCounter <= rowCounter; columnCounter++)
                {
                    Console.Write(rowCounter);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 4. Write a program in C# to make such a pattern like right angle triangle with number increased by 1.
        // The pattern like:
        // 1
        // 2 3
        // 4 5 6
        // 7 8 9 10
        static void DisplayNumberFrom1To10WithSpacesInRightAngleTriangle()
        {
            Console.WriteLine("Task 4");
            int rowCounter, columnCounter;
            int rowsPattern = 5;
            int numInLine = 1;

            for (rowCounter = 1; rowCounter <= rowsPattern; rowCounter++)
            {
                for (columnCounter = 1; columnCounter < rowCounter; columnCounter++)
                {
                    Console.Write(numInLine + " ");
                    numInLine++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 5. Write a program in C# to make such a pattern like a pyramid with a number which will repeat the number in the same row. 
        //       1
        //      2 2
        //     3 3 3
        //    4 4 4 4 
        static void DisplaySameNumbersInRowInAPyramid()
        {
            Console.WriteLine("Task 5");
            int rowCounter, columnCounter, space;
            int rowPattern = 4;
            int requiredSpace = 7;

            for (rowCounter = 1; rowCounter <= rowPattern; rowCounter++)
            {
                for (space = 1; space < requiredSpace; space++)
                {
                    Console.Write(" ");
                }
                for (columnCounter = 1; columnCounter <= rowCounter; columnCounter++)
                {
                    Console.Write(rowCounter + " ");
                }
                requiredSpace--;
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 6. Write a program in C# to display the pattern like a diamond. ----- Оправи, не е правилно
        //      *
        //     *** 
        //    ***** 
        //   ******* 
        //  ********* 
        // *********** 
        //************* - 1st for loop ends
        // ***********
        //  ********* 
        //   ******* 
        //    ***** 
        //     *** 
        //      * 
        static void DisplayDiamondLikePattern()
        {
            Console.WriteLine("Task 6");
            int rowPattern = ReadInteger();
            int rowCounter, columnCounter, space;
            int requiredSpace = rowPattern + 1;

            for (rowCounter = 1; rowCounter <= rowPattern; rowCounter++)
            {
                for (space = 1; space < requiredSpace; space++)
                {
                    Console.Write(" ");
                }
                for (columnCounter = 1; columnCounter <= rowCounter; columnCounter++)
                {
                    Console.Write(" *");
                }

                requiredSpace--;
                Console.WriteLine();
            }

            requiredSpace = 1;

            for (rowCounter = rowPattern - 1; rowCounter >= 1; rowCounter--)
            {
                for (space = 4; space > requiredSpace; space--)
                {
                    Console.Write(" ");
                }
                for (columnCounter = 1; columnCounter <= rowCounter; columnCounter++)
                {
                    Console.Write("* ");
                }

                requiredSpace--;
                Console.WriteLine();
            }
        }

        static int ReadInteger()
        {
            return int.TryParse(Console.ReadLine(), out int number)
                ? number
                : IntegerErrorMessage("Input cannot be empty, string or a special character.");
        }

        static int IntegerErrorMessage(string message)
        {
            Console.WriteLine(message);
            return ReadInteger();
        }
    }

}