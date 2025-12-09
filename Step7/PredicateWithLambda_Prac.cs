using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

class Program7
{
    static void Main()
    {
        // Creating student list
        List<Student> students = new List<Student>
        {
            new Student { Name = "Sahithi", Age = 22, Marks = 85 },
            new Student { Name = "Kiran", Age = 17, Marks = 30 },
            new Student { Name = "Arun", Age = 25, Marks = 45 },
            new Student { Name = "Priya", Age = 19, Marks = 28 },
            new Student { Name = "Meena", Age = 20, Marks = 75 }
        };

        // =============================
        // 1️⃣ Predicate to check PASS
        // =============================
        Predicate<Student> isPassed = s => s.Marks >= 35;

        Console.WriteLine("=== Passed Students ===");
        var passedStudents = students.FindAll(isPassed);
        foreach (var s in passedStudents)
            Console.WriteLine($"{s.Name} - {s.Marks}");

        // =============================
        // 2️⃣ Predicate to find FIRST ADULT student
        // =============================
        Predicate<Student> isAdult = s => s.Age >= 18;

        var firstAdult = students.Find(isAdult);
        Console.WriteLine("\nFirst Adult Student: " + firstAdult.Name);

        // =============================
        // 3️⃣ Predicate to remove FAILED students
        // =============================
        Predicate<Student> isFailed = s => s.Marks < 35;

        int removedCount = students.RemoveAll(isFailed);
        Console.WriteLine($"\nRemoved failed students: {removedCount}");

        Console.WriteLine("\n=== After Removing Failed Students ===");
        foreach (var s in students)
            Console.WriteLine($"{s.Name} - {s.Marks}");

        // =============================
        // 4️⃣ Check if ALL students are ADULTS
        // =============================
        bool allAdults = students.TrueForAll(isAdult);
        Console.WriteLine("\nAre all students adults? " + allAdults);
    }
}
