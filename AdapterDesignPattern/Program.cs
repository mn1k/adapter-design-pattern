using System;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main()
        {

            // Storing the employees data in a string array
            string[,] employeesArray = new string[6, 4]
            {
                {"1","Chandler","SE","10000"},
                {"2","Monica","SE","20000"},
                {"3","Rachel","SSE","30000"},
                {"4","Joey","SE","40000"},
                {"5","Ross","SSE","50000"},
                {"6", "Pheobe", "SSE", "60000"}
            };

            Console.WriteLine("Passing Employee string array to Adapter\n");

            IConvert convert = new EmployeeAdapter();
            convert.ProcessEmployeeSalary(employeesArray);

            Console.Read();
        }
    }
}
