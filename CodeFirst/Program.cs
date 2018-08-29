using System;
using System.Collections.Generic;
using EFCoreSequence.EF;

namespace EFCoreSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var p = new Program();
            p.TestUsers();
            p.TestUsersBulk();
            Console.Read();






        }

        public Program()
        {
            
        }

        public void TestUsers()
        {
            Repository rep = new Repository();
            User u = GenerateUser(DateTime.Now.Second);
            rep.AddUser(u);
            var n = rep.SaveEntities();
            int r = u.UserId;
        }

        public void TestUsersBulk(int n = 10)
        {          
            Repository rep = new Repository();
            List<User> users = new List<User>();
            for(int i = 0; i < n; i++){
                users.Add(GenerateUser(i+DateTime.Now.Second));                
            }
            rep.BulkAddUser(users);
            var j = rep.SaveEntities();

        }


        protected User GenerateUser(int id)
        {
            User u = new User()
            {
                FirstName = $"Craig{id}_{DateTime.Now.Ticks}",
                LastName = $"Bossie{id}_{DateTime.Now.Ticks}"
            };

            for(int i = 0; i < id; i++)
            {
                var userRole = new UserRole()
                {
                    RoleName = $"Role{i}_{DateTime.Now.Ticks}"
                };

                userRole.Attributes.AddRange(GenerateRoleAttributes());
                u.UserRoles.Add(userRole);
            }



            return u;
        }

        protected IEnumerable<RoleAttribute> GenerateRoleAttributes(int n = 3){
            List<RoleAttribute> raList = new List<RoleAttribute>();
            for(int i = 0; i < n; i++)
            {
                raList.Add(new RoleAttribute(){
                    Attribute = $"ATT_{Guid.NewGuid()}",
                    Value = $"VAL_{Guid.NewGuid()}"
                });
            }
            return raList;

        }


    }
}
