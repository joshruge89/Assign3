﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GradeForm());
        }
    }

    public static class StringExtensions
    {
        public static int CompareGrade(this string grade1, string grade2)
        {
          int weight1, weight2;

          weight1 = Grade.findGradeWeight(grade1);
          weight2 = Grade.findGradeWeight(grade2);

          if (weight1 > weight2) {
            return -1;
          } else if (weight1 < weight2) {
            return 1;
          } else {
            return 0;
          }
        }
    }
}
