namespace FakeRestApi.Service
{
    using FakeRestApi.Model;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class UserService
    {
        public async Task<bool> Validate(string username, string password)
        {
            var userBL = new UsersDB();
            var UserLists = userBL.GetUsers();
            return await Task.Run(() => UserLists.Any(user =>
                user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) && user.Password == password));
        }
    }
}
