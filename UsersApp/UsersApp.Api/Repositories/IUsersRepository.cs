using UsersApp.Api.Models;

namespace UsersApp.Api.Repositories;

public interface IUsersRepository
{
    IList<User> GetAll();
    User? GetById(long id);
    User Add(User user);
}