/************************************************************
 *                                                          *
 *  CSCI 473/504           Assignment 3         Fall 2018   *                                             
 *                                                          *
 *  Programmers: Tyler Saballus/Josh Ruge                   *
 *                                                          *
 *  Date Due:   Oct-11                                      *                          
 *                                                          *
 *  Purpose:    Student grading using two classes,          *
 *              Students and Courses to enact basic         *
 *              functionality to the user via a form..      *
 ***********************************************************/

using System;
using System.IO;
using System.Text;

namespace Assign3
{
    public class Grade
    {
        public string Zid { get; set; }

        public string Dept { get; set; }

        public string Course { get; set; }

        public string LetterGrade { get; set; }

        /*******************************************************
        * Grade Constructor
        *
        * Arguments: (4): All strings to represent zid, dept, course, and grade
        ******************************************************/
        public Grade(string newZid, string newDept, string newCourse, string newGrade)
        {
            Zid = newZid;
            Dept = newDept;
            Course = newCourse;
            LetterGrade = newGrade;
        }

        /*******************************************************
        * BuildGradePool method
        *
        * Arguments: None
        * Return Type: void
        * Use Case: Builds the static gradePool variable
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



        /*******************************************************
        * BuildGradeListing method
        *
        * Arguments: None
        * Return Type: void
        * Use Case: Builds a gradelisting for the current grade object
        ******************************************************/
        public string BuildGradeListing()
        {
            StringBuilder sb = new StringBuilder(Zid + "   |   ");
            sb.Append(Dept + "-" + Course);
            sb.Append("   |   " + LetterGrade);
            return sb.ToString();
        }


        /*******************************************************
        * BuildGradeListing method
        *
        * Arguments: (1): letterGrade - A string to be assigned a weight
        * Return Type: void
        * Use Case: Takes letters grades and weights them
        ******************************************************/
        public static int FindGradeWeight(string letterGrade)
        {
            switch (letterGrade) {
                case "A+":
                    return 12;
                case "A":
                    return 11;
                case "A-":
                    return 10;
                case "B+":
                    return 9;
                case "B":
                    return 8;
                case "B-":
                    return 7;
                case "C++":
                case "C+":
                    return 6;
                case "C":
                    return 5;
                case "C-":
                    return 4;
                case "D+":
                    return 3;
                case "D":
                    return 2;
                case "D-":
                    return 1;
                case "F":
                default:
                    return 0;

            } // end switch
        } // end GradeForm.FindGradeWeight Method
    }
}
