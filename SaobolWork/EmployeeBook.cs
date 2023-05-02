using System;

namespace SaobolWork
{
    public class EmployeeBook
    {
        private readonly List<Employee> _employees = new();

        public EmployeeBook(Employee[] employees)
        {
            _employees.AddRange(employees);
        }

        public void EmployeeList()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Полная информация о сотрудниках: ");
            foreach (var employee in _employees)
            {
                Console.WriteLine($"{employee.Id}. {employee.Name} {employee.LastName} {employee.MiddleName}| Фирма: {employee.Departament}| З/П:{employee.EmployeeSalary}");
            }
        }

        public void SellarySum()
        {
            double SumSell = 0;

            foreach (var Sum in _employees)
            {
                SumSell += Sum.EmployeeSalary;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Общая сумма З/П: {SumSell} ");
        }

        public void MinSell()
        {
            Employee employee = _employees[0];

            double Min = _employees.Min(x => x.EmployeeSalary);

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"Сотрудник с минимальной З/П: {Min}");
        }

        public void MaxSell()
        {
            Employee employee = _employees[0];

            double Max = _employees.Max(x => x.EmployeeSalary);

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine($"Сотрудник с максимальной З/П: {Max}");
        }

        public void AverageSalary(Employee[] employees)
        {
            double totalSalary = 0;

            foreach (var employee in employees)
            {
                totalSalary += employee.EmployeeSalary;
            }
            double averageSalary = totalSalary / employees.Length;

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine($"Средняя З/П сотрудников: {averageSalary}");

        }

