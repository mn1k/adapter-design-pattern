namespace AdapterDesignPattern
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public Employee(int id, string name, string designation, int salary)
        {
            ID = id;
            Name = name;
            Designation = designation;
            Salary = salary;
        }

        public override bool Equals( object obj )
        {
            if ( obj == null ) { return false; }
            Employee other = obj as Employee;

            return (ID ==  other.ID && Name == other.Name && Designation == other.Designation && Salary == other.Salary);
        }
    }
}
