using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinQ_2
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> listStudents = new List<Student>();

            Student student1 = new Student
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };
            listStudents.Add(student1);

            Student student2 = new Student
            {
                ID = 101,
                Name = "Mery",
                Gender = "Female"
            };
            listStudents.Add(student2);

            Student student3 = new Student
            {
                ID = 101,
                Name = "Jon",
                Gender = "Male"
            };
            listStudents.Add(student3);

            Student student4 = new Student
            {
                ID = 101,
                Name = "Bill",
                Gender = "Male"
            };
            listStudents.Add(student4);

            return listStudents;
        }
    }
}