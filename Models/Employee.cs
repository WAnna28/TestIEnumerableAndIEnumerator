namespace TestIEnumerableAndIEnumerator.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string EmployeeID { get; set; }
        public int Salary { get; set; }
        public Employee(string name, string employeeID, int salary)
        {
            Name = name;
            EmployeeID = employeeID;
            Salary = salary;
        }
    }
}