        public void GetFullName(Employee[] employees)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ФИО всех сотрудников:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name} {employee.LastName} {employee.MiddleName}");
            }

        }

        public void SalaryIndexing(Employee[] employees)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Введите процент индексации: ");
            double indxPercent = double.Parse(Console.ReadLine());

            foreach (var emploee in employees)
            {
                emploee.EmployeeSalary += (emploee.EmployeeSalary * indxPercent) / 100;
                Console.WriteLine($"{emploee.LastName} {emploee.Name} {emploee.MiddleName}|З/П после индексации:  {emploee.EmployeeSalary}");
            }


        }

        public void EmployeeWithMinSel(Employee[] employees)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Введите название отдела(BebraCorp,SaobolINC):");
            string dep = Console.ReadLine();
            double minSalaryCorp = 0;
            double minSalaryINC = 0;

            foreach (var employee in employees)
            {
                if (employee.Departament == dep)
                {
                    if (employee.Departament == "BebraCorp")
                    {
                        minSalaryCorp = employees.Where(employees => employees.Departament == "BebraCorp").Min(employees => employees.EmployeeSalary);
                    }

                    if (employee.Departament == "SaobolINC")
                    {
                        minSalaryINC = employees.Where(employees => employees.Departament == "SaobolINC").Min(employees => employees.EmployeeSalary);
                    }
                }
            }
            if (minSalaryCorp > 0)
            {
                Console.WriteLine($"Сотрудник отдела BebraCorp с минимальной З/П в {minSalaryCorp} руб.");
            }
            if (minSalaryINC > 0)
            {
                Console.WriteLine($"Сотрудник отдела SaobolINC с минимальной З/П в {minSalaryINC} руб.");
            }


        }

        public void EmployeeWithMaxSel(Employee[] employees)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Введите название отдела(BebraCorp,SaobolINC):");
            string dep = Console.ReadLine();

            double minSalaryCorp = 0;
            double minSalaryINC = 0;
            foreach (var employee in employees)
            {

                if (employee.Departament == dep)
                {
                    if (employee.Departament == "BebraCorp")
                    {
                        minSalaryCorp = employees.Where(employees => employees.Departament == "BebraCorp").Max(employees => employees.EmployeeSalary);

                    }

                    if (employee.Departament == "SaobolINC")
                    {
                        minSalaryINC = employees.Where(employees => employees.Departament == "SaobolINC").Max(employees => employees.EmployeeSalary);

                    }
                }
            }
            if (minSalaryCorp > 0)
            {
                Console.WriteLine($"Сотрудник отдела BebraCorp с максимальной З/П в {minSalaryCorp} руб.");

            }
            if (minSalaryINC > 0)
            {
                Console.WriteLine($"Сотрудник отдела SaobolINC с максимальной З/П в {minSalaryINC} руб.");
            }
        }

        public void AverageSalaryByDepartament(Employee[] employees)
        {
            var groupByDepartament = employees.GroupBy(x => x.Departament);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Средняя З/П сотрудников по каждому отделу: ");

            foreach (var departament in groupByDepartament)
            {
                double totalSalary = 0;
                double averageSalary = 0;

                foreach (var employee in departament)
                {
                    totalSalary += employee.EmployeeSalary;
                }
                averageSalary = totalSalary / departament.Count();
                Console.WriteLine($"Отдел: {departament.Key}  |  Средняя З/П: {averageSalary}");
            }

        }

        public void DepSalaryIndexing(Employee[] employees)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Введите название отдела(BebraCorp,SaobolINC):");
            string dep = Console.ReadLine();

            switch (dep)
            {
                case "BebraCorp":
                    {
                        double userInputCorp;
                        Console.Write("Введите величину аргумента в % для индексации зарплаты: ");
                        userInputCorp = double.Parse(Console.ReadLine());
                        Console.WriteLine($"\nЗарплата увеличилась на {userInputCorp}%, и составляет:");
                        foreach (var emploee in employees)
                        {
                            if (emploee.Departament == "BebraCorp")
                            {
                                Console.WriteLine($"{emploee.Id}. {emploee.LastName} {emploee.Name} {emploee.MiddleName} | {emploee.EmployeeSalary + emploee.EmployeeSalary * userInputCorp / 100} руб.");
                            }
                        }
                        break;
                    }

                case "SaobolINC":
                    {
                        double userInputINC;
                        Console.Write("Введите величину аргумента в % для индексации зарплаты: ");
                        userInputINC = double.Parse(Console.ReadLine());
                        Console.WriteLine($"\nЗарплата увеличилась на {userInputINC}%, и составляет:");
                        foreach (var emploee in employees)
                        {
                            if (emploee.Departament == "SaobolINC")
                            {
                                Console.WriteLine($"{emploee.Id}. {emploee.LastName} {emploee.Name} {emploee.MiddleName} | {emploee.EmployeeSalary + emploee.EmployeeSalary * userInputINC / 100} руб.");
                            }
                        }

                        break;
                    }

                default:
                    {
                        Console.WriteLine("Такого отдела не существует");
                        break;
                    }
            }
        }

        public void OutputEmploeeOfDepartament(Employee[] employees)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Введите название отдела(BebraCorp,SaobolINC):");
            string dep = Console.ReadLine();

            switch (dep)
            {
                case "BebraCorp":
                    {
                        Console.WriteLine("Список сотрудников отдела BebraCorp: ");
                        foreach (var emploee in employees)
                        {
                            if (emploee.Departament == "BebraCorp")
                            {
                                Console.WriteLine($"{emploee.Id}. {emploee.LastName} {emploee.Name} {emploee.MiddleName} ");
                            }
                        }
                        break;
                    }

                case "SaobolINC":
                    {
                        Console.WriteLine("Список сотрудников отдела SaobolINC: ");
                        foreach (var emploee in employees)
                        {
                            if (emploee.Departament == "SaobolINC")
                            {
                                Console.WriteLine($"{emploee.Id}. {emploee.LastName} {emploee.Name} {emploee.MiddleName} ");
                            }
                        }
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Такого отдела не существует");
                        break;
                    }
            }
        }

        public void EmploeeWithSelaryMinGetNum(Employee[] employees)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите название отдела(BebraCorp,SaobolINC):");
            string dep = Console.ReadLine();
                Console.Write("Введите число что-бы получить сотрудника с З/П меньше этого числа: ");
                double userInput = double.Parse(Console.ReadLine());

            switch (dep)
            {
                case "BebraCorp":
                    {
                        foreach (var emploee in employees)
                        {
                            if (emploee.Departament == "BebraCorp")
                            {
                                if (emploee.EmployeeSalary < userInput)
                                {
                                    Console.WriteLine($"{emploee.Id}. {emploee.LastName} {emploee.Name} {emploee.MiddleName}|З/П : {emploee.EmployeeSalary} ");
                                }
                            }
                        }
                        break;
                    }

                case "SaobolINC":
                    {
                        foreach (var emploee in employees)
                        {
                            if (emploee.Departament == "SaobolINC")
                            {
                                if (emploee.EmployeeSalary < userInput)
                                {
                                    Console.WriteLine($"{emploee.Id}. {emploee.LastName} {emploee.Name} {emploee.MiddleName}|З/П : {emploee.EmployeeSalary} ");
                                }
                            }
                        }
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Такого отдела не существует");
                        break;
                    }
            }




        }

        public void EmploeeWithSelaryMoreOrEquallyGetNum(Employee[] employees)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Введите название отдела(BebraCorp,SaobolINC):");
            string dep = Console.ReadLine();
                Console.Write("Введите число что-бы получить сотрудника с З/П больше(или равно) этому числу: ");
                double userInput = double.Parse(Console.ReadLine());

            switch (dep)
            {
                case "BebraCorp":
                    {
                        foreach (var emploee in employees)
                        {
                            if (emploee.Departament == "BebraCorp")
                            {
                                if (emploee.EmployeeSalary >= userInput)
                                {
                                    Console.WriteLine($"{emploee.Id}. {emploee.LastName} {emploee.Name} {emploee.MiddleName}|З/П : {emploee.EmployeeSalary} ");
                                }
                            }
                        }
                        break;
                    }

                case "SaobolINC":
                    {
                        foreach (var emploee in employees)
                        {
                            if (emploee.Departament == "SaobolINC")
                            {
                                if (emploee.EmployeeSalary >= userInput)
                                {
                                    Console.WriteLine($"{emploee.Id}. {emploee.LastName} {emploee.Name} {emploee.MiddleName}|З/П : {emploee.EmployeeSalary} ");
                                }
                            }
                        }
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Такого отдела не существует");
                        break;
                    }
            }




        }

        public void AddNewEmployee(Employee[] employees)
        {
            Console.WriteLine("Введите данные нового сотрудника: ");
            Console.Write("Введите Фамилию:");
            string LastName = Console.ReadLine();
            Console.Write("Введите Имя:");
            string Name = Console.ReadLine();
            Console.Write("Введите Отчество:");
            string MiddleName = Console.ReadLine();
                Console.Write("Введите отдел: ");
                string newDep = Console.ReadLine();
                    Console.Write("Введите З/П: ");
                    double newEmpSel = double.Parse(Console.ReadLine());
            bool add = true;

            for (int i = 0; i < _employees.Count; i++)
            {
                if (i != _employees[i].Id)
                {
                    _employees.Insert(i, new Employee(LastName, Name, MiddleName, newDep, newEmpSel));
                    add = false;
                }
            }
            if (add)
            {
                _employees.Add(new Employee(LastName, Name, MiddleName, newDep, newEmpSel));
                _employees[_employees.Count - 1].Id = _employees.Count - 1;
            }
        }

        public void DeleteEmployee(Employee[] employee)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Введите индекс по которому нужно удалить работника: ");
            int delIndx = int.Parse(Console.ReadLine());

            if (delIndx >= 0 && delIndx < _employees.Count)
            {
                _employees.RemoveAt(delIndx);
                for (int i = delIndx; i < _employees.Count; i++)
                {
                    _employees[i].Id = i;
                }
            }
        }

        public void сhangeSalary(Employee[] employee)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Введите Фамилию для изменения З/П: ");
                    string empLastName = Console.ReadLine();
            Console.Write("Введите новую З/П: ");
                int newSal = int.Parse(Console.ReadLine());

            foreach (var e in _employees)
            {
                if (e.LastName == empLastName)
                {
                    e.EmployeeSalary = newSal;
                }
            }

        }

        public void cangeDeparatment(Employee[] employee)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Введите Фамилию для изменения отдела: ");
            string empLastName = Console.ReadLine();
            Console.Write("Введите новый департамент: ");
            string newDep = Console.ReadLine();

            foreach (var e in _employees)
            {
                if (e.LastName == empLastName)
                {
                    e.Departament = newDep;
                }
            }
        }

        public void getTheNameOfTheEmployeeByDepartment(Employee[] employee)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Вывести ФИО всех сотрудников по отделам?(Да/Нет): ");
            string userInput = Console.ReadLine();
            
            switch (userInput)
            {
             case "Да":
                {   
                   Console.ForegroundColor = ConsoleColor.Yellow;
                   Console.WriteLine("\nСотрудника отдела BebraCorp: ");
                                                
                   foreach (var emp in _employees)
                   {
                       if (emp.Departament == "BebraCorp")
                       {
                         Console.WriteLine($"{emp.LastName} {emp.Name} {emp.MiddleName}");
                       }
                   }

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nСотрудника отдела SaobolINC: ");
                        
                   foreach (var emp in _employees)
                   {
                     if (emp.Departament == "SaobolINC")
                     {
                       Console.WriteLine($"{emp.LastName} {emp.Name} {emp.MiddleName}");
                     }
                   }
                        break;
                }
                   
             case "Нет":
             {
               Console.WriteLine("Тогда на этом конец, спасибо за проверку рвботы!");
               break;
             }

            }
        }
    }

}



