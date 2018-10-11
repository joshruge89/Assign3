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

        } //PopulateMajorComboBox End



        private void ResultsButton1_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();
            MainOutputBox.Text = "Button 1";

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

        private void ResultsButton2_Click(object sender, EventArgs e)
        {
            MainOutputBox.Clear();
            MainOutputBox.Text = "Button 2";

            if (check1)
            {
                MainOutputBox.Text = "Great!";
      //          var 
            }

            else 
            {
                MainOutputBox.Text = "Less!";

                string splitString = textBox1.Text;
                string[] argList = splitString.Split(' ');

                var studmatches =
                    from grade in gradePool
                    where (grade.LetterGrade.CompareTo(GradeComboBox1.SelectedItem.ToString()) <= 0)
                    && (grade.Dept == argList[0])
                    && (grade.Course == argList[1])
                    select grade;

                
                StringBuilder sb = new StringBuilder("Single Course Grade Report  (" + CourseBox2.Text + ")");
                sb.AppendLine("\n-----------------------------------------------------------------------");

                foreach (Grade g in studmatches)
                {       
                        sb.AppendLine(g.BuildGradeListing());
                }

                sb.AppendLine("\n\n ### END RESULTS ###");

                MainOutputBox.Text = sb.ToString();

            }


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

            string splitString = CourseBox2.Text;
            String[] argList = splitString.Split(' ');

            var courseMatches =
                from grade in gradePool
                where grade.Dept == argList[0] 
                && grade.Course == argList[1]
                select grade; 

            filteredCoursePool.Clear();
            StringBuilder sb = new StringBuilder("Single Course Grade Report  (" + CourseBox2.Text + ")");
            sb.AppendLine("\n-----------------------------------------------------------------------");

            foreach (Grade g in courseMatches)
            {
                sb.AppendLine(g.BuildGradeListing());
            }

            sb.AppendLine("\n\n ### END RESULTS ###");

            MainOutputBox.Text = sb.ToString();
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

        private void GreaterButton1_CheckedChanged(object sender, EventArgs e)
        {
            check1 = true;
        }

        private void lessButton1_CheckedChanged(object sender, EventArgs e)
        {
            check1 = false;
        }
    }
}
