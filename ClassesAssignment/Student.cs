namespace ClassesAssignment
{
    // 1. Create class named Student with following public properties:
    // - name
    // - fNumber
    // and methods: takeExam()
    // This method should implement logic for printing out the following message: "Taking exam".
    // Note: name and fNumber are assigned in class constructor.
    public class Student
    {
        public string? name_;
        public int fNumber_;
        public bool attendance_ = false;

        public Student()
        {

        }

        public Student(string name, int fNumber)
        {
            name_ = name;
            fNumber_ = fNumber;
        }

        public void TakingExam()
        {
            Console.WriteLine("Taking Exam.");
        }
    }
}