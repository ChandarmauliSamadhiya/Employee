using System;

class Employee
{
    
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }


    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Salary: ${Salary}");
    }
}

class Program
{
    static void Main(string[] args)
    {
 
        Employee employee1 = new Employee("Chandarmauli", 23, 20000);


        Console.WriteLine("Employee Details:");
        employee1.DisplayDetails();
        Console.ReadLine();
    }
 
}
