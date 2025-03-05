using WWSRP.UserManagement;

namespace WWSRP.UserGroup
{
    public class UserGroup
    {
        public required string Name { get; set; }
        public List<User> Participants { get; set; } = new List<User>();
    }
}
