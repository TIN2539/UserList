using System;

namespace UserList.View
{
	internal interface IAuthenticationView : IView
	{
		string Password { get; }

		string Username { get; }

		event EventHandler<EventArgs> CanLogin;
		event EventHandler<EventArgs> Login;
		event EventHandler<EventArgs> PasswordChange;
		event EventHandler<EventArgs> Register;
		event EventHandler<EventArgs> UsernameChange;

		void CheckCanLogin(bool isEnable);

		void SetPasswordPictureBoxState(bool isCorrect, string message);

		void SetUsernamePictureBoxState(bool isCorrect, string message);

		void ShowError(string error);
	}
}