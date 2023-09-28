namespace DoWhileAssignment
{
    public class DoWhileAssignment
    {
        public static void Main(string[] args)
        {
            DisplayNumbersFrom10To1InReverse();
            DisplayFibonacciNumbers();
        }

        // 1. Write a program in C# to display the numbers from 10 to 1 in a reverse order.
        static void DisplayNumbersFrom10To1InReverse()
        {
            Console.WriteLine("Task 1");
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            }while(number >= 1);
        }

        // 2. Write a program in C# to display the first n  Fibonacci numbers. N should be input from the console.
        static void DisplayFibonacciNumbers()
        {
            Console.WriteLine("Task 2");
            Console.Write("Enter a number: ");
            int number = ReadInteger();

            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            int currentNumber = 0, nextNumber = 1;
            int count = 0;

            do
            {
                Console.Write(currentNumber + " ");
                int temp = currentNumber;
                currentNumber = nextNumber;
                nextNumber = temp + nextNumber;
                count++;
            } while (count < number);

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