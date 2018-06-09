using System.Collections.Generic;
using System.Linq;

namespace UserList.Module
{
	internal class RegistrationService : IRegistrationService
	{
		private readonly ILoginService loginService;
		private readonly ISource source;

		public RegistrationService(ILoginService loginService, ISource source)
		{
			this.loginService = loginService;
			this.source = source;
		}

		public bool CheckConfirmPassword(string confirmPaswword, string password)
		{
			return confirmPaswword == password;
		}

		public bool CheckPassword(string password)
		{
			return loginService.CorrectPassword(password);
		}

		public bool CheckUserInSource(string username)
		{
			var hasInSource = false;
			IEnumerable<User> loaddUsers = source.Read("Users.xml");
			foreach (var loadUser in loaddUsers)
			{
				if (loadUser.Username.Equals(username))
				{
					hasInSource = true;
					break;
				}
			}
			return hasInSource;
		}

		public bool ChecUsername(string username)
		{
			return loginService.CorrectUsername(username);
		}

		public void Register(User user)
		{
			var loadUsers = source.Read("Users.xml");
			List<User> users = loadUsers.ToList();
			users.Add(user);
			source.Save(users);
		}
	}
}