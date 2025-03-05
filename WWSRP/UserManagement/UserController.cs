
namespace WWSRP.UserManagement
{
	public class UserController
	{
		private readonly List<User> _users;

		public UserController(List<User> userData)
		{
			_users = userData;
		}

		// CHANGED
		public void AddUser(string username, string password)
		{
			if (!_users.Any(x=> x.Name == username))
			{
				User user = new User
				{
					Name = username,
					Password = password
				};

				_users.Add(user);
				Console.WriteLine($"User {username} added.");
			}
			else
			{
				Console.WriteLine($"User {username} already exists.");
			}
		}

		// CHANGED
		public void UpdateUserPassword(string username, string newPassword)
		{
			var user = _users.FirstOrDefault(x => x.Name == username);

            if (user != null)
			{
				user.Password = newPassword;
				Console.WriteLine($"Password for {user.Name} updated.");
			}
			else
			{
				Console.WriteLine($"User not found.");
			}
		}

		// CHANGED
		public void DeleteUser(string username)
		{
            var user = _users.FirstOrDefault(x => x.Name == username);

            if (user != null)
			{
				_users.Remove(user);
				Console.WriteLine($"User {user.Name} deleted.");
			}
			else
			{
				Console.WriteLine($"User not found.");
			}
		}

		// CHANGED
		public void AuthenticateUser(string username, string password)
		{
			var user = _users.FirstOrDefault(x => x.Name == username);
            if (user!= null && user.Password == password)
			{
				Console.WriteLine("User authenticated.");
			}
			else
			{
				Console.WriteLine("Authentication failed.");
			}
		}

		// CHANGED
		public void DisplayAllUsers()
		{
			if (_users.Count > 0)
			{
				Console.WriteLine("All users:");
				foreach (var user in _users)
				{
					Console.WriteLine($"Username: {user.Name}, Password: {user.Password}");
				}
			}
			else
			{
				Console.WriteLine("No users available.");
			}
		}
	}
}
