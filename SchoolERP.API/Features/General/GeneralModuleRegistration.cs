using SchoolERP.API.Features.General.Repositories;
using SchoolERP.API.Features.General.Repositories.Interfaces;
using SchoolERP.API.Features.General.Services;
using SchoolERP.API.Features.General.Services.Interfaces;

namespace SchoolERP.API.Features.General
{
    public static class GeneralModuleRegistration
    {
        public static IServiceCollection AddGeneralModule(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
