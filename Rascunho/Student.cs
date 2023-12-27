using System.Globalization;

namespace Rascunho
{
    class Student
    {
        public string Name;
        public double Grade01, Grade02, Grade03;

        public double FinalGrade()
        {
            return Grade01 + Grade02 + Grade03;
        }

        bool Approved()
        {
            if (FinalGrade() >= 60.0) return true;
            return false;
        }

        public double RemainingGrade()
        {
            if (Approved())
            {
                return 0.0;
            }
            return 60.0 - FinalGrade(); 
        }

        public override string ToString()
        {
            return "Final Grade: " + FinalGrade().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
