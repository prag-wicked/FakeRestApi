namespace FakeRestApi.Model
{
    public class User
    {
        public int ID { get; internal set; }
        public string UserName { get; internal set; }
        public string Password { get; internal set; }
        public string Email { get; set; }
    }
}
