using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services.Contracts
{
    public interface IUsersService
    {
        public Task<List<User>> GetAllUsers();
    }
}
