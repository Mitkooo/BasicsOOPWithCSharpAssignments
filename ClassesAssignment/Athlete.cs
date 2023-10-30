namespace ClassesAssignment
{
    public class Athlete : Student
    {
        public string certification { get; set; }

        public Athlete(string certification)
        {
            this.certification = certification;
        }
    }
}
