namespace FakeRestApi.Model
{
    using System.Collections.Generic;

    public class EmployeeDB
    {
        public List<Employee> GetEmployees()
        {
            // A mock data class acting as persistent storage

            List<Employee> empList = new List<Employee> { new Employee()
            {
                ID = 1,
                FirstName = "David",
                Surname = "Marc",
                Department = "IT",
                Gender = "Male",
            },
            new Employee()
            {
                ID = 2,
                FirstName = "Shaun",
                Surname = "Brown",
                Department = "HR",
                Gender = "Female",
            },
            new Employee()
            {
              ID = 2,
              FirstName = "Ram",
              Surname = "Kamal",
              Department = "Finance",
              Gender = "Male"
            }
          };

            return empList;
        }
    }
}
