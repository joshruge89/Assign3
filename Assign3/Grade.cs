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
            Console.WriteLine(newCourse);
            Console.WriteLine(newDept);

            Zid = newZid;
            Dept = newDept;
            Course = newCourse;
            LetterGrade = newGrade;
        }

        public string BuildGradeListing()
        {
            StringBuilder sb = new StringBuilder(Zid + " | ");
            sb.Append(Dept + "-" + Course);
            sb.Append(" | " + LetterGrade);
            return sb.ToString();
        }
    }
}
