using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Assign3
{
    public partial class GradeForm
    {
        // Center and Size Frame
        private void PositionAndSizeFrame()
        {
            int h = Screen.PrimaryScreen.WorkingArea.Height - 200;
            int w = (Screen.PrimaryScreen.WorkingArea.Width / 2) + 100;
            Size = new Size(w, h);

            CenterToScreen();
        }

        public static void BuildStudentPool()
        {
            String buffer,
                filepath = "..\\..\\students.txt";

            // Open students.txt file
            using (StreamReader inFile = new StreamReader(filepath))
            {
                // Get first line of input
                buffer = inFile.ReadLine();

                // Loop through file
                while (buffer != null)
                {
                    // Split current line
                    String[] argList = buffer.Split(',');

                    // Parse zid from string to uint
                    uint newZid;
                    UInt32.TryParse(argList[0], out newZid);

                    // Parse year from string to int
                    int newYear;
                    Int32.TryParse(argList[4], out newYear);

                    // Parse gpa from string to float
                    float newGpa;
                    float.TryParse(argList[5], out newGpa);

                    // Create a new student object
                    Student newStudent = new Student(newZid, argList[2], argList[1], argList[3], newYear, newGpa);

                    // Add the new student to the student pool
                    studentPool.Add(newStudent);

                    // Read next line of input
                    buffer = inFile.ReadLine();
                } // end while loop
            } // end using inFile

        } // end BuildStudentPool method

        /*******************************************************
        * BuildCoursePool method
        *
        * Arguments: None
        * Return Type: void
        * Use Case: Builds the static coursePool variable
        ******************************************************/
        public static void BuildCoursePool()
        {
            String buffer,
                filepath = "..\\..\\courses.txt";

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

                    // Parse cNum from string to uint
                    uint crsNum;
                    UInt32.TryParse(argList[1], out crsNum);

                    // Parse crdHours from string to ushort
                    ushort crdHours;
                    UInt16.TryParse(argList[3], out crdHours);

                    // Parse newCapp from string to ushort
                    ushort newCapp;
                    UInt16.TryParse(argList[4], out newCapp);

                    // Create a new Course object
                    Course newCourse = new Course(argList[0], crsNum, argList[2], crdHours, newCapp);

                    // Add the new course to the course pool
                    coursePool.Add(newCourse);

                    // Read next line of input
                    buffer = inFile.ReadLine();
                } // end while loop
            } // end using

        } // end BuildCoursePool method

        /*******************************************************
        * BuildMajorPool method
        *
        * Arguments: None
        * Return Type: void
        * Use Case: Builds the static majorPool variable
        ******************************************************/
        public static void BuildMajorPool()
        {
            foreach (Student s in studentPool)
            {
                majorPool.Add(s.Major);
            }
        } // end BuildMajorPool

        /*******************************************************
        * PopulateGradeComboBox method
        *
        * Arguments: None
        * Return Type: void
        * Use Case: Changes both grade dropdowns to accept
        * strings previously created. 
        ******************************************************/
        private void PopulateGradeComboBox()
        {
            GradeComboBox1.Items.Clear();
            GradeComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            GradeComboBox2.Items.Clear();
            GradeComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (string grade in grades)
            {
                GradeComboBox1.Items.Add(grade);
                GradeComboBox2.Items.Add(grade);
            }

        }//end PopulateGradeComboBox


        private void PopulateMajorComboBox()
        {
            MajorComboBox.Items.Clear();

            foreach (string s in majorPool)
            {
                MajorComboBox.Items.Add(s);
            }

        }//PopulateMajorComboBox End


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
                    gradePool.Add(newGrade);

                    // Read next line of input
                    buffer = inFile.ReadLine();
                } // end while loop
            } // end using

        } // end BuildCoursePool method

    }

}

