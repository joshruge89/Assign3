using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    public class Grade
    {
        private string zid;
        private string dept;
        private string course;
        private string letterGrade;

        public string Zid { get; set; }
        public string Dept { get; set; }
        public string Course { get; set; }
        public string LetterGrade { get; set; }
 
        public Grade(string newZid, string newDept, string newCourse, string newGrade)
        {
            Zid = newZid;
            Dept = newCourse;
            Course = newCourse;
            LetterGrade = newGrade;
        }


    }
}
