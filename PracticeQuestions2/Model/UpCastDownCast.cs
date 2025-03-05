using System;

// Base class
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Derived class
class Student : Person
{
    public int StudentID { get; set; }

    public Student(string name, int age, int studentID) : base(name, age)
    {
        StudentID = studentID;
    }

    public override void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, StudentID: {StudentID}");
    }
}

