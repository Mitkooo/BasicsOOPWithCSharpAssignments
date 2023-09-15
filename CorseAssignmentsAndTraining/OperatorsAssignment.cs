namespace Program
{
    class OperatorsAssignment
    {
        public static void Main(string[] args)
        {
            FahrenheitToTemperature();
            InchesToCentimetersTask();
            SumOfDigitsOfNum();
            MinutesToYears();
            BodyMassIndex();
            AllCalculationsOfNum();
            SequenceOfDigits();
        }

        // 1. Write a C# program to convert temperature from Fahrenheit to Celsius degree.
        // °C = 5/9(°F – 32)
        public static void FahrenheitToTemperature()
        {
            Console.WriteLine("Fahrenheit to temperature task \n"); 
            Console.Write("Enter the temperature in fahrenheit:");
            double fahrenheit = ReadDouble();
            double celsius = 5.0 / 9.0 * (fahrenheit - 32);
            Console.WriteLine($"{fahrenheit.ToString("0.0")} degree Fahrenheit is equal to {celsius.ToString("0.0")} in Celsius \n");
        }

        // 2. Write a C# program that reads a number in inches, converts it to centimeters.
        // m = in × 2.54
        public static void InchesToCentimetersTask()
        {
            Console.WriteLine("Inches to centimeters task \n");
            Console.Write("Enter inches:");
            double inches = ReadDouble();
            double centimeters = inches * 2.54;
            Console.WriteLine($"{inches.ToString("0.0")} inch is {centimeters} centimeters \n");
        }

        // 3. Write a C# program that reads an integer between 0 and 1000 and adds all the digits in the integer.
        public static void SumOfDigitsOfNum()
        {
            Console.WriteLine("Sum of digits of a number task \n");
            Console.Write($"Enter a number between 0 and 1000: ");
            int number = ReadIntegerInRange();

            int sum = 0;
            int remainingNumber = number;
            while (remainingNumber > 0)
            {
                int digit = remainingNumber % 10;
                sum += digit;
                remainingNumber /= 10;
            }

            Console.WriteLine($"The sum of all digits in {number} is {sum} \n");
        }

        // 4. Write a C# program to convert minutes into a number of years and days.
        // Number of minutes in a year int year = minutes / 525600; int day = minutes / 1440; int remainingMinutes = day % 525600;
        public static void MinutesToYears()
        {
            Console.WriteLine("Minutes to years task \n");
            Console.Write("Enter minutes:");
            int minutes = ReadInteger();

            const int minutesPerDay = 24 * 60;
            const int daysPerYear = 365;

            int totalDays = minutes / minutesPerDay;
            int years = totalDays / daysPerYear;
            int days = totalDays % daysPerYear;
            Console.WriteLine($"{minutes} minutes is approximately {years} years and {days} days \n");
        }

        // 5. BMI is weight in kilograms divided by height in meters squared.
        // Write a C# program to compute body mass index (BMI).
        public static void BodyMassIndex()
        {
            Console.WriteLine("Body mass index task \n");
            Console.Write("Enter weight in pounds:");
            double weightPounds = ReadDouble();
            Console.Write("Enter height in inches:");
            double heightInches = ReadDouble();

            double weightKg = weightPounds * 0.45359237;
            double heightMeters = heightInches * 0.0254;

            heightMeters = Math.Pow(heightMeters, 2);
            double BMI = weightKg / heightMeters;
            Console.WriteLine($"Body Mass Index is {BMI} \n");
        }

        // 6. Write a C# program that accepts two integers from the user and then prints the sum,
        // the difference, the product, the average, the distance (the difference between integer), the max and the min.
        public static void AllCalculationsOfNum()
        {
            Console.WriteLine("All calculations task \n");
            Console.Write("Enter the first number:");
            int num1 = ReadInteger();
            Console.Write("Enter the second number:");
            int num2 = ReadInteger();
            int sum, difference, product, average, distance;

            sum = num1 + num2;
            Console.WriteLine($"Sum of two integers:{sum}");

            // To find the difference between two numbers, subtract the number with the smallest value from the number with the largest value
            if (num1 > num2)
            {
                difference = num1 - num2;
                distance = Math.Abs(difference);
                Console.WriteLine($"Difference/Distance of two integers:{difference} / {distance}");
            }
            else
            {
                difference = num2 - num1;
                distance = Math.Abs(difference);
                Console.WriteLine($"Difference/Distance of two integers:{difference} / {distance}");
            }

            // The product of two integers can either be positive, negative, or zero.
            // To carry out the multiplication of two integers: Multiply their signs and get the resultant sign.
            // Multiply the numbers and add the resultant sign to the answer.
            product = num1 * num2;
            Console.WriteLine($"Product of two integers:{product}");

            //  The average of two numbers is given by x = (a + b)/2
            average = (sum) / 2;
            string formattedAverage = average.ToString("0.00");
            Console.WriteLine($"Average of two integers:{formattedAverage}");
            int minValue = Math.Min(num1, num2);
            int maxValue = Math.Max(num1, num2);
            Console.WriteLine($"Max integer:{maxValue}");
            Console.WriteLine($"Min integer:{minValue} \n");
        }

        // 7. Write a C# program to break an integer into a sequence of individual digits.
        public static void SequenceOfDigits()
        {
            Console.WriteLine("Sequence of digits of a number task \n");
            Console.Write("Enter a long number:");
            int number = ReadInteger();
            Console.Write("Sequence for entered number is: ");
            Console.WriteLine(string.Join(" ", number.ToString().ToCharArray()));
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

        static int ReadIntegerInRange()
        {
            return int.TryParse(Console.ReadLine(), out int number)
                ? (number >= 1 && number <= 7)
                   ? number
                   : IntegerInRangeErrorMessage("Input must be a number between 1 and 7.")
                : IntegerInRangeErrorMessage("Input cannot be empty or string.");
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

        static int IntegerInRangeErrorMessage(string message)
        {
            Console.WriteLine(message);
            return ReadIntegerInRange();
        }


    }
}