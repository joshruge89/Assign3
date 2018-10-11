using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Assign3
{
    public partial class GradeForm
    {
      public static SortedSet<Student> studentPool = new SortedSet<Student>();
      public static SortedSet<Student> filteredStudentPool = new SortedSet<Student>();

      public static SortedSet<Course> coursePool = new SortedSet<Course>();
      public static SortedSet<Course> filteredCoursePool = new SortedSet<Course>();

      public static SortedSet<string> majorPool = new SortedSet<string>();
      public static SortedSet<string> deptPool = new SortedSet<string>();

      public static string[] gradePool = {"A+","A","A-","B+","B","B-","C++","C","C-","D+","D","D-","F" };
    }
}
