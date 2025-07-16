
using System;
using System.Collections.Generic;

class Student
{
    public int RollNo;
    public string Name;
    public int Marks;
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n---- Student Record System ----");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Search Student by Roll No");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    ViewStudents();
                    break;
                case 3:
                    SearchStudent();
                    break;
                case 4:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }

        } while (choice != 4);
    }

    static void AddStudent()
    {
        Student s = new Student();

        Console.Write("Enter Roll Number: ");
        s.RollNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        s.Name = Console.ReadLine();

        Console.Write("Enter Marks: ");
        s.Marks = Convert.ToInt32(Console.ReadLine());

        students.Add(s);

        Console.WriteLine("Student added successfully!");
    }

    static void ViewStudents()
    {
        Console.WriteLine("\nList of Students:");
        foreach (var s in students)
        {
            Console.WriteLine($"Roll No: {s.RollNo}, Name: {s.Name}, Marks: {s.Marks}");
        }
    }

    static void SearchStudent()
    {
        Console.Write("Enter Roll No to search: ");
        int rollNo = Convert.ToInt32(Console.ReadLine());

        Student found = students.Find(s => s.RollNo == rollNo);

        if (found != null)
        {
            Console.WriteLine($"Found: Roll No: {found.RollNo}, Name: {found.Name}, Marks: {found.Marks}");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }
}
