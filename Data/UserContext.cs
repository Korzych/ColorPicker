using Microsoft.EntityFrameworkCore;
using ColorPicker.Models;

namespace ColorPicker.Data;

public class UserContext : DbContext
{
    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
}