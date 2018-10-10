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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq; 
using System.Windows.Forms;

namespace Assign3
{
    public partial class GradeForm : Form
    {
        public static SortedSet<Student> studentPool = new SortedSet<Student>();
        public static SortedSet<Student> filteredStudentPool = new SortedSet<Student>();

        public static SortedSet<Course> coursePool = new SortedSet<Course>();
        public static SortedSet<Course> filteredCoursePool = new SortedSet<Course>();

        public static SortedSet<string> majorPool = new SortedSet<string>();
        public static SortedSet<string> deptPool = new SortedSet<string>();

        public static string[] gradePool = {"A+","A","A-","B+","B","B-","C++","C","C-","D+","D","D-","F" };

        public GradeForm()
        {
            InitializeComponent();
            PositionAndSizeFrame();

            BuildStudentPool();
            BuildCoursePool();

            PopulateGradeComboBox();
        }

        // Center and Size Frame
        private void PositionAndSizeFrame()
        {
            int h = Screen.PrimaryScreen.WorkingArea.Height - 200;
            int w = (Screen.PrimaryScreen.WorkingArea.Width / 2) + 100;
            Size = new Size(w, h);

            CenterToScreen();
        }

        private void ResultsButton1_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();
            MainOutputBox.Text = "Button 1"; 
        }

        private void ResultsButton2_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();
            MainOutputBox.Text = "Button 2";
        }

        private void ResultsButton3_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();
            MainOutputBox.Text = "Button 3";
        }

        private void ResultsButton4_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();
            MainOutputBox.Text = "Button 4";
        }

        private void ResultsButton5_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();
            MainOutputBox.Text = "Button 5";
        }

        private void ResultsButton6_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();
            MainOutputBox.Text = "Button 6";
        }

        public static void BuildStudentPool()
        {
            Console.WriteLine("Building Student Pool");

            String buffer,
                filepath = "..\\..\\students.txt"; // Windows Path
                                                   //filepath = "./students.txt"; // Mac Path

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
            Console.WriteLine("\nBuilding Course Pool");

            String buffer,
                filepath = "..\\..\\courses.txt"; // Windows path
                                                  //filepath = "./courses.txt"; // Mac Path

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

            foreach (string grade in gradePool)
            {
                GradeComboBox1.Items.Add(grade);
                GradeComboBox2.Items.Add(grade);
            }

        }//end PopulateGradeComboBox

        private void PopulateCourseComboBox()
        {
            
        }

        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
