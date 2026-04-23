

namespace methods.models;
internal class Emploey
{
    public double Salary { get; set; }

    public string JobTitle { get; set; }

    public string Name { get; set; }

    public double SalaryYear { get => Salary * 12; }

    public void ChangeJob(double newSalary)
    {

        Salary = newSalary;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Job Title: {JobTitle}, Salary: {Salary}, Yearly Salary: {SalaryYear}");
    }
}
