using WWSRP.UserManagement;

namespace WWSRP.UserGroup
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

        // CHANGED
        public void CreateGroup(string name)
        {
            if (!_userGroups.Any(x => x.Name == name))
            {
                _userGroups.Add(new UserGroup { Name = name });
                Console.WriteLine($"User group {name} added.");
            }
            else
            {
                Console.WriteLine($"User group {name} already exists.");
            }
        }

        // CHANGED
        public void AddUserToGroup(string username, string groupName)
        {
            var userGroup = _userGroups.FirstOrDefault(x => x.Name == groupName);

            if (userGroup == null)
            {
                Console.WriteLine($"User group {groupName} does not exist.");
                return;
            }

            var userInGroup = userGroup.Participants.FirstOrDefault(x => x.Name == username);
            if (userInGroup == null)
            {
                var user = _users.FirstOrDefault(x => x.Name == username);

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

        // CHANGED
        public void RemoveUserFromGroup(string username, string groupName)
        {
            var userGroup = _userGroups.FirstOrDefault(x => x.Name == groupName);

            if (userGroup == null)
            {
                Console.WriteLine($"User group {groupName} does not exist.");
                return;
            }

            var userInGroup = userGroup.Participants.FirstOrDefault(x => x.Name == username);
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
