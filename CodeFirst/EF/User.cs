using System.Collections.Generic;

namespace EFCoreSequence.EF
{
    public class User
    { 
        public int UserId { get;set; } 
        public string FirstName {get;set;}
        public string LastName {get;set;}

        public List<UserRole> UserRoles {get;set;} = new List<UserRole>();

    }
}