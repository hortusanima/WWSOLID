using WWSRP.UserGroups.Helpers;
using WWSRP.UserGroups.Models;
using WWSRP.Users.Models;

namespace WWSRP.UserGroups.Controllers
{
    public class UserGroupController
    {
        private readonly List<User> _users;
        private readonly List<UserGroup> _userGroups;

        public UserGroupController(List<User> users, List<UserGroup> userGroups)
        {
            _users = users;
            _userGroups = userGroups;
        }

        public User? GetUserByName(string username)
        {
            return _users.FirstOrDefault(x => x.Name == username);
        }

        public UserGroup? GetUserGroupByName(string groupName)
        {
            return _userGroups.FirstOrDefault(x => x.Name == groupName);
        }

        public User? GetUserInGroupByName(UserGroup userGroup, string username)
        {
            return userGroup.Participants.FirstOrDefault(x => x.Name == username);
        }

        public void CreateGroup(string groupName)
        {
            if (!_userGroups.Any(x => x.Name == groupName))
            {
                _userGroups.Add(new UserGroup { Name = groupName });
                Console.WriteLine($"User group {groupName} added.");
            }
            else
            {
                Console.WriteLine($"User group {groupName} already exists.");
            }
        }

        public void AddUserToGroup(string username, string groupName)
        {
            var userGroup = GetUserGroupByName(groupName);

            if (userGroup == null)
            {
                Console.WriteLine($"User group {groupName} does not exist.");
                return;
            }

            var userInGroup = GetUserInGroupByName(userGroup, username);
            if (userInGroup == null)
            {
                var user = GetUserByName(username);

                if(user != null)
                {
                    userGroup.Participants.Add(user);
                    Console.WriteLine($"User {user.Name} added to group {groupName}.");
                }
                else
                {
                    Console.WriteLine("User not found.");
                }
            }
            else
            {
                Console.WriteLine($"User {userInGroup.Name} already exists in group {groupName}.");
            }
        }

        public void RemoveUserFromGroup(string username, string groupName)
        {
            var userGroup = GetUserGroupByName(groupName);

            if (userGroup == null)
            {
                Console.WriteLine($"User group {groupName} does not exist.");
                return;
            }

            var userInGroup = GetUserInGroupByName(userGroup, username);
            if (userInGroup != null)
            {
                userGroup.Participants.Remove(userInGroup);
                Console.WriteLine($"User {username} removed from group {groupName}.");
            }
            else
            {
                Console.WriteLine($"User {username} doesn't exists in group {groupName}.");
            }
        }
    }
}
