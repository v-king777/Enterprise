using System;

namespace Enterprise
{
    class Employee
    {
        public Department Department;
        public string Name;
        public byte? Age;
        public uint? TabNum;
    }

    class Department
    {
        public Company Company;
        public string Name;
    }

    class Company
    {
        public string Name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = GetEmployee();

            Console.WriteLine("\t*Карточка сотрудника*\n");

            Console.WriteLine("Имя: {0}", employee.Name ?? "Нет данных!");

            if (employee.Age.HasValue)
            {
                Console.WriteLine("Возраст: {0}", employee.Age.Value);
            }
            else
            {
                Console.WriteLine("Возраст: Нет данных!");
            }

            if (employee.TabNum.HasValue)
            {
                Console.WriteLine("Табельный номер: {0}", employee.TabNum.Value);
            }
            else
            {
                Console.WriteLine("Табельный номер: Нет данных!");
            }

            Console.WriteLine("Отдел: {0}", employee.Department?.Name ?? "Нет данных!");

            Console.WriteLine("Компания: {0}", employee.Department?.Company?.Name ?? "Нет данных!");

            Console.ReadKey(true);
        }

        static Employee GetEmployee()
        {
            Company company = new Company();
            company.Name = "УРАЛХИМ";

            Department department = new Department();
            department.Company = company;
            department.Name = "ПКО";

            Employee employee = new Employee();
            employee.Department = department;
            employee.Name = "Владимир";
            employee.Age = 37;
            //employee.TabNum = 87192;

            return employee;
        }
    }
}
