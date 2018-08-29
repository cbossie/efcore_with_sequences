namespace EFCoreSequence.EF
{
    public class RoleAttribute
    {
        public int RoleAttributeId {get;set;}
        public int UserRoleId {get;set;}
        public string Attribute {get;set;}
        public string Value {get;set;}
        public UserRole Role {get;set;}
        public int Seq {get;set;}
    }
}