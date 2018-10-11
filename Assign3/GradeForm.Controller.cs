using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;

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
        * Use Case: 
        ******************************************************/
        private void ResultsButton1_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();

            var gradeMatches =
                from grade in gradePool
                where grade.Zid == ZidBox.Text
                orderby grade.Dept
                select grade;

            filteredStudentPool.Clear();

            StringBuilder sb = new StringBuilder("Single Student Grade Report  (" + ZidBox.Text + ")");
            sb.AppendLine("\n-----------------------------------------------------------------------");

            foreach (Grade g in gradeMatches)
            {
                sb.AppendLine(g.BuildGradeListing());
            }

            sb.AppendLine("\n\n ### END RESULTS ###");

            MainOutputBox.Text = sb.ToString();
        }

        /*******************************************************
        * Button 2 click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
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


                    StringBuilder sb = new StringBuilder("Single Course Grade Report  (" + CourseBox2.Text.ToUpper() + ")");
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

                    StringBuilder sb = new StringBuilder("Single Course Grade Report  (" + CourseBox2.Text.ToUpper() + ")");
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
        }

        /*******************************************************
        * Button 3 click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void ResultsButton3_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();
            MainOutputBox.Text = "Button 3";

            var studentSelected =
                from student in studentPool
                where student.Major == MajorComboBox.Text.ToString()
                select student;

            filteredStudentPool.Clear();

            foreach (Student s in studentSelected)
            {
                filteredStudentPool.Add(s);
            }

            string tester = "F";
            var selection2 =
                from s in filteredStudentPool
                from g in gradePool
                where s.Zid.ToString() == g.Zid
                && g.LetterGrade == tester 
                select s;

            StringBuilder sb = new StringBuilder("Single Course Grade Report  (" + ZidBox.Text + ")");
            sb.AppendLine("\n-----------------------------------------------------------------------");

            foreach (Student g in selection2)
            {
                sb.AppendLine(g.FirstName + ", " + g.LastName);
            }

            sb.AppendLine("\n\n ### END RESULTS ###");

            MainOutputBox.Text = sb.ToString();
        }

        /*******************************************************
        * Button 4 click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
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
        }

        /*******************************************************
        * Button 5 click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/

        private void ResultsButton5_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();
            MainOutputBox.Text = "Button 5";
        }

        /*******************************************************
        * Button 6 click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void ResultsButton6_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();
            StringBuilder passOutput = new StringBuilder();
            bool bothSelected = true;

            if (GradeComboBox2.SelectedIndex == -1)
            {
                passOutput.AppendLine("Error! Please Select a Grade.");
                bothSelected = false;
            }

            if (!LessButton3.Checked && !GreaterButton3.Checked)
            {
                passOutput.AppendLine("Error! Please Select Less Than or Greater Than.");
                bothSelected = false;
            }
 
            if (bothSelected == true)
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
                        passOutput.AppendLine("%)");
                    } else
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
                        passOutput.AppendLine("%)");
                    }

                }
            }

            MainOutputBox.Text = passOutput.ToString();
         }
    }
}
