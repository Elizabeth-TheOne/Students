
namespace Students
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
                int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
            : this(name, studentId, 0, 0) { }

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (this.NumberOfCredits >= 90)
            {
                return "Senior";
            }
            else if (this.NumberOfCredits >= 60)
            {
                return "Junior";
            }
            else if (this.NumberOfCredits >= 30)
            {
                return "Sophmore";
            }
            return "Freshman";
        }

        public override string ToString()
        {
            return this.Name + " " + this.GetGradeLevel();
        }
    }
}
