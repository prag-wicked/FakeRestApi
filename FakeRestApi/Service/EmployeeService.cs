namespace FakeRestApi.Service
{
    using FakeRestApi.Model;
    using System.Collections.Generic;

    public class EmployeeService
    {
        public List<Employee> GetAll()
        {
            var employeeDB = new EmployeeDB();
            return employeeDB.GetEmployees();
        }
    }
}
