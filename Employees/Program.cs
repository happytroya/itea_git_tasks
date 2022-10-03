using System;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeSalary();
        }

        static void EmployeeSalary()
        {
            string employeeName;
            string employeeSalary;

            Console.WriteLine("Enter emplyees amount");
            int employeeAmount = int.Parse(Console.ReadLine());

            string[][] employeeTable = new string[employeeAmount][];

            for (int i = 0; i < employeeAmount; i++)
            {
                Console.WriteLine("Enter emplyee name");
                employeeName = Console.ReadLine();

                Console.WriteLine($"Enter {employeeName}`s salary");
                int employeeSalaryINT = int.Parse(Console.ReadLine());
                if (employeeSalaryINT > 0 && employeeSalaryINT < 10000)
                {
                    employeeSalary = Convert.ToString(employeeSalaryINT);
                    employeeTable[i] = new string[] { employeeName, employeeSalary };
                }
                else
                {
                    Console.WriteLine("Salary amount is incorrect");
                    i--;
                }
            }

            for (int i = 0; i < employeeAmount; i++)
            {
                Console.WriteLine($"{employeeTable[i][0]} : {employeeTable[i][1]}");
            }
        }
    }
}
