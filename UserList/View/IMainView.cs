using System;
using System.Collections.Generic;
using UserList.Module;

namespace UserList.View
{
	internal interface IMainView : IView
	{
		event EventHandler<EventArgs> Delete;

		event EventHandler<EventArgs> LoadList;

		event EventHandler<EventArgs> Selected;

		void AddUsersToListBox(IEnumerable<User> users);

		void CanDelete();

		void DeleteItem();

		string GetSelectedItem();
	}
}