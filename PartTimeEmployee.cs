
using Employee_Management_System;
using System;

public class PartTimeEmployee : Employee, IWorkable
{
    private decimal hoursWorked;
    private decimal hourlyRate;

    public PartTimeEmployee(int id, string name, decimal hours, decimal rate)
        : base(id, name)
    {
        hoursWorked = hours;
        hourlyRate = rate;
    }

    public override decimal CalculateSalary()
    {
        Salary = hoursWorked * hourlyRate;
        return Salary;
    }

    public void Work()
    {
        Console.WriteLine(Name + " Is a part-time worker.");
    }
}
