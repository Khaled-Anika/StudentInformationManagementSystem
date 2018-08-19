using Newtonsoft.Json;
using StudentLibrary;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace StudentSystem
{
    class StudentInfo
    {
        Students c = new Students();
        public void GetStudentDetail()
        {
            List<Students> everyStudent = StudentDetail.GetAllStudent();

            try
            {
                foreach (var v in StudentDetail.deserialized)
                {
                    Console.WriteLine("Name: {0} {1} {2}" , v.firstName , v.middleName  , v.lastName);
                    Console.WriteLine("ID: " + v.id);
                    foreach (var item in v.semestersAttended)
                    {
                        Console.WriteLine("Semesters Attended: " + item.semesterCode + " " + item.year);
                    }
                    foreach (var item in v.coursesTaken)
                    {
                        foreach(var course in item)
                        {
                            Console.WriteLine("Courses: " + course.courseName);
                        }  
                    }
                    Console.WriteLine("Department: " + v.dept);
                    Console.WriteLine("Degree: " + v.deg);
                    Console.WriteLine("----***----");
                }
            }
            catch(Exception)
            {
                throw;
            }

            SemesterCourseAddition ad = new SemesterCourseAddition();

            Console.WriteLine("Will you 'Add Semester' or 'exit' ?");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "Add Semester":
                    Console.WriteLine("//Add New Semester: \n");
                    ad.addSemester();
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("\ninvalid option\n");
                    break;
            }
        }   
    }
}
