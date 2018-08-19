using Newtonsoft.Json;
using StudentLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    class ListOfStudentDetail
    {
        public void SetupData()
        {
            StudentAddition add = new StudentAddition();
            StudentInfo info = new StudentInfo();
            Deletion delete = new Deletion();

            Semesters sem1 = new Semesters
            {
                semesterCode = "Summer",
                year = "2001"
            };
            Semesters sem2 = new Semesters
            {
                semesterCode = "Fall",
                year = "2010"
            };

            Courses course1 = new Courses()
            {
                courseId = "CSC 901",
                courseName = "Data Mining",
                credits = 3,
                instructorName = "HAFIZ" 
            };
            Courses course2 = new Courses()
            {
                courseId = "CSC 102",
                courseName = "Algorithm",
                credits = 3,
                instructorName = "Shamsur Rahim"
            };
            Courses course3 = new Courses()
            {
                courseId = "CSC 201",
                courseName = "Discrete Math",
                credits = 3,
                instructorName = "Afsah Sharmin"
            };
            Courses course4 = new Courses()
            {
                courseId = "CSC 205",
                courseName = "Data Structure",
                credits = 3,
                instructorName = "Touhidul Islam"
            };

            List<Courses> courseList = new List<Courses>();
            courseList.Add(course1);

            Students student1 = new Students
            {
                firstName = "Sara",
                middleName = "Rahman",
                lastName = "Baker",
                id = "234-856-569",
                joiningBatch = new Semesters() { semesterCode = "Spring", year = "2015" },
                dept = Students.department.BBA,
                deg = Students.degree.BBA
            };
            student1.coursesTaken.Add(courseList);
            student1.semestersAttended.Add(sem1);

            Students student2 = new Students
            {
                firstName = "Zara",
                middleName = "Rahman",
                lastName = "Ali",
                id = "693-569-689",
                joiningBatch = new Semesters() { semesterCode = "Spring", year = "2009" },
                dept = Students.department.CS,
                deg = Students.degree.MSC
            };
            student2.coursesTaken.Add(courseList);
            student2.semestersAttended.Add(sem2);

            StudentDetail.studentList.Add(student1);
            StudentDetail.studentList.Add(student2);

            //StudentDetail.allCourseList.Add(course1);
            StudentDetail.allCourseList.Add(course2);
            StudentDetail.allCourseList.Add(course3);
            StudentDetail.allCourseList.Add(course4);

            StudentDetail.StoreToFile();

            Console.WriteLine("\nThere are 3 options: ");
            Console.WriteLine("Add New Student");
            Console.WriteLine("View Details");
            Console.WriteLine("Delete Student");

            Console.WriteLine("\nChoose any one---");

            //for (int i = 0; i < 3; i++)
            //{
            string choice = " " ;
            while (choice != "exit")
            {
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "Add New Student\n":
                        add.addStudent();
                        break;
                    case "View Details\n":
                        info.GetStudentDetail();
                        break;
                    case "Delete Student\n":
                        delete.deleteStudent();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
                Console.WriteLine("\nAnother choice left\n");
            }
          //  }
        }
    }
}
