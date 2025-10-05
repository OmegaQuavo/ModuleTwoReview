using System;
using System.Collections.Generic;

namespace StudentGradesApp
{
    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public List<double> Grades { get; set; }

        public Student()
        {
            Grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }

        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0)
                return 0;

            double total = 0;
            foreach (double grade in Grades)
            {
                total += grade;
            }

            return total / Grades.Count;
        }
    }
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
    
     class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student { ID = 1, Name = "Ben Savage" };
            Student student2 = new Student { ID = 2, Name = "Brian Smith" };
            Student student3 = new Student { ID = 3, Name = "Carla Gomez" };
            Student student4 = new Student { ID = 4, Name = "David Brown" };

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

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
                foreach (double grade in student.Grades)
                {
                    Console.Write($"{grade} ");
                }
                Console.WriteLine($"\nAverage Grade: {student.CalculateAverageGrade():F2}");
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
            Console.ReadLine(); // <-- Use ReadLine so the console stays open
        }

    }
}