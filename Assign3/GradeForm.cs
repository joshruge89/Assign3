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
using System.Windows.Forms;

namespace Assign3
{
    public partial class GradeForm : Form
    {
        public GradeForm()
        {
            InitializeComponent();
            PositionAndSizeFrame();

            Student.BuildStudentPool();
            Course.BuildCoursePool();
            Grade.BuildGradePool();

            BuildMajorPool();

            PopulateGradeComboBox();
            PopulateMajorComboBox(); 
        }

    }
}
