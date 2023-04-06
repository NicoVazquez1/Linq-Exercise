using System;
using System.Collections.Generic;

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }
    public DateTime HireDate { get; set; }

    public Employee(string name, int age, string position, double salary, DateTime hireDate)
    {
        Name = name;
        Age = age;
        Position = position;
        Salary = salary;
        HireDate = hireDate;
    }
}
