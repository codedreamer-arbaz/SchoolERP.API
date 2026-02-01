using SchoolERP.API.Features.General.DTOs;
using SchoolERP.API.Features.General.Repositories.Interfaces;
using SchoolERP.API.Features.General.Services.Interfaces;

namespace SchoolERP.API.Features.General.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<LoginResponseDTO> LoginAsync(LoginRequestDTO request)
        {
            var user = await _userRepository.GetByUsernameAsync(request.Username);

            if (user == null || !user.IsActive)
                throw new Exception("Invalid username or password");

            return new LoginResponseDTO
            {
                UserId = user.Id,
                Role = user.Role,
                DisplayName = user.Username
            };
        }
    }
}
