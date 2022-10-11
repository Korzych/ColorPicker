using ColorPicker.Models;
using ColorPicker.Data;
using Microsoft.EntityFrameworkCore;

namespace ColorPicker.Services;

public class UserService
{
    private readonly UserContext _context;

    public UserService(UserContext context)
    {
        _context = context;
    }

    public IEnumerable<User> GetAll()
    {
        return _context.Users.AsNoTracking().ToList();

    }
    public User? GetById(int id)
    {
        return _context.Users.AsNoTracking().SingleOrDefault(p => p.Id == id);
    }

    public User Create(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();

        return user;
    }
    public void DeleteById(int id)
    {
        var userToDelete = _context.Users.Find(id);
        if (userToDelete is not null)
        {
            _context.Users.Remove(userToDelete);
            _context.SaveChanges();
        }        
    }
}