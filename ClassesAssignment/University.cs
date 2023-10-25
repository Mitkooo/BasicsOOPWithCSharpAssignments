namespace ClassesAssignment
{
    public class University
    {
        public static bool started_ = false;

        public University()
        {
        }

        public University(bool hasStarted)
        {
            started_ = hasStarted;
        }

        public void ChangeYearStartedSwitch(bool flag)
        {
            started_ = flag;
        }

        public static bool HasTheStudentYearStarted()
        {
            return started_;
        } 
    }
}

