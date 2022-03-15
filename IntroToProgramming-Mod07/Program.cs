using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToProgramming_Mod07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EX 2 Task 2:  Inspect the inherited attributes of the CreditCourse class by using IntelliSense
            CreditCourse credCourse = new CreditCourse();
            credCourse.EnrollStudent("David");

            NonCreditCourse nonCreditCourse = new NonCreditCourse();
            nonCreditCourse.EnrollStudent("David's Cat");

            // EX 2 Task 3:  Using the previously created instance of the CreditCourse object credCourse,
            // apply some values to the member variables.
            credCourse.CourseTitle = "CS101";
            credCourse.CreditHours = 6;
            credCourse.Program = "Computer Science";

            Console.WriteLine(credCourse.ToString());

            Console.ReadKey();
        }
    }
}
