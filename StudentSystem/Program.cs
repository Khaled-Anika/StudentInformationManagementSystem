using StudentLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfStudentDetail students = new ListOfStudentDetail();

            List<Students> everyStudent = StudentDetail.GetAllStudent();
            Console.WriteLine("Current Students List: ");
            try
            {
                foreach (var v in StudentDetail.deserialized)
                {
                    Console.Write("Name: {0} {1} {2}", v.firstName, v.middleName, v.lastName);
                    Console.Write(" , ");
                    Console.Write("ID: " + v.id + "\n");
                    Console.WriteLine("=======");
                }
            }
            catch (Exception)
            {
                throw;
            }

            students.SetupData();

            Console.ReadLine();
        }
    }
}
