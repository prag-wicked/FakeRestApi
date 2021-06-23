namespace FakeRestApi.Model
{
    using System.Collections.Generic;

    public class UsersDB
    {
        public List<User> GetUsers()
        {
            // A mock data class acting as persistent storage    
            List<User> userList = new List<User>();
            userList.Add(new User()
            {
                ID = 101,
                UserName = "user1",
                Password = "12345"
            });
            userList.Add(new User()
            {
                ID = 101,
                UserName = "user2",
                Password = "12345"
            });
            return userList;
        }
    }
}
