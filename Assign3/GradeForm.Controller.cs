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
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System;

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

        /*******************************************************
        * BuildMajorPool method
        *
        * Arguments: None
        * Return Type: void
        * Use Case: Builds the static majorPool variable
        ******************************************************/
        public static void BuildMajorPool()
        {
            String buffer,
                filepath = "..\\..\\colleges.txt";


            // Open students.txt file
            using (StreamReader inFile = new StreamReader(filepath))
            {
                // Get first line of input
                buffer = inFile.ReadLine();

                // Loop through file
                while (buffer != null)
                {
                    majorPool.Add(buffer);
                    // Read next line of input
                    buffer = inFile.ReadLine();
                }

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

        /*******************************************************
        * PopulateMajorComboBox method
        *
        * Arguments: None
        * Return Type: void
        * Use Case: Changes both grade dropdowns to accept
        * strings previously created.
        ******************************************************/
        private void PopulateMajorComboBox()
        {
            MajorComboBox.Items.Clear();

            foreach (string s in majorPool)
            {
                MajorComboBox.Items.Add(s);
            }

        } //PopulateMajorComboBox End

        /*******************************************************
        * Button 1 click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: Displays all grades for a selected student
        ******************************************************/
        private void ResultsButton1_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();

            var gradeMatches =
                from grade in gradePool
                where grade.Zid == ZidBox.Text
                orderby grade.Dept
                select grade;

            StringBuilder sb = new StringBuilder("Single Student Grade Report  (" + ZidBox.Text + ")");
            sb.AppendLine("\n-----------------------------------------------------------------------");

            foreach (Grade g in gradeMatches)
            {
                sb.AppendLine(g.BuildGradeListing());
            }

            sb.AppendLine("\n\n ### END RESULTS ###");

            MainOutputBox.Text = sb.ToString();
        } // end GradeForm.ResultsButton1_Click method

        /*******************************************************
        * Button 2 click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: Shows all grades either greater than
        * or less than the specified grade user input for 
        * one course object.
        ******************************************************/
        private void ResultsButton2_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();
            MainOutputBox.Text = "Button 2";
            bool allSelected = true; 

            StringBuilder passOutput = new StringBuilder(); 

            //Tests if Grade is inputted
            if (GradeComboBox1.SelectedIndex == -1)
            {
                passOutput.AppendLine("Error! Please Select a Grade.");
                allSelected = false;
                MainOutputBox.Text = passOutput.ToString();
                return; 
            }

            //Tests if 1 button is checked
            if (!LessButton1.Checked && !GreaterButton1.Checked)
            {
                passOutput.AppendLine("Error! Please Select Less Than or Greater Than.");
                allSelected = false;
                MainOutputBox.Text = passOutput.ToString();
                return; 
            }

            //tests if course input is blank
            if (textBox1.Text.ToString() == "")
            {
                passOutput.AppendLine("Error! Please enter text into Course field!");
                allSelected = false;
                MainOutputBox.Text = passOutput.ToString();
                return;
            }

            if (allSelected)
            {
                int amnt = 0; 
                string selectedGrade = GradeComboBox1.SelectedItem.ToString();
                string splitString = textBox1.Text.ToUpper();
                string[] argList = splitString.Split(' ');

                if (LessButton1.Checked)
                {
                    var studmatches =
                    from grade in gradePool
                    where ((grade.LetterGrade.CompareGrade(selectedGrade)) >= 0)
                    && (grade.Dept == argList[0])
                    && (grade.Course == argList[1])
                    select grade;

                  //  if (studmatches.Sum == 0)


                    StringBuilder sb = new StringBuilder("Grade Threshold Report for  (" + textBox1.Text.ToUpper() + ")");
                    sb.AppendLine("\n-----------------------------------------------------------------------");

                    foreach (Grade g in studmatches)
                    {
                        sb.AppendLine(g.BuildGradeListing());
                        amnt++; 

                    }

                    if (amnt == 0)
                        sb.AppendLine("\n\n No courses found, check course input for errors \nMUST BE IN format xxxx 123 or xxx 123");

                    sb.AppendLine("\n\n ### END RESULTS ###");

                    MainOutputBox.Text = sb.ToString();
                }

                else
                {
                    var studmatches =
                    from grade in gradePool
                    where ((grade.LetterGrade.CompareGrade(selectedGrade)) <= 0)
                    && (grade.Dept == argList[0])
                    && (grade.Course == argList[1])
                    select grade;

                    StringBuilder sb = new StringBuilder("Single Course Grade Report  (" + textBox1.Text.ToUpper() + ")");
                    sb.AppendLine("\n-----------------------------------------------------------------------");

                    foreach (Grade g in studmatches)
                    {
                        sb.AppendLine(g.BuildGradeListing());
                        amnt++; 
                    }
                    if (amnt == 0)
                        sb.AppendLine("\n\n No courses found, check course input for errors \nMUST BE IN format xxxx 123 or xxx 123");
                    sb.AppendLine("\n\n ### END RESULTS ###");

                    MainOutputBox.Text = sb.ToString();
                }

            }
        } // end GradeForm.ResultsButton2_Click method

        /*******************************************************
        * Button 3 click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: Shows students who fail a course who have 
        * have a specific major determined by user input
        ******************************************************/
        private void ResultsButton3_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();
            MainOutputBox.Text = "Button 3";
            StringBuilder passOutput = new StringBuilder();

            //Tests if Grade is inputted
            if (MajorComboBox.SelectedIndex == -1)
            {
                passOutput.AppendLine("Error! Please Select a Major!");
                MainOutputBox.Text = passOutput.ToString();
                return;
            }

            if (CourseBox1.Text.ToString() == "")
            {
                passOutput.AppendLine("Error! Please enter text into Course field!");
                MainOutputBox.Text = passOutput.ToString();
                return;
            }

            var studentSelected =
                from student in studentPool
                where student.Major == MajorComboBox.Text.ToString()
                select student;

            filteredStudentPool.Clear();

            foreach (Student s in studentSelected)
            {
                filteredStudentPool.Add(s);
            }
            
            string splitString = CourseBox1.Text.ToUpper();
            string[] argList = splitString.Split(' ');  //arglist 0 = dept, 1=course
            string tester = "F";
            var selection2 =
                from s in filteredStudentPool
                from g in gradePool
                where s.Zid.ToString() == g.Zid
                && g.LetterGrade == tester 
                && g.Dept == argList[0]
                && g.Course == argList[1]
                select s;

            int amnt = 0; 
            StringBuilder sb = new StringBuilder("Fail Report of Majors  (" + MajorComboBox.Text + ") in " + CourseBox1.Text.ToUpper());
            sb.AppendLine("\n-----------------------------------------------------------------------");

            foreach (Student g in selection2)
            {
                sb.AppendLine("z" + g.Zid + "  |  " + argList[0] + "-" + argList[1] + "  |  F");
                amnt++;
            }

            if (amnt == 0)
                sb.AppendLine("\n\n No courses found, check course input for errors \nMUST BE IN format xxxx 123 or xxx 123");

            sb.AppendLine("\n\n ### END RESULTS ###");

            MainOutputBox.Text = sb.ToString();
        } // end GradeForm.ResultsButton3_Click method

        /*******************************************************
        * Button 4 click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: User input determines single course
        * to show all students grades in that course. 
        ******************************************************/
        private void ResultsButton4_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();
            MainOutputBox.Text = "Button 4";
            StringBuilder passOutput = new StringBuilder();

            if (CourseBox1.Text.ToString() == "")
            {
                passOutput.AppendLine("Error! Please enter text into Course field!");
                MainOutputBox.Text = passOutput.ToString();
          //      return;
            }

            string splitString = CourseBox2.Text.ToUpper();
            String[] argList = splitString.Split(' ');

            var courseMatches =
                from grade in gradePool
                where grade.Dept == argList[0] 
                && grade.Course == argList[1]
                select grade; 

            filteredCoursePool.Clear();
            StringBuilder sb = new StringBuilder("Single Course Grade Report  (" + CourseBox2.Text.ToUpper() + ")");
            sb.AppendLine("\n-----------------------------------------------------------------------");

            int counter = 0;
            foreach (Grade g in courseMatches)
            {
                sb.AppendLine(g.BuildGradeListing());
                counter++;
            }
            if (counter == 0)
                sb.AppendLine("\n\n No courses found, check course input for errors \nMUST BE IN format xxxx 123 or xxx 123");

            sb.AppendLine("\n\n ### END RESULTS ###");

            MainOutputBox.Text = sb.ToString();
        } // end GradeForm.ResultsButton4_Click method

        /*******************************************************
        * Button 5 click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: Displays all courses where students failed beyond a threshold
        ******************************************************/
        private void ResultsButton5_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();
            StringBuilder failOutput = new StringBuilder();
            bool radioSelected = true;

            // Error check for radio buttons not being set
            if (!LessButton2.Checked && !GreaterButton2.Checked) {
                failOutput.AppendLine("Error! Please Select Less Than or Greater Than.");
                radioSelected = false;
            }


            if (radioSelected) {
                bool matchNotFound = true;

                failOutput.AppendLine("Fail Percentage Report for Classes.");
                failOutput.AppendLine("-------------------------------------");


                foreach (Course c in coursePool)
                {
                    double numEnrolled =
                      (from grade in gradePool
                       where (grade.Dept == c.DeptCode) && (grade.Course == c.CourseNum.ToString())
                       select grade).Count();

                    int numFailed =
                         (from grade in gradePool
                          where (grade.Dept == c.DeptCode) && (grade.Course == c.CourseNum.ToString()) &&
                          (grade.LetterGrade == "F")
                          select grade).Count();

                    // Calculate fail percentage for current course
                    double failPercentage = (numFailed / numEnrolled) * 100;
                    double percentageFilter = Convert.ToDouble(PercentageBox.Value);

                    // Create output for less than or equal to
                    if (LessButton2.Checked && failPercentage <= percentageFilter)
                    {                        
                        failOutput.Append("Out of " + numEnrolled + " in ");
                        failOutput.Append(c.DeptCode + "-" + c.CourseNum + ", ");
                        failOutput.Append(numFailed + " failed (");
                        failOutput.Append(String.Format("{0:0.00}", failPercentage));
                        failOutput.AppendLine("%)\n");

                        matchNotFound = false;
                    }
                    // Create output for greater than or equal to
                    else if (GreaterButton2.Checked && failPercentage >= percentageFilter)
                    {
                        failOutput.Append("Out of " + numEnrolled + " in ");
                        failOutput.Append(c.DeptCode + "-" + c.CourseNum + ", ");
                        failOutput.Append(numFailed + " failed (");
                        failOutput.Append(String.Format("{0:0.00}", failPercentage));
                        failOutput.AppendLine("%)\n");

                        matchNotFound = false;
                    }
                }

                // Create output for no matches found
                if (matchNotFound)
                {
                    failOutput.AppendLine("No matches were found beyond this threshold.");
                }

                failOutput.Append("\n\n### END RESULTS ###");
               
            } // end if radioSelected

            MainOutputBox.Text = failOutput.ToString();

        } // End GradeForm.ResultsButton5_Click method

        /*******************************************************
        * Button 6 click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: Used to display pass rates for every course in the university
        ******************************************************/
        private void ResultsButton6_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();
            StringBuilder passOutput = new StringBuilder();
            bool bothSelected = true;

            // Error check for empty selection box
            if (GradeComboBox2.SelectedIndex == -1)
            {
                passOutput.AppendLine("Error! Please Select a Grade.");
                bothSelected = false;
            }

            // Error check for unselected radio buttons
            if (!LessButton3.Checked && !GreaterButton3.Checked)
            {
                passOutput.AppendLine("Error! Please Select Less Than or Greater Than.");
                bothSelected = false;
            }
 
            if (bothSelected)
            {
                string selectedGrade = GradeComboBox2.SelectedItem.ToString();

                passOutput.AppendLine("Pass Percentage Report for Classes.");
                passOutput.AppendLine("-----------------------------------------------------------");
                foreach (Course c in coursePool)
                {
                    int numEnrolled =
                      (from grade in gradePool
                       where (grade.Dept == c.DeptCode) && (grade.Course == c.CourseNum.ToString())
                       select grade).Count();

                    // Create output for less than or equal to
                    if (LessButton3.Checked)
                    {
                        int numPassed =
                            (from grade in gradePool
                             where (grade.Dept == c.DeptCode) && (grade.Course == c.CourseNum.ToString()) &&
                             (grade.LetterGrade.CompareGrade(selectedGrade) >= 0) &&
                             (grade.LetterGrade != "F")
                             select grade).Count();

                        double passPercentage = (numPassed * 1.0) / numEnrolled;

                        passOutput.Append("Out of " + numEnrolled);
                        passOutput.Append(" enrolled in " + c.DeptCode + "-" + c.CourseNum + ", ");
                        passOutput.Append(numPassed + " passed at or below this threshold (");
                        passOutput.Append(String.Format("{0:0.00%}", passPercentage));
                        passOutput.AppendLine(")\n");
                    }
                    // Create output for greater than or equal to
                    else
                    {

                        int numPassed =
                            (from grade in gradePool
                             where (grade.Dept == c.DeptCode) && (grade.Course == c.CourseNum.ToString()) &&
                             (grade.LetterGrade.CompareGrade(selectedGrade) <= 0) &&
                             (grade.LetterGrade != "F")
                             select grade).Count();

                        double passPercentage = (numPassed * 1.0) / numEnrolled;

                        passOutput.Append("Out of " + numEnrolled);
                        passOutput.Append(" enrolled in " + c.DeptCode + "-" + c.CourseNum + ", ");
                        passOutput.Append(numPassed + " passed at or above this threshold (");
                        passOutput.Append(String.Format("{0:0.00%}", passPercentage));
                        passOutput.AppendLine(")\n");
                    } // end else greater than

                } // end foreach course

                passOutput.Append("\n\n### END RESULTS ###");
            } // end if bothSelected

            MainOutputBox.Text = passOutput.ToString();

        } // End GradeForm.ResultsButton6_Click method

    } // end GradeForm class
} // end Assign3 namespace
