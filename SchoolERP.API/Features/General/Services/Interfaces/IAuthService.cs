using SchoolERP.API.Features.General.DTOs;

namespace SchoolERP.API.Features.General.Services.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponseDTO> LoginAsync(LoginRequestDTO request);
    }
}
