using System;
using System.Collections.Generic;

namespace StudentGradesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student { ID = 1, Name = "Ben Savage" };
            Student student2 = new Student { ID = 2, Name = "Brian Smith" };
            Student student3 = new Student { ID = 3, Name = "Carla Gomez" };
            Student student4 = new Student { ID = 4, Name = "David Brown" };

            students.AddRange(new[] { student1, student2, student3, student4 });

            student1.AddGrade(94.3);
            student1.AddGrade(90.0, 78.9, 95.4);
            student2.AddGrade(88.5);
            student2.AddGrade(92.1, 85.0);
            student3.AddGrade(100.0);
            student3.AddGrade(98.3, 96.7);
            student4.AddGrade(75.0);
            student4.AddGrade(80.5, 70.2, 68.9);

            Console.WriteLine("\n--- STUDENT INFORMATION ---");
            foreach (Student student in students)
            {
                Console.WriteLine($"\nID: {student.ID} | Name: {student.Name}");
                Console.Write("Grades: ");
                Console.WriteLine(string.Join(", ", student.Grades));
                Console.WriteLine($"Average Grade: {student.CalculateAverageGrade():F2}");
            }

            Console.WriteLine("\n--- COURSE ENROLLMENT DEMO ---");

            Course course = new Course
            {
                CourseName = "Intro to Software Engineering",
                CourseCode = "SE101"
            };

            course.EnrollStudent(student1);
            course.EnrollStudent(student2);
            course.EnrollStudent(student1);

            Console.WriteLine($"\nCourse: {course.CourseName} ({course.CourseCode})");
            Console.WriteLine("Enrolled Students:");
            foreach (Student s in course.EnrolledStudents)
            {
                Console.WriteLine($" - {s.Name} (ID: {s.ID})");
            }

            Console.WriteLine("\nPress ENTER to exit...");
            Console.ReadLine();
        }
    }
}
