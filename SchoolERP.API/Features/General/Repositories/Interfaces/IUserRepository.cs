using SchoolERP.API.Features.General.Models;

namespace SchoolERP.API.Features.General.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<UserAccount?> GetByUsernameAsync(string username);
    }
}
