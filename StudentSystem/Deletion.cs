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
    class Deletion
    {
        public void deleteStudent()
        {
            string choice = " ";
            Console.WriteLine("Are you sure you wanna delete ??");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "Yes":
                    delete();
                    break;
                case "No":
                    break;
                default:
                    Console.WriteLine("invalid option");
                    break;
            }
        }

        public void delete()
        {
            Console.Write("Enter the student Id you wanna delete--");
            string stdId = Console.ReadLine();
            try
            {
                StudentDetail.studentList.Remove(StudentDetail.studentList.Where(i => i.id.Equals(stdId)).FirstOrDefault());
                string jsonStudent = JsonConvert.SerializeObject(StudentDetail.studentList);
                File.WriteAllText(@"f:\intern\StudentInfo.json", jsonStudent);
                Console.WriteLine("Record deleted successfully!");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
