using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one student object
            Student student = new Student();

            student.Firstname = "Teppo";
            student.Lastname = "Terävä";
            student.Address = "piippukatu 3";
            student.Age = 24;
            student.PhoneNumber = "010-123456";
            student.StudentID = "G2323";
            Console.WriteLine(student.ToString());

            Teacher teacher = new Teacher("Kirsi", "Kernel", "D566");
            teacher.Age = 35;
            teacher.Address = "Piippukatu 2";
            teacher.PhoneNumber = "010-987654";
            Console.WriteLine(teacher.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();


        }
    }
}
