namespace ClassesAssignment
{
    // 1. Create class named Student with following public properties:
    // - name
    // - fNumber
    // and methods: takeExam()
    // This method should implement logic for printing out the following message: "Taking exam".
    // Note: name and fNumber are assigned in class constructor.
    class Student
    {
        public string? name;
        public int fNumber;

        public Student()
        {
            this.name = "Michael";
            this.fNumber = 156;
        }

        public static void Main()
        {
            TakeExam();
        }

        public static void TakeExam()
        {
            Console.WriteLine("Taking exam.");
        }
    }

    // 2. Create new class University and add boolean static method to check if the student year has started.
    class University
    {
        public int day;
        public int month;

        public University(int day, int month)
        {
            this.day = day;
            this.month = month;
        }

        public static void Main() 
        {
            HasStudentYearStarted();
        }

        public static bool HasStudentYearStarted()
        {
            University uni = new University(10, 2);
            if (uni.month == 9 && uni.day == 15)
            {
                Console.WriteLine("Student year has started!");
                return true;
            }
            else if (uni.month >= 9 && uni.day > 15 || uni.month <= 6 && uni.day <= 15)
            {
                Console.WriteLine("Student year is ongoing!");
                return false;
            }
            else if (uni.month <= 9 && uni.day <= 14 || uni.month >= 6 && uni.day >= 16)
            {
                Console.WriteLine("Student year has not yet started!");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid day / month.");
                return false; 
            }
        }
    }
}