using System.Collections.Generic;
using Xunit;

namespace AdapterDesignPattern.UnitTest
{
    public class EmployeeTest
    {
        [Fact]
        public void ProcessEmployeeSalary_ShouldConvertArrayToList()
        {
            // Arrange
            string[,] employeesArray = new string[6, 4]
            {
            {"1","Chandler","SE","10000"},
            {"2","Monica","SE","20000"},
            {"3","Rachel","SSE","30000"},
            {"4","Joey","SE","40000"},
            {"5","Ross","SSE","50000"},
            {"6", "Pheobe", "SSE", "60000"}
            };

            List<Employee> expectedEmployeesList = new List<Employee>()
        {
            new Employee(1, "Chandler", "SE", 10000),
            new Employee(2, "Monica", "SE", 20000),
            new Employee(3, "Rachel", "SSE", 30000),
            new Employee(4, "Joey", "SE", 40000),
            new Employee(5, "Ross", "SSE", 50000),
            new Employee(6, "Pheobe", "SSE", 60000)
        };

            // Act
            EmployeeAdapter employeeAdapter = new EmployeeAdapter();
            List<Employee> listEmployees = employeeAdapter.ProcessEmployeeSalary(employeesArray);

            // Assert
            Assert.Equal(expectedEmployeesList, listEmployees);
        }
    }
}
