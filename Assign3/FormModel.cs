using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    class FormModel
    {
        public static SortedSet<Student> studentPool = new SortedSet<Student>();
        public static SortedSet<Course> coursePool = new SortedSet<Course>();
        public static SortedSet<string> majorPool = new SortedSet<string>();

        public static string[] gradePool = { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F", "W"};
    }
}
