using UsersApp.Api.Models;

namespace UsersApp.Api.Repositories;

public class UsersRepository : IUsersRepository
{
    private readonly List<User> _storage = new()
    {
        new User { Id = 1, Name = "Nguyen Van An" },
        new User { Id = 2, Name = "Tran Thi Binh" },
        new User { Id = 3, Name = "Le Van Cuong" },
    };
    
    public IList<User> GetAll() => _storage;

    public User? GetById(long id) => _storage.FirstOrDefault(u => u.Id == id);

    public User Add(User user)
    {
        user.Id = _storage.Count + 1;
        _storage.Add(user);
        return user;
    }
}