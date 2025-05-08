using AuthServiceAPI.Model;

namespace AuthServiceAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
