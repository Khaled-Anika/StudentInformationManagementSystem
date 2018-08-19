using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Students
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string id { get; set; }
        public Semesters joiningBatch { get; set; }
        public enum department
        {
            CS,
            BBA,
            ENGLISH
        };
        public department dept { get; set; }
        public enum degree
        {
            BSC,
            BBA,
            BA,
            MSC,
            MBA,
            MA
        }
        public degree deg { get; set; }
        public List<Semesters> semestersAttended = new List<Semesters>();
        public List<List<Courses>> coursesTaken = new List<List<Courses>>();

        //public Students()
        //{
        //    semesters = new List<Semesters>();
        //    courses = new List<Courses>();
        //}

    }
}
