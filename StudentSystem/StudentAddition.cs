using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StudentLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentSystem
{
    class StudentAddition
    {
        // private string jsonFile = @"f:\intern\StudentInfo.json";
        Regex standartId = new Regex(@"\d{3}\-\d{3}\-\d{3}");

        public void addStudent()
        {
            Console.WriteLine("\nhow many students you wanna add?:");
            int n = Convert.ToInt16(Console.ReadLine()); 

            Console.Write("Enter Id First: ");
            string sId = Console.ReadLine();

            if(!standartId.IsMatch(sId))
            {
                Console.WriteLine("Please Follow the id Format: XXX-XXX-XXX");
                addStudent();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Now sequence of entries should be: \n firstname>middlename>lastname>joining batch(code>year)>dept>degree");

                    Students stud = new Students
                    {
                        firstName = Console.ReadLine(),
                        middleName = Console.ReadLine(),
                        lastName = Console.ReadLine(),
                        id = sId,
                        joiningBatch = new Semesters
                        {
                            semesterCode = Console.ReadLine(),
                            year = Console.ReadLine()
                        },
                        dept = (Students.department)Enum.Parse(typeof(Students.department), Console.ReadLine()),
                        deg = (Students.degree)Enum.Parse(typeof(Students.degree), Console.ReadLine())
                    };
                    //}
                    StudentDetail.studentList.Add(stud);

                    StudentDetail.StoreToFile();
                    Console.WriteLine("###ADDED###\n");
                }
            } 
        }
    }
}
