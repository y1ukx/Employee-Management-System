
using System;

public abstract class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
        protected set { salary = value; }
    }

    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public abstract decimal CalculateSalary();

    public void DisplayInfo()
    {
        Console.WriteLine("ID: " + Id + ", Name: " + Name);
        Console.WriteLine("Salary: " + CalculateSalary() + " JOD");
    }
}
