using System;
using UserList.Module;
using UserList.View;

namespace UserList.Presenter
{
	internal class AuthenticationPresenter : IPresenter
	{
		private readonly IAuthenticationView authenticationView;
		private readonly ILoginService loginService;
		private readonly IPresenter mainPresenter;
		private readonly IPresenter registrationPresenter;

		public AuthenticationPresenter(ILoginService loginService, IAuthenticationView authenticationView,
			IPresenter mainPresenter, IPresenter registrationPresenter)
		{
			this.loginService = loginService;
			this.authenticationView = authenticationView;
			this.registrationPresenter = registrationPresenter;
			this.mainPresenter = mainPresenter;

			SubscribeToEvents();
		}

		public void Run()
		{
			authenticationView.Show();
		}

		private void SubscribeToEvents()
		{
			authenticationView.Register += View_RegisterButton;
			authenticationView.UsernameChange += View_Username;
			authenticationView.PasswordChange += View_Password;
			authenticationView.CanLogin += View_CanLogin;
			authenticationView.Login += View_Login;
		}

		private void View_CanLogin(object sender, EventArgs e)
		{
			authenticationView.CheckCanLogin(loginService.LoginState(new User(authenticationView.Username, authenticationView.Password)));
		}

		private void View_Login(object sender, EventArgs e)
		{
			if (loginService.Login(new User(authenticationView.Username, authenticationView.Password)))
			{
				mainPresenter.Run();
				authenticationView.Close();
			}
			else
			{
				authenticationView.ShowError("Incorrect username or password");
			}
		}

		private void View_Password(object sender, EventArgs e)
		{
			if (loginService.CorrectPassword(authenticationView.Password))
			{
				authenticationView.SetPasswordPictureBoxState(true, null);
			}
			else
			{
				authenticationView.SetPasswordPictureBoxState(false, "Password cannot be empty");
			}
		}

		private void View_RegisterButton(object sender, EventArgs e)
		{
			registrationPresenter.Run();
		}

		private void View_Username(object sender, EventArgs e)
		{
			if (loginService.CorrectUsername(authenticationView.Username))
			{
				authenticationView.SetUsernamePictureBoxState(true, null);
			}
			else
			{
				authenticationView.SetUsernamePictureBoxState(false, "Username cannot be less than 5 characters");
			}
		}
	}
}