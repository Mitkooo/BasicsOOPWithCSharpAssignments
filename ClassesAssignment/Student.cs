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

        }

        public Student(string name, int fNumber)
        {
            this.name = name;
            this.fNumber = fNumber;
        }

        public void TakingExam()
        {
            Console.WriteLine("Taking Exam.");
        }
    }
}