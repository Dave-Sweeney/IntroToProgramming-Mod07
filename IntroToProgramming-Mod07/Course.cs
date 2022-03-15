using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToProgramming_Mod07
{
    // EX 1 Task 1:  Create a base class called Course to represent a course with the following aspects.
    // Use encapsulation for the member variables by making them private and then creating public 
    // properties.
    internal class Course
    {
        private string _courseTitle;
        private int _creditHours;
        private string _program;

        public string CourseTitle { get { return _courseTitle; } set { _courseTitle = value; } }
        public int CreditHours { get { return _creditHours; } set { _creditHours = value; } }
        public string Program { get { return _program; } set { _program = value; } }

        public void EnrollStudent(string studentName) { }

        public virtual void CalculateAverage() { }

        public override string ToString()
        {
            return $"Title: { _courseTitle }\n" +
                   $"Credit Hours: { _creditHours }\n" +
                   $"Program: { _program }";
        }
    }
}
