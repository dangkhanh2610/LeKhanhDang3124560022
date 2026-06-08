using UsersApp.Api.Models;
using UsersApp.Api.Repositories;

namespace UsersApp.Api.Services;

public class UsersService
{
    private readonly IUsersRepository _usersRepository;

    public UsersService(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public IList<User> GetUsers() => _usersRepository.GetAll();

    public User GetUserById(long id)
    {
        var user = _usersRepository.GetById(id) ?? throw new KeyNotFoundException($"User Not Found With Id : {id}");
        return user;
    }

    public User AddUser(User user)
    {
        if(string.IsNullOrWhiteSpace(user.Name))
        {
            throw new ArgumentException("Name Cannot Be Empty");
        }
        return _usersRepository.Add(user);
    }

}