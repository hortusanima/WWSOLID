using WWSRP.Users.Models;

namespace WWSRP.Users.Controllers
{
	public class UserController
	{
		private readonly List<User> _users;

		public UserController(List<User> userData)
		{
			_users = userData;
		}

		public void AddUser(User user)
		{
			if (!_users.Any(x=> x.Name == user.Name))
			{
				_users.Add(user);
				Console.WriteLine($"User {user.Name} added.");
			}
			else
			{
				Console.WriteLine($"User {user.Name} already exists.");
			}
		}

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

		public void AuthenticateUser(User user)
		{
			var userToAuthenticate = _users.FirstOrDefault(x => x.Name == user.Name);
            if (user!= null && user.Password == userToAuthenticate.Password)
			{
				Console.WriteLine("User authenticated.");
			}
			else
			{
				Console.WriteLine("Authentication failed.");
			}
		}

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
