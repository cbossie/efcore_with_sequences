using System.Collections.Generic;
using System.Linq;
using EFCoreSequence.EF;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSequence
{
    public class Repository
    {
        UserContext _ctx;
        public Repository()
        {
            _ctx = new UserContext();
        }

        public User GetUser(int userId) 
        {
            return _ctx.User.Include(a => a.UserRoles)
                            .ThenInclude(a => a.Attributes)                            
                            .FirstOrDefault(a => a.UserId == userId);
        }

        public void AddUser(User user)
        {
            _ctx.Add(user);
        }

        public void BulkAddUser(IEnumerable<User> users)
        {
            _ctx.AddRange(users);
        }

        public int SaveEntities()
        {
            return _ctx.SaveChanges();
        }

    }
}