using System.Collections.Generic;
using EFCoreSequence.EF;

namespace EFCoreSequence
{
    public class Repository
    {
        UserContext _ctx;
        public Repository()
        {
            _ctx = new UserContext();
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