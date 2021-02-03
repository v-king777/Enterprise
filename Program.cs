using System;

namespace Enterprise
{
    class Employee
    {
        public Department Department;
        public string Name;
        public byte Age;
        public uint TabNum;
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
            Employee employee1 = GetEmployee();
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
            employee.TabNum = 87192;

            return employee;
        }
    }
}
