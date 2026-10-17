
using Employee_Management_System;
using System;

public class FullTimeEmployee : Employee, IWorkable
{
    public FullTimeEmployee(int id, string name, decimal salary) : base(id, name)
    {
        Salary = salary;
    }

    public override decimal CalculateSalary()
    {
        return Salary;
    }

    public void Work()
    {
        Console.WriteLine(Name + " is a full-time worker.");
    }
}
