using System;
using System.Linq;

namespace ArraysAssignment
{
    public class ArraysAssignment
    {
        public static void Main()
        {
            //SortIntArrayAsc();
            //SecondWayOfsortArrayAsc();
            //sumValuesOfArray();
            //isValueContainedInArray();
            SortArrayInDesc();
        }

        // 1. Write a C# program to sort an integer array in ascending and then print it.
        static void SortIntArrayAsc()
        {
            Console.WriteLine("Task 1");
            int[] array = new int[11] { 10, 6, 3, 8, 5, 4, 7, 9, 2, 1, 11 };
            Array.Sort(array);
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        // 2. Find a second way to sort a numeric array from internet and write it in a C# program.
        static void SecondWayOfsortArrayAsc()
        {
            Console.WriteLine("\nTask 2");
            int[] array = new int[11] { 10, 6, 3, 8, 5, 4, 7, 9, 2, 1, 11 };
            var sortedNumbers = array.OrderBy(x => x);
            foreach (int num in sortedNumbers)
            {
                Console.Write($"{num} ");
            }
        }

        // 3. Write a C# program to sum values of an array.
        static void sumValuesOfArray()
        {
            Console.WriteLine("\nTask 3");
            int[] array = new int[5] { 10, 6, 3, 6, 8 };
            int sum = array.Sum();
            Console.WriteLine($"Sum of array values: {sum}");
        }

        // 4. Write a C# program to test if an array contains a specific value.
        static void isValueContainedInArray()
        {
            Console.WriteLine("\nTask 4");
            int[] array = { 10, 46, 3, 6, 8, 100, 50, 73, 23, 67 };
            Console.Write("Enter any integer value:");
            int value = ReadInteger();
            if (array.Contains(value))
            {
                Console.WriteLine("Value is contained in array."); 
            }
            else
            {
                Console.WriteLine("Value is not contained in array.");
            }
        }

        // 5. Write a C# program to reverse an array of integer values.
        static void SortArrayInDesc()
        {
            Console.WriteLine("\nTask 5");
            int[] array = { 10, 46, 3, 6, 8, 100, 50, 73, 23, 67 };
            var sortedNumbers = array.OrderByDescending(x => x);
            Console.WriteLine("Sorted numbers in descending order are: ");
            foreach (int num in sortedNumbers)
            {
                Console.Write($"{num} ");
            }
        }




        static int ReadInteger()
        {
            return int.TryParse(Console.ReadLine(), out int number)
                ? number
                : IntegerErrorMessage("Input cannot be empty or string.");
        }

        static int IntegerErrorMessage(string message)
        {
            Console.WriteLine(message);
            return ReadInteger();
        }
    }
}