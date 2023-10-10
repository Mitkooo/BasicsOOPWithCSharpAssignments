namespace ClassesAssignment
{
    public class University
    {
        public static bool started = false;

        public University()
        {
        }

        public University(bool hasStarted)
        {
            started = hasStarted;
        }

        public void ChangeYearStartedSwitch(bool flag)
        {
            started = flag;
        }

        public static bool HasTheStudentYearStarted()
        {
            return started;
        } 
    }
}

