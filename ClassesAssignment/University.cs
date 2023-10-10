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

        public bool ChangeYearStartedSwitch(bool flag)
        {
            return started = flag;
        }

        public static bool HasTheStudentYearStarted()
        {
            return started;
        }
    }
}

