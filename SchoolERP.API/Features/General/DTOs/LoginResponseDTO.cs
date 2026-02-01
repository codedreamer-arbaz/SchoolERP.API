namespace SchoolERP.API.Features.General.DTOs
{
    public class LoginResponseDTO
    {
        public Guid UserId { get; set; }
        public string Role { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
    }
}
