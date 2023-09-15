namespace SwitchCaseAssignment
{
    internal class SwitchCaseAssignment
    {
        /*public static void Main(string[] args)
        {
            inputYOrN();
            DisplayGradeName();
            WeekDays();
        }*/

        // 1. Write a C# program that asks the user to input choice in y/n and displays the output according to value input by user.
        // Not 100% sure if i have to include lower case but did just in case.
        static void inputYOrN()
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter Y or N:");
            char letter = ReadChar();
            Console.WriteLine($"You entered {letter}.");
            switch (letter)
            {
                case 'Y':
                case 'N':
                case 'y':
                case 'n':
                    Console.WriteLine($"Input value: {char.ToUpper(letter)}\n");
                    break;
                default:
                    Console.WriteLine("Char is not the accepted values.\n");
                    break;
            }
        }

        // 2 . Write a C# program that asks the user to input a letter grade (A-F) and displays the name of the grade.
        // Not 100% sure if i have to include lower case but did just in case.
        static void DisplayGradeName()
        {
            Console.WriteLine("Task 2");
            Console.WriteLine("Please enter a grade:");
            char grade = ReadChar();
            Console.WriteLine($"You entered {grade}.");
            switch (grade)
            {
                case 'a':
                case 'A':
                    Console.WriteLine("Excellent!\n");
                    break;
                case 'b':
                case 'B':
                    Console.WriteLine("Good!\n");
                    break;
                case 'c':
                case 'C':
                    Console.WriteLine("Satisfactory!\n");
                    break;
                case 'd':
                case 'D':
                    Console.WriteLine("Needs Improvement!\n");
                    break;
                case 'f':
                case 'F':
                    Console.WriteLine("Fail!\n");
                    break;
                default:
                    Console.WriteLine("Input is not a valid grade.\n");
                    break;
            }
        }

        // 3. Write a C# program that keeps a number from the user and generates an integer between 1 and 7 and displays the name of the weekday.
        // Print "weekend" if the day is part of the weekend or "workday" if otherwise.
        static void WeekDays()
        {
            Console.WriteLine("Task 3");
            int number = ReadIntegerInRange();
            Console.WriteLine($"You entered:{number}");
            string weekDay;

            switch (number)
            {
                case 1:
                    weekDay = "Monday";
                    break;
                case 2:
                    weekDay = "Tuesday";
                    break;
                case 3:
                    weekDay = "Wednesday";
                    break;
                case 4:
                    weekDay = "Thursday";
                    break;
                case 5:
                    weekDay = "Friday";
                    break;
                case 6:
                    weekDay = "Saturday";
                    break;
                case 7:
                    weekDay = "Sunday";
                    break;
                default:
                    Console.Write("Input number is not a valid day.");
                    return;
            }

            switch (number)
            {
                case 6:
                case 7:
                    Console.WriteLine($"{weekDay} is a Weekend day.");
                    break;
                default:
                    if (number < 6 && number >= 1)
                    {
                        Console.WriteLine($"{weekDay} is a Workday.");
                    }
                    break;
            }

        }

        // Methods that read Integer/Double/Integer that is between 1 and 7
        // They check if entered value is valid and returns it or empty/not in correct range
        static char ReadChar()
        {
            return char.TryParse(Console.ReadLine(), out char letter) && char.IsLetter(letter)
                ? letter
                : CharErrorMessage("Invalid input.\n");
        }

        static int ReadInteger()
        {
            return int.TryParse(Console.ReadLine(), out int number)
                ? number
                : IntegerErrorMessage("Input cannot be empty, string or a special character.");
        }

        // Changes to this method includes:
        // You choose the minimum and maximum values
        // If the minValue is higher than or equal to maxValue, an error message will be displayed 
        static int ReadIntegerInRange()
        {
            Console.WriteLine("Enter minimum accepted value.");
            int minValue = ReadInteger();
            Console.WriteLine("Enter maximum accepted value.");
            int maxValue = ReadInteger();

            if (minValue > maxValue)
            {
                return IntegerInRangeErrorMessage($"Input minimum value '{minValue}' cannot be higher than maximum value '{maxValue}'.");
            }
            else if (minValue == maxValue)
            {
                return IntegerInRangeErrorMessage($"Input minimum value '{minValue}' cannot be equal to maximum value '{maxValue}'.");
            }

            Console.WriteLine($"Enter a number between {minValue} and {maxValue}");
            return int.TryParse(Console.ReadLine(), out int number)
                ? (number >= minValue && number <= maxValue)
                    ? number
                    : IntegerInRangeErrorMessage($"Input must be a number between {minValue} and {maxValue}.")
                : IntegerInRangeErrorMessage("Input cannot be empty, string, or a special character.");
        }



        // Methods that return message for Int/Double
        // Made those because if I use Console.WriteLine(message); in Read* methods it tells me I can't convert void to int/double
        static char CharErrorMessage(string message)
        {
            Console.WriteLine(message);
            return ReadChar();
        }

        static int IntegerErrorMessage(string message)
        {
            Console.WriteLine(message);
            return ReadInteger();
        }

        static int IntegerInRangeErrorMessage(string message)
        {
            Console.WriteLine(message);
            return ReadIntegerInRange();
        }
    }
}
