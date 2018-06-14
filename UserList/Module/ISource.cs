using System.Collections.Generic;

namespace UserList.Module
{
	internal interface ISource
	{
		IEnumerable<User> Read(string fileName);

		void Save(IEnumerable<User> users);
	}
}