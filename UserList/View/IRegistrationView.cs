using System;

namespace UserList.View
{
	internal interface IRegistrationView : IView
	{
		event EventHandler<EventArgs> Cancel;

		event EventHandler<EventArgs> CanRegister;

		event EventHandler<EventArgs> ConfirmPasswordChange;

		event EventHandler<EventArgs> PasswordChange;

		event EventHandler<EventArgs> Register;

		event EventHandler<EventArgs> UsernameChange;

		string ConfirmPassword { get; }

		string Password { get; }

		string Username { get; }

		void CheckCanRegister(bool isButtonEnable);

		void SetConfirmPasswordImageState(bool isCorrect, string message);

		void SetPasswordImageState(bool isCorrect, string message);

		void SetUsernameImageState(bool isCorrect, string message);

		void SucsesfullRegistration(string username);
	}
}