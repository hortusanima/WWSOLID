using WWSRP.Users.Models;

namespace WWSRP.UserGroups.Models
{
    public class UserGroup
    {
        public required string Name { get; set; }
        public List<User> Participants { get; set; } = new List<User>();
    }
}
