using Bogus;
using System.Collections.Generic;
using UsersManagement.API.Models;

namespace UsersManagement.API.Fake
{
    public static class FakeData
    {
        private static List<User> _users;

        public static List<User> GetUsers(int count)
        {
            if (_users == null)
            {
                _users = new Faker<User>()
                        .RuleFor(u => u.Id, f => f.IndexFaker + 1)
                        .RuleFor(u => u.UserName, f => f.Name.FullName())
                        .RuleFor(u => u.Address, f => f.Address.FullAddress())
                        .Generate(count);
            }

            return _users;
        }

    }
}
