using System.Collections.Generic;

namespace UserList.Module
{
	internal interface IUserListService
	{
		void DeleteUser(string user);

		IEnumerable<User> GetUsers();
	}
}