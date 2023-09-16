using System.Collections.Generic;

namespace AdapterDesignPattern
{
    public interface IConvert
    {
        List<Employee> ProcessEmployeeSalary(string[,] employeesArray);
    }
}
