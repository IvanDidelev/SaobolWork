using SaobolWork;
using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Employee[] employee = new Employee[10]
        {
        new Employee("Диделев", "Иван", "Сергеевич", "BebraCorp", 1500000),
        new Employee("Искандаров", "Аслан", "Юлдашевич", "BebraCorp", 250000),
        new Employee("Галичкин", "Дмитрий", "Игоревич", "BebraCorp", 150),
        new Employee("Деревнин", "Антон", "Сергеевич", "BebraCorp", 2150000),
        new Employee("Башлыков", "Андрей", "Павлович", "BebraCorp", 666000),
        new Employee("Грибцов", "Артем", "Андреевич", "SaobolINC", 800000),
        new Employee("Родионов", "Дмитрий", "Андреевич", "SaobolINC", 5000),
        new Employee("Барсуков", "Данил", "Андреевич", "SaobolINC", 3000),
        new Employee("Гайкович", "Антон", "Алексеевич", "SaobolINC", 823000),
        new Employee("Сухов", "Илья", "Юрьевич", "SaobolINC", 110000),
        };

        var empBook = new EmployeeBook(employee);

        empBook.EmployeeList();
        Console.WriteLine("______________________________");

        empBook.SellarySum();
        Console.WriteLine("______________________________");

        empBook.MinSell();
        Console.WriteLine("______________________________");

        empBook.MaxSell();
        Console.WriteLine("______________________________");

        empBook.AverageSalary(employee);
        Console.WriteLine("______________________________");

        empBook.GetFullName(employee);
        Console.WriteLine("______________________________");

        empBook.SalaryIndexing(employee);
        Console.WriteLine("______________________________");

        empBook.EmployeeWithMinSel(employee);
        Console.WriteLine("______________________________");

        empBook.EmployeeWithMaxSel(employee);
        Console.WriteLine("______________________________");

        empBook.AverageSalaryByDepartament(employee);
        Console.WriteLine("______________________________");

        empBook.DepSalaryIndexing(employee);
        Console.WriteLine("______________________________");

        empBook.OutputEmploeeOfDepartament(employee);
        Console.WriteLine("______________________________");

        empBook.EmploeeWithSelaryMinGetNum(employee);
        Console.WriteLine("______________________________");

        empBook.EmploeeWithSelaryMoreOrEquallyGetNum(employee);
        Console.WriteLine("______________________________");

        empBook.AddNewEmployee(employee);
        Console.WriteLine("______________________________");
        
        empBook.EmployeeList();
        Console.WriteLine("______________________________");

        empBook.DeleteEmployee(employee);
        Console.WriteLine("______________________________");

        empBook.EmployeeList();
        Console.WriteLine("______________________________");

        empBook.сhangeSalary(employee);
        Console.WriteLine("______________________________");
        
        empBook.EmployeeList();
        Console.WriteLine("______________________________");

        empBook.cangeDeparatment(employee);
        Console.WriteLine("______________________________");

        empBook.EmployeeList();
        Console.WriteLine("______________________________");

        empBook.getTheNameOfTheEmployeeByDepartment(employee);
        Console.WriteLine("______________________________");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("А на этои все! Спасибо за проверку!");

        Console.ReadKey();
    }
}







