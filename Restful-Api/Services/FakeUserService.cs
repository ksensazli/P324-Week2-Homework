using Restful_Api.Models;

namespace Restful_Api.Services;

public class FakeUserService : IUserService
{
    private List<User> users = new List<User>
    {
        new User { Username = "kagan", Password = "papara" },
        new User { Username = "test", Password = "patika" }
    };

    public bool Authenticate(string username, string password)
    {
        return users.Any(u => u.Username == username && u.Password == password);
    }
}