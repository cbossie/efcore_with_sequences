using System.Collections.Generic;

namespace EFCoreSequence.EF
{
    public class UserRole
    {
        public int RoleId { get;set; }
        public int UserId { get;set; } 
        public string RoleName { get;set; }

        public User User {get;set;}

        public List<RoleAttribute> Attributes {get;set;} = new List<RoleAttribute>();
        
    }
}