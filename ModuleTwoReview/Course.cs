using System;
using System.Collections.Generic;

namespace StudentGradesApp
{
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public List<Student> EnrolledStudents { get; set; }

        public Course()
        {
            EnrolledStudents = new List<Student>();
        }

        public void EnrollStudent(Student student)
        {
            if (!EnrolledStudents.Exists(s => s.ID == student.ID))
            {
                EnrolledStudents.Add(student);
                Console.WriteLine($"{student.Name} has been enrolled in {CourseName}.");
            }
            else
            {
                Console.WriteLine($"{student.Name} is already enrolled in {CourseName}.");
            }
        }
    }
}