﻿using System;
using UserList.Module;
using UserList.View;

namespace UserList.Presenter
{
	internal class MainPresenter : IPresenter
	{
		private readonly IUserListService mainService;
		private readonly IMainView mainView;

		public MainPresenter(IMainView mainView, IUserListService mainService)
		{
			this.mainView = mainView;
			this.mainService = mainService;

			SubscribeToEvents();
		}

		public void Run()
		{
			mainView.Show();
		}

		private void SubscribeToEvents()
		{
			mainView.LoadList += View_Load;
			mainView.Selected += View_ItemSelected;
			mainView.Delete += View_Delete;
		}

		private void View_Delete(object sender, EventArgs e)
		{
			mainService.DeleteUser(mainView.SelectedItem);
			mainView.DeleteItem();
		}

		private void View_ItemSelected(object sender, EventArgs e)
		{
			mainView.SetDeleteState();
		}

		private void View_Load(object sender, EventArgs e)
		{
			mainView.AddUsersToListBox(mainService.GetUsers());
		}
	}
}