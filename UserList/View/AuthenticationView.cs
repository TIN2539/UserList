using System;
using System.Windows.Forms;

namespace UserList.View
{
	public partial class AuthenticationView : Form, IAuthenticationView
	{
		private readonly ApplicationContext context;

		public AuthenticationView(ApplicationContext context)
		{
			this.context = context;

			InitializeComponent();
		}

		public string Password => passwordTextBox.Text;

		public string Username => usernameTextBox.Text;


		public event EventHandler<EventArgs> CanLogin;
		public event EventHandler<EventArgs> Login;
		public event EventHandler<EventArgs> PasswordChange;
		public event EventHandler<EventArgs> Register;
		public event EventHandler<EventArgs> UsernameChange;

		public new void Show()
		{
			context.MainForm = this;
			Application.Run(context);
		}

		public void CheckCanLogin(bool isEnable)
		{
			loginButton.Enabled = isEnable;
		}

		public void SetPasswordPictureBoxState(bool isCorrect, string message)
		{
			if (isCorrect)
			{
				authenticationToolTip.Active = false;
				passwordPictureBox.Image = Properties.Resources.Correct;
			}
			else
			{
				authenticationToolTip.Active = true;
				authenticationToolTip.SetToolTip(passwordPictureBox, message);
				passwordPictureBox.Image = Properties.Resources.Incorrect;
			}
		}

		public void SetUsernamePictureBoxState(bool isCorrect, string message)
		{
			if (isCorrect)
			{
				authenticationToolTip.Active = false;
				usernamePictureBox.Image = Properties.Resources.Correct;
			}
			else
			{
				authenticationToolTip.Active = true;
				authenticationToolTip.SetToolTip(usernamePictureBox, message);
				usernamePictureBox.Image = Properties.Resources.Incorrect;
			}
		}

		public void ShowError(string message)
		{
			MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			Login?.Invoke(sender, e);
		}

		private void PasswordPictureBox_MouseEnter(object sender, EventArgs e)
		{
			PasswordChange?.Invoke(sender, e);
		}

		private void PasswordTextBox_TextChanged(object sender, EventArgs e)
		{
			PasswordChange?.Invoke(sender, e);
			CanLogin?.Invoke(sender, e);
		}

		private void RegisterButton_Click(object sender, EventArgs e)
		{
			Register?.Invoke(sender, e);
		}

		private void UsernamePictureBox_MouseEnter(object sender, EventArgs e)
		{
			UsernameChange?.Invoke(sender, e);
		}

		private void UsernameTextBox_TextChanged(object sender, EventArgs e)
		{
			UsernameChange?.Invoke(sender, e);
			CanLogin?.Invoke(sender, e);
		}
	}
}