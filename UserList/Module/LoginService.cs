using System.Collections.Generic;
using System.IO;

namespace UserList.Module
{
	internal class LoginService : ILoginService
	{
		private readonly ISource source;
		private IEnumerable<User> loadedUsers;

		public LoginService(ISource source)
		{
			this.source = source;
			if (!File.Exists("Users.xml"))
			{
				source.Save(new List<User>());
			}
		}

		public bool CorrectPassword(string password)
		{
			return password.Length != 0;
		}

		public bool CorrectUsername(string username)
		{
			return username.Length >= 5;
		}

		public bool Login(User user)
		{
			var isCorrectUser = false;
			loadedUsers = source.Read("Users.xml");
			foreach (var loadUser in loadedUsers)
			{
				if (loadUser.Username.Equals(user.Username) && loadUser.Password.Equals(user.Password))
				{
					isCorrectUser = true;
					break;
				}
			}
			return isCorrectUser;
		}

		public bool LoginState(User user)
		{
			return CorrectUsername(user.Username) && CorrectPassword(user.Password);
		}
	}
}