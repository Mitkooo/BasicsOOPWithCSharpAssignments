namespace ClassesAssignment
{
    public class Program
    {
        public static void Main() 
        {
            Task1();
            Task2();
        }

        public static void Task1()
        {
            var Georgi = new Student("Georgi", 987654);
            var Dimitar = new Student("Dimitar", 157564);
            Dimitar.TakingExam();
            Georgi.TakingExam();
        }

        public static void Task2()
        {
            University uni = new University();
            uni.ChangeYearStartedSwitch(true);
            if (University.HasTheStudentYearStarted())
            {
                Console.WriteLine("Student year has started!");
            }
        }
    }
}
