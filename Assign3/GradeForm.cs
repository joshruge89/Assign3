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
using System.Windows.Forms;

namespace Assign3
{
    public partial class GradeForm : Form
    {
        public GradeForm()
        {
            InitializeComponent();
            PositionAndSizeFrame();
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
    }
}
