using ColorPicker.Models;

namespace ColorPicker.Data
{
    public static class DbInitializer
    {
        public static void Initialize(UserContext context)
        {

            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User
                    {
                        Id = 1,
                        Username = "admin1",
                        Password = "admin1"
                    },
                 new User
                    {
                        Id = 2,
                        Username = "user1",
                        Password = "user1"
                    }, 
                new User
                    {
                        Id = 3,
                        Username = "user2",
                        Password = "user2"
                    }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}