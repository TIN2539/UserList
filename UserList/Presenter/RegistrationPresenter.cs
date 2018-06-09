using System;
using UserList.Module;
using UserList.View;

namespace UserList.Presenter
{
	internal class RegistrationPresenter : IPresenter
	{
		private readonly IRegistrationView registrationView;
		private readonly IRegistrationService registrationService;

		public RegistrationPresenter(IRegistrationView registrationView, IRegistrationService registrationService)
		{
			this.registrationView = registrationView;
			this.registrationService = registrationService;

			SubscribeToEvents();
		}

		private void SubscribeToEvents()
		{
			registrationView.Register += View_Register;
			registrationView.CanRegister += View_CanRegister;
			registrationView.Cancel += View_Cancel;
			registrationView.ConfirmPasswordChange += View_ConfirmPassword;
			registrationView.PasswordChange += View_Password;
			registrationView.UsernameChange += View_Username;
		}

		private void View_Username(object sender, EventArgs e)
		{
			if (registrationService.CheckUserInSource(registrationView.Username))
			{
				registrationView.SetUsernameImageState(false, "Username already exists");
			}
			else if (!registrationService.ChecUsername(registrationView.Username))
			{
				registrationView.SetUsernameImageState(false, "Username cannot be less than 5 characters");
			}
			else
			{
				registrationView.SetUsernameImageState(true, null);
			}
			//View_CanRegister(sender, e);
		}

		private void View_Password(object sender, EventArgs e)
		{
			if (!registrationService.CheckPassword(registrationView.Password))
			{
				registrationView.SetPasswordImageState(false, "Password cannot be empty");
			}
			else
			{
				registrationView.SetPasswordImageState(true, null);
			}
		}

		private void View_ConfirmPassword(object sender, EventArgs e)
		{
			if (!registrationService.CheckPassword(registrationView.ConfirmPassword))
			{
				registrationView.SetConfirmPasswordImageState(false, "Confirmation password cannot be empty");
			}
			else if (!registrationService.CheckConfirmPassword(registrationView.ConfirmPassword, registrationView.Password))
			{
				registrationView.SetConfirmPasswordImageState(false, "Passwords do not match");
			}
			else
			{
				registrationView.SetConfirmPasswordImageState(true, null);
			}
		}

		private void View_Cancel(object sender, EventArgs e)
		{
			registrationView.Close();
		}

		private void View_CanRegister(object sender, EventArgs e)
		{
			registrationView.CheckCanRegister(registrationService.CheckConfirmPassword(registrationView.ConfirmPassword, registrationView.Password) &&
				registrationService.CheckPassword(registrationView.Password) && registrationService.ChecUsername(registrationView.Username) && 
				!registrationService.CheckUserInSource(registrationView.Username));
		}

		private void View_Register(object sender, EventArgs e)
		{
			User user = new User(registrationView.Username, registrationView.Password);
			if (!registrationService.CheckUserInSource(registrationView.Username))
			{
				registrationService.Register(user);
				registrationView.SucsesfullRegistration(registrationView.Username);
				registrationView.Close();
			}
		}

		public void Run()
		{
			registrationView.Show();
		}
	}
}