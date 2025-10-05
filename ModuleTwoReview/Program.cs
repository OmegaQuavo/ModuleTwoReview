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