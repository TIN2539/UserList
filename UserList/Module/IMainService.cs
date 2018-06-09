using System.Collections.Generic;

namespace UserList.Module
{
	internal interface IMainService
	{
		void DeleteUser(string user);

		IEnumerable<User> GetUsers();
	}
}