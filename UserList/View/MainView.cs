using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UserList.Module;

namespace UserList.View
{
	internal partial class MainView : Form, IMainView
	{
		private readonly ApplicationContext context;

		public MainView(ApplicationContext context)
		{
			this.context = context;

			InitializeComponent();
		}

		public event EventHandler<EventArgs> Delete;

		public event EventHandler<EventArgs> LoadList;

		public event EventHandler<EventArgs> Selected;

		public new void Show()
		{
			context.MainForm = this;
			base.Show();
		}

		public void AddUsersToListBox(IEnumerable<User> users)
		{
			usersListBox.Items.Clear();
			foreach (var user in users)
			{
				ListViewItem item = new ListViewItem(user.Username)
				{
					Tag = user
				};
				usersListBox.Items.Add(item.Text);
			}
		}

		public void CanDelete()
		{
			if (usersListBox.SelectedIndex >= 0)
			{
				deleteButton.Enabled = true;
			}
			else
			{
				deleteButton.Enabled = false;
			}
		}

		public void DeleteItem()
		{
			usersListBox.Items.RemoveAt(usersListBox.SelectedIndex);
		}

		public string GetSelectedItem()
		{
			return usersListBox.SelectedItem.ToString();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			Delete?.Invoke(sender, e);
		}

		private void MainView_Load(object sender, EventArgs e)
		{
			LoadList?.Invoke(sender, e);
		}

		private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Selected?.Invoke(sender, e);
		}
	}
}