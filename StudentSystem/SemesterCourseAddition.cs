using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StudentLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    class SemesterCourseAddition
    {
        List<Courses> listCrs = new List<Courses>();

        public void addSemester()
        {
            Console.Write("Enter Student Id: ");
            string studentId = Console.ReadLine();
            Students stdnts = StudentDetail.studentList.Where(s => s.id == studentId).FirstOrDefault();
            List<Courses> courseList = new List<Courses>();

            Console.WriteLine("how many course you wanna add ? ");
            int num = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < StudentDetail.allCourseList.Count; i++)
            {
                if (!listCrs.Any(n => n.courseId == StudentDetail.allCourseList[i].courseId))
                {
                    //  Console.WriteLine("the Course named {0} is already taken ", StudentDetail.allCourseList[i].courseName);
                    Console.WriteLine("Currently Available Course: " + StudentDetail.allCourseList[i].courseName);
                }
            }

            for (int i = 0; i<num; i++)
            {
                Courses crs = new Courses();
                Console.Write("Enter Course Name: ");
                string crsName = Console.ReadLine();
                crs = StudentDetail.allCourseList.Where(courseItem => courseItem.courseName.Equals(crsName)).FirstOrDefault();
                courseList.Add(crs);
            }

            Console.Write("Semester Name: ");
            string semName = Console.ReadLine();
            Console.Write("Sem Year: ");
            string yr = Console.ReadLine();

            if(stdnts.semestersAttended.Any(sems => sems.semesterCode.Equals(semName) && sems.year.Equals(yr)))
            {
                Console.WriteLine("This semester is already registerd!!");
            }
            else
            {
                stdnts.semestersAttended.Add(new Semesters()
                {
                    semesterCode = semName,
                    year = yr
                });
                stdnts.coursesTaken.Add(courseList);
                StudentDetail.StoreToFile();

                foreach (var item in stdnts.coursesTaken)
                {
                    StudentDetail.coursesPerSem.Add(item);
                }
                foreach (var courses in StudentDetail.coursesPerSem)
                {
                    foreach (var course in courses)
                    {
                        listCrs.Add(course);
                    }
                }
                Console.WriteLine("Semester and Course added");
            }
        }
    }
}
