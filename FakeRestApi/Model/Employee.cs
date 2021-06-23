namespace FakeRestApi.Model
{
    public class Employee
    {
        public int ID { get; internal set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
    }
}
