using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    public class Grade
    {
        private string zid;
        private string dept;
        private string course;
        private string letterGrade;

        public string Zid
        {
            get => zid;
            set => value = zid;
        }

        public string Dept
        {
            get => dept;
            set => value = dept;
        }

        public string Course
        {
            get => course;
            set => value = course;
        }

        public string LetterGrade {
            get => letterGrade;
            set => value = letterGrade;
        }
 
        public Grade(string newZid, string newDept, string newCourse, string newGrade)
        {
            Zid = newZid;
            Dept = newDept;
            Course = newCourse;
            LetterGrade = newGrade;
        }

        /*******************************************************
        * BuildCoursePool method
        *
        * Arguments: None
        * Return Type: void
        * Use Case: Builds the static coursePool variable
        ******************************************************/
        public static void BuildGradePool()
        {
            String buffer,
                filepath = "..\\..\\grades.txt";

            // Open courses.txt file
            using (StreamReader inFile = new StreamReader(filepath))
            {
                // Get first line of input, priming
                buffer = inFile.ReadLine();

                // Loop through file
                while (buffer != null)
                {
                    // Split current line
                    String[] argList = buffer.Split(',');

                    // Create a new Course object
                    Grade newGrade = new Grade(argList[0], argList[1], argList[2], argList[3]);

                    // Add the new course to the course pool
                    GradeForm.gradePool.Add(newGrade);

                    // Read next line of input
                    buffer = inFile.ReadLine();
                } // end while loop
            } // end using

        } // end BuildCoursePool method

        public string BuildGradeListing()
        {
            StringBuilder sb = new StringBuilder(Zid + "   |   ");
            sb.Append(Dept + "-" + Course);
            sb.Append("   |   " + LetterGrade);
            return sb.ToString();
        }
    }
}
