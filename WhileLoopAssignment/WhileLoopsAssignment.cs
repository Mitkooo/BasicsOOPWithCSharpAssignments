namespace WhileLoopAssignment
{
    public class WhileLoopsAssignment
    {
        public static void Main(string[] args)
        {
            DisplayNumbersFrom10To1InReverse();
            PrintNumbersInBetween();
            PrintNumbersBetweenWithException();
            PrintNumbersFrom1To10ButStopAt5();
        }

        // 1. Write a program in C# to display the numbers from 10 to 1 in a reverse order.
        static void DisplayNumbersFrom10To1InReverse()
        {
            Console.WriteLine("Task 1");
            // Why having a check if a number is higher or lower than certain value
            // Тук съм забравил да го дооправя
            int number = 10;
            while (number >= 1)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine();
        }

        // 2. Write a program in C# to take from the console two numbers and then print out all the numbers between them.
        static void PrintNumbersInBetween()
        {
            Console.WriteLine("Task 2");
            Console.WriteLine("Enter first number: ");
            int num1 = ReadInteger();
            Console.WriteLine("Enter second number: ");
            int num2 = ReadInteger();
            int min = Math.Min(num1, num2);
            int max = Math.Max(num1, num2);
            while (min++ < max)
            {
                Console.WriteLine(min);
            }
            Console.WriteLine();
        }

        // 3.Write a program in C# to print all the numbers between 1 and 10 with the exception of 3 and 5
        static void PrintNumbersBetweenWithException()
        {
            Console.WriteLine("Task 3");
            int num1 = 1;
            int num2 = 10;

            while (num1 <= num2)
            {
                if (num1 == 3 || num1 == 5)
                {
                    num1++;
                    continue;
                }
                Console.WriteLine(num1);
                num1++;
            }
            Console.WriteLine();
        }

        // 4.Write a program in C# to start printing all the numbers between 1 and 10 but stop printing at 5. 
        static void PrintNumbersFrom1To10ButStopAt5()
        {
            Console.WriteLine("Task 4");
            int rowsPattern = 10;
            int rowCounter = 1;

            while (rowCounter <= rowsPattern)
            {
                int columnCounter = 1;

                while (columnCounter <= rowCounter)
                {
                    Console.Write(columnCounter);
                    columnCounter++;
                }

                if (columnCounter == 6)
                {
                    break;
                }

                Console.WriteLine();
                rowCounter++;
            }
            Console.WriteLine();
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
