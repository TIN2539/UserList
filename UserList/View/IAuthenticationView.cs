using System;

namespace UserList.View
{
	internal interface IAuthenticationView : IView
	{
		event EventHandler<EventArgs> CanLogin;

		event EventHandler<EventArgs> Login;

		event EventHandler<EventArgs> PasswordChange;

		event EventHandler<EventArgs> Register;

		event EventHandler<EventArgs> UsernameChange;

		string Password { get; }

		string Username { get; }

		void CheckCanLogin(bool isButtonEnable);

		void SetPasswordPictureBoxState(bool isCorrect, string message);

		void SetUsernamePictureBoxState(bool isCorrect, string message);

		void ShowError(string error);
	}
}