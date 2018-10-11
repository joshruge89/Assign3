using System;
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

            if (grade1[0] < grade2[0]) return -1;
            if (grade1[0] > grade2[0]) return 1;

            if (grade1.Length > grade2.Length && grade1[1] == '+') return -1;
            if (grade1.Length > grade2.Length && grade1[1] == '-') return 1;

            if (grade1.Length < grade2.Length && grade2[1] == '+') return 1;
            if (grade1.Length < grade2.Length && grade2[1] == '-') return -1;

            if (grade1.Length > 1 && grade1[1] == '+' && grade2[1] != '+') return -1;

            return grade1.CompareTo(grade2);
           
        }
    }
}
