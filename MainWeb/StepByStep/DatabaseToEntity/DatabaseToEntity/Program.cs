using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseToEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolContainer school = new SchoolContainer();

            DbSet<Student> students = school.Students;

            foreach(Student s in students)
            {
                Console.WriteLine(s.EnrollmentDate);
                Console.WriteLine(s.LastName);
                Console.WriteLine(s.FirstMidName);
            }
        }
    }
}
