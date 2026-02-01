using SchoolERP.API.Features.General.Models;
using System.Data.Common;

namespace SchoolERP.API.Features.General.Repositories.Interfaces
{
    public class UserRepository : IUserRepository
    {
        public async Task<UserAccount?> GetByUsernameAsync(string username)
        {
            //var cmd = new SqlCommand(
            //    @"SELECT Id, Username, PasswordHash, Role, IsActive
            //  FROM Users WHERE Username = @Username",
            //    _connection
            //);

            //cmd.Parameters.AddWithValue("@Username", username);

            //using var reader = await cmd.ExecuteReaderAsync();
            //if (!reader.Read()) return null;

            return new UserAccount
            {
                Username = "username",//reader.GetString(1),
                PasswordHash = "###",//reader.GetString(2),
                Role = "Admin",//reader.GetString(3),
                IsActive = true,//"reader.GetBoolean(4)
            };
        }
    }
}
