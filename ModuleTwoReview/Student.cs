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
                total += grade;

            return total / Grades.Count;
        }
    }
}