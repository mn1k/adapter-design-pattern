using System;
using System.Collections.Generic;

namespace AdapterDesignPattern
{
    // This is the class that makes two incompatible interfaces or systems work together
    public class EmployeeAdapter : IConvert
    {
        readonly SalaryDepositor _salaryDepositor = new SalaryDepositor();

        // Taking the employees in the form of the string array
        public List<Employee> ProcessEmployeeSalary(string[,] employeesArray)
        {
            string Id = null;
            string Name = null;
            string Designation = null;
            string Salary = null;

            List<Employee> listEmployees = new List<Employee>();

            // Convert the employee string array to list of employees
            for(int i = 0; i < employeesArray.GetLength(0); i++)
            { 
                for(int j = 0; j < employeesArray.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        Id = employeesArray[i, j];
                    }

                    else if(j == 1)
                    {
                        Name = employeesArray[i, j];
                    }

                    else if(j == 2)
                    {
                        Designation = employeesArray[i, j];
                    }

                    else
                    {
                        Salary = employeesArray[i, j];
                    }
                }

                listEmployees.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Convert.ToInt32(Salary)));
            }

            Console.WriteLine("Adapter converted Array of Employee to List of Employee\n");

            // Calling the adaptee's method to process the salaries and deposit them
            _salaryDepositor.ProcessSalaryDeposit(listEmployees);

            // Return the list of employees
            return listEmployees;
        }
    }
}
