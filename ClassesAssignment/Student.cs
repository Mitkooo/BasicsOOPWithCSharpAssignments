namespace ClassesAssignment
{
    public class Student
    {
        public string? Name { get; set; }
        public int FNumber { get; set; }
        public bool Attendance { get; set; }

        public Student()
        {

        }

        public Student(string name, int fNumber)
        {
            this.Name = name;
            this.FNumber = fNumber;
            this.Attendance = true;
        }

        public void TakingExam()
        {
            Console.WriteLine("Taking Exam.");
        }
    }
}