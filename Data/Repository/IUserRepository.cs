using QuickBiilingTest.Models.Entities;

namespace QuickBiilingTest.Data.Repository
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsername(string username);
        Task<int> RegisterUser(User user);
    }
}
