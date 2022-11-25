using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new()
            {
                new User
                {
                    Name = "Test User 1",
                    Email = "test.user.1@test.com",
                    Address = new Address
                    {
                        Street = "123 Market St",
                        City = "New York",
                        ZipCode = "123456"
                    }
                },
                new User
                {
                    Name = "Test User 2",
                    Email = "test.user.2@test.com",
                    Address = new Address
                    {
                        Street = "Leliju 2",
                        City = "Vilnius",
                        ZipCode = "LT12356"
                    }
                },
                new User
                {
                    Name = "Test User 3",
                    Email = "test.user.3@test.com",
                    Address = new Address
                    {
                        Street = "Moscow 3",
                        City = "Moscow",
                        ZipCode = "58965"
                    }
                },
                new User
                {
                    Name = "Test User 4",
                    Email = "test.user.4@test.com",
                    Address = new Address
                    {
                        Street = "Oceanside 25",
                        City = "Maiami",
                        ZipCode = "9852"
                    }
                },
                new User
                {
                    Name = "Test User 5",
                    Email = "test.user.5@test.com",
                    Address = new Address
                    {
                        Street = "Kongo 896",
                        City = "Tokyo",
                        ZipCode = "52893"
                    }
                }
            };
    }
}
