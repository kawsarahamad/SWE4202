using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Course
    {
        public string course_code;
        public string course_title;
        public string course_type;
        public string course_sem;
        public string course_Teacher;

        public Course(string course_code, string course_title, string course_type, string course_sem, string course_Teacher)
        {
            this.course_code = course_code;
            this.course_title = course_title; 
            this.course_type = course_type;
            this.course_sem = course_sem;
            this.course_Teacher = course_Teacher;
        }
    }
}
