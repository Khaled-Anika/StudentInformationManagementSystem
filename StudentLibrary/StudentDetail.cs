using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public static class StudentDetail
    {
        public static List<Students> studentList = new List<Students>();
        public static List<Students> deserialized = new List<Students>();
        public static List<Courses> allCourseList = new List<Courses>();
        public static List<List<Courses>> coursesPerSem = new List<List<Courses>>();

        public static void StoreToFile()
        {
            try
            {
                string j = JsonConvert.SerializeObject(studentList);
                File.WriteAllText(@"f:\intern\StudentInfo.json", j);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ReadFromFile()
        {
            try
            {
                string jsonStudent = File.ReadAllText(@"f:\intern\StudentInfo.json");
                deserialized = JsonConvert.DeserializeObject<List<Students>>(jsonStudent);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Students> GetAllStudent()
        {
            ReadFromFile();
            List<Students> allStudent = new List<Students>();
            try
            {
                foreach (var obj in deserialized)
                {
                    Students student = new Students();
                    student.firstName = obj.firstName;
                    student.middleName = obj.middleName;
                    student.lastName = obj.lastName;
                    student.id = obj.id;
                    student.dept = obj.dept;
                    student.deg = obj.deg;
                    student.semestersAttended = obj.semestersAttended;
                    student.coursesTaken = obj.coursesTaken;
                    allStudent.Add(student);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return allStudent;
        }
    }
}
