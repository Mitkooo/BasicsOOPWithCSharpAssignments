using System.Text.RegularExpressions;

namespace StringsAssignment
{
    public class StringsAssignment
    {
        public static void Main(string[] args)
        {
            CompareStrings();
            ConcatenateString();
            StringObjectWithCharArray();
            isCharContainedInString();
            RemoveWhiteSpace();
            ConvertIntToString();
        }

        // 1.Write a C# program to compare the size of two strings.
        static void CompareStrings()
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter first word:");
            string left = ReadString();
            Console.WriteLine("Enter second word:");
            string right = ReadString();
            
            if(left.Length == right.Length)
            {
                Console.WriteLine($"{left} and {right} are equal.");
            }
            else
            {
                Console.WriteLine($"{left} and {right} are not equal.");
            }
        }

        // 2.Write a C# program to concatenate a given string to the end of another string.
        static void ConcatenateString()
        {
            Console.WriteLine("\nTask 2");
            Console.WriteLine("Enter first half of the sentence:");
            string left = ReadString();
            Console.WriteLine("Enter second half of the sentence:");
            string right = ReadString();

            Console.WriteLine($"{left} {right}");
        }

        // 3.Write a C# program to create a new String object with the contents of a character array.
        // Use the internet to find a solution.
        static void StringObjectWithCharArray()
        {
            Console.WriteLine("\nTask 3");
            char[] array = { 'S', 't', 'r', 'i', 'n', 'g' };
            string word = new string(array);
            Console.WriteLine(word);
        }

        // 4.Write a C# program to find out if a char is in a string.
        static void isCharContainedInString()
        {
            Console.WriteLine("\nTask 4");
            Console.Write("Enter a word or a sentence: ");
            string word = ReadString();

            if(word.Contains('h'))
            {
                Console.WriteLine("There is an 'h' in the string");
            }
            else
            {
                Console.WriteLine("There is not an 'h' in the string");
            }
        }

        // 5.Write a C# program to remove all the white spaces in a given string and print it out.
        static void RemoveWhiteSpace()
        {
            Console.WriteLine("\nTask 5");
            Console.WriteLine("Enter a sentence: ");
            string words = ReadString();

            string modified = Regex.Replace(words, @"\s", "");
            Console.WriteLine(modified);
        }

        // 6.Write a C# program to convert an integer into string. Find two solutions to this problem.
        static void ConvertIntToString()
        {
            Console.WriteLine("\nTask 6");
            int number = 156;

            Console.WriteLine("First solution:");
            string converted1 = number.ToString();
            Console.WriteLine($"Converted number to string: {converted1}");

            Console.WriteLine("Second solution:");
            int anotherNumber = 134;
            string converted2 = string.Format("{0}", anotherNumber);
            Console.WriteLine($"Converted number to string {converted2}");
        }

        static string ReadString()
        {
            string? value = Console.ReadLine();
            return string.IsNullOrEmpty(value) || int.TryParse(value, out _)
                ? StringErrorMessage("Input cannot be empty, numeric, or special character.")
                : value;
        }

        static string StringErrorMessage(string message)
        {
            Console.WriteLine(message);
            return ReadString();
        }

    }
}