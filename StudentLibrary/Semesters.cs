using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public enum SemName { Spring, Summer, Fall }
    public class Semesters
    {
        public string semesterCode { get; set; }
        public string year { get; set; }
       // public Courses course { get; set; }

        public string Show
        {
            get
            {
                return string.Format("{0} - {1}", semesterCode, year);
            }
        }
    }
}
