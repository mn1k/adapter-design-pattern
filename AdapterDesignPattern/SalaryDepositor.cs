using System;
using System.Collections.Generic;

namespace AdapterDesignPattern
{
    public class SalaryDepositor
    {
        // This system expects a list of employee's details to process and deposit their salaries
        public void ProcessSalaryDeposit(List<Employee> listEmployees)
        {
            foreach (Employee emp in listEmployees)
            {
                Console.WriteLine(emp.Name + ": " + "Amount of Rs " + emp.Salary + " has been credited to your Account");
            }
        }
    }
}
