using QuickBiilingTest.Models.Dto;
using QuickBiilingTest.Models.Responses;

namespace QuickBiilingTest.Services.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(LoginDto loginDto);
        Task<int> Register(RegisterDto registerDto);
    }
}
