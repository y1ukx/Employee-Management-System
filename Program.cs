
using System;

class Program
{
    static void Main()
    {
        FullTimeEmployee ahmad = new FullTimeEmployee(1, "Ahmad", 1200);

        PartTimeEmployee omar = new PartTimeEmployee(2, "Omar", 50, 8);

        Employee[] employees = { ahmad, omar };

        foreach (Employee employee in employees)
        {
            employee.DisplayInfo();
            Console.WriteLine("--------------------");
        }

        ahmad.Work();
        omar.Work();
    }
}
