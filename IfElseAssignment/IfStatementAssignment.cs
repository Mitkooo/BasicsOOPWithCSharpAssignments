namespace IfElseAssignment
{
    public class IfStatementAssignment
    {
        public static void Main(string[] args)
        {
            PositiveOrNegative();
            GreatestOfThreeNumbers();
            PrintNumberDescription();
            WeekDays();
        }

        // 1. Write a C# program to get a number from the user and print whether it is positive or negative.
        static void PositiveOrNegative()
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter a positive or a negative number");
            int number = ReadInteger();
            Console.WriteLine($"First number:{number}");
            if (number >= 0)
            {
                Console.WriteLine("Number is positive \n");
            }
            else
            {
                Console.WriteLine("Number is negative \n");
            }
        }

        // 2. Take three numbers from the user and print the greatest number.
        static void GreatestOfThreeNumbers()
        {
            Console.WriteLine("Task 2");
            Console.WriteLine("Enter three numbers");
            int firstNumber = ReadInteger();
            Console.WriteLine($"First number:{firstNumber}");
            int secondNumber = ReadInteger();
            Console.WriteLine($"Second number:{secondNumber}");
            int thirdNumber = ReadInteger();
            Console.WriteLine($"Third number:{thirdNumber}");

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine($"The greatest: {firstNumber} \n");
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine($"The greatest: {secondNumber} \n");
            }
            else
            {
                Console.WriteLine($"The greatest: {thirdNumber} \n");
            }
        }

        // 3. Write a C# program that reads a floating-point number and prints "zero" if the number is zero.
        // Otherwise, print "positive" or "negative". Add "small" if the absolute value of the number is less than 1,
        // or "large" if it exceeds 1,000,000. 
        static void PrintNumberDescription()
        {
            Console.WriteLine("Task 3");
            Console.WriteLine("Enter a number");
            double number = ReadDouble();
            Console.WriteLine($"You entered:{number}");
            if (number > 0)
            {
                Console.WriteLine("Positive number \n");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative number \n");
            }
            else
            {
                Console.WriteLine("Zero \n");
            }

            if (Math.Abs(number) < 1)
            {
                Console.WriteLine("Small \n");
            }
            else if (Math.Abs(number) > 1000000)
            {
                Console.WriteLine("Large \n");
            }

        }

        // 4. Write a C# program that keeps a number from the user and generates an integer between 1 and 7 and displays the name of the weekday.
        // Print "weekend" if the day is part of the weekend or "workday" if otherwise.
        static void WeekDays()
        {
            Console.WriteLine("Enter minimum accepted value.");
            int minValue = ReadInteger();
            Console.WriteLine("Enter maximum accepted value.");
            int maxValue = ReadInteger();
            Console.WriteLine("Task 4");
            int number;
            Console.WriteLine("Enter a number between 1 and 7");
            number = ReadIntegerInRange(minValue, maxValue);
            Console.WriteLine($"You entered:{number}");


            if (number == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (number == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (number == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (number == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (number == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (number == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (number == 7)
            {
                Console.WriteLine("Sunday");
            }

            if (number == 6 || number == 7)
            {
                Console.WriteLine("Weekend");
            }
            else
            {
                Console.WriteLine("Workday");
            }
        }


        // Methods that read Integer/Double/Integer that is between 1 and 7
        // They check if entered value is valid and returns it or empty/not in correct range
        static double ReadDouble()
        {
            return double.TryParse(Console.ReadLine(), out double number)
                ? number
                : DoubleErrorMessage("Input cannot be empty or string.");
        }

        static int ReadInteger()
        {
            return int.TryParse(Console.ReadLine(), out int number)
                ? number
                : IntegerErrorMessage("Input cannot be empty or string.");
        }

        static int ReadIntegerInRange(int minValue, int maxValue)
        {
            return int.TryParse(Console.ReadLine(), out int number)
                ? (number >= minValue && number <= maxValue)
                   ? number
                   : IntegerInRangeErrorMessage("Input must be a number between 1 and 7.", minValue, maxValue)
                : IntegerInRangeErrorMessage("Input cannot be empty or string.", minValue, maxValue);
        }



        // Methods that return message for Int/Double
        // Made those because if I use Console.WriteLine(message); in Read* methods it tells me I can't convert void to int/double
        static int IntegerErrorMessage(string message)
        {
            Console.WriteLine(message);
            return ReadInteger();
        }

        static double DoubleErrorMessage(string message)
        {
            Console.WriteLine(message);
            return ReadDouble();
        }

        static int IntegerInRangeErrorMessage(string message, int minValue, int maxValue)
        {
            Console.WriteLine(message);
            return ReadIntegerInRange(minValue, maxValue);
        }
    }
}
