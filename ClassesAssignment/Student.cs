namespace ClassesAssignment
{
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