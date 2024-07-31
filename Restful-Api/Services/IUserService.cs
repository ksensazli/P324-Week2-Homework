namespace Restful_Api.Services;

public interface IUserService
{
    bool Authenticate(string username, string password);
}