namespace EmployeeDirectory
{
    internal interface IPayRoll
    {
        void AddEmployee(Employee employee);
        void AddEmployee(string name, uint salary);
        public List<Employee> GetEmployees();
    }
}