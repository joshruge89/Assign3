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
using System.Collections.Generic;

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

      public static List<Grade> gradePool = new List<Grade>();      
      public static string[] grades = {"A+","A","A-","B+","B","B-","C++","C","C-","D+","D","D-","F"};
    }
}
