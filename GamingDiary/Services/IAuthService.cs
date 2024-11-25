using GamingDiary.Models;

namespace GamingDiary.Services
{
    public interface IAuthService
    {
        Task<bool> RegisterUser(string username, string email, string password);
        Task<User> Login(string username, string password);
        Task<bool> ValidatePanic(int userId, string password);
    }
}