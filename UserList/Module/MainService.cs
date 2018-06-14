using System.Collections.Generic;
using System.Linq;

namespace UserList.Module
{
	internal class MainService : IMainService
	{
		private readonly ISource source;

		public MainService(ISource source)
		{
			this.source = source;
		}

		public void DeleteUser(string user)
		{
			List<User> users = source.Read("USers.xml").ToList();
			for (int i = 0; i < users.Count; ++i)
			{
				if (users[i].Username.Equals(user))
				{
					users.RemoveAt(i);
					break;
				}
			}
			source.Save(users);
		}

		public IEnumerable<User> GetUsers()
		{
			return source.Read("Users.xml");
		}
	}
}