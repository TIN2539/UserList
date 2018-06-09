using System;
using System.Windows.Forms;

namespace UserList.View
{
	public partial class RegistrationView : Form, IRegistrationView
	{
		private readonly ApplicationContext context;

		public RegistrationView(ApplicationContext context)
		{
			this.context = context;

			InitializeComponent();
		}

		public event EventHandler<EventArgs> Cancel;

		public event EventHandler<EventArgs> CanRegister;

		public event EventHandler<EventArgs> ConfirmPasswordChange;

		public event EventHandler<EventArgs> PasswordChange;

		public event EventHandler<EventArgs> Register;

		public event EventHandler<EventArgs> UsernameChange;

		public string ConfirmPassword => confirmPasswordTextBox.Text;

		public string Password => passwordTextBox.Text;

		public string Username => SpacebarDelete();

		private string SpacebarDelete()
		{
			char[] separator = { ' ' };
			string[] username = usernameTextBox.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			return string.Join(" ", username);
		}

		public new void Close()
		{
			passwordTextBox.Clear();
			usernameTextBox.Clear();
			confirmPasswordTextBox.Clear();
			base.Close();
		}

		public new void Show()
		{
			ShowDialog();
		}

		public void CheckCanRegister(bool isButtonEnable)
		{
			registerButton.Enabled = isButtonEnable;
		}

		public void SetConfirmPasswordImageState(bool isCorrect, string message)
		{
			if (isCorrect)
			{
				registeredToolTip.Active = false;
				confirmPasswordPictureBox.Image = Properties.Resources.Correct;
			}
			else
			{
				registeredToolTip.Active = true;
				registeredToolTip.SetToolTip(confirmPasswordPictureBox, message);
				confirmPasswordPictureBox.Image = Properties.Resources.Incorrect;
			}
		}

		public void SetPasswordImageState(bool isCorrect, string message)
		{
			if (isCorrect)
			{
				registeredToolTip.Active = false;
				passwordPictureBox.Image = Properties.Resources.Correct;
			}
			else
			{
				registeredToolTip.Active = true;
				registeredToolTip.SetToolTip(passwordPictureBox, message);
				passwordPictureBox.Image = Properties.Resources.Incorrect;
			}
		}

		public void SetUsernameImageState(bool isCorrect, string message)
		{
			if (isCorrect)
			{
				registeredToolTip.Active = false;
				usernamePictureBox.Image = Properties.Resources.Correct;
			}
			else
			{
				registeredToolTip.Active = true;
				registeredToolTip.SetToolTip(usernamePictureBox, message);
				usernamePictureBox.Image = Properties.Resources.Incorrect;
			}
		}

		public void SucsesfullRegistration(string message)
		{
			MessageBox.Show($"User {message} successfully registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void CacelButton_Click(object sender, EventArgs e)
		{
			Cancel?.Invoke(sender, e);
		}

		private void ConfirmPasswordPictureBox_MouseEnter(object sender, EventArgs e)
		{
			ConfirmPasswordChange?.Invoke(sender, e);
		}

		private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
		{
			ConfirmPasswordChange?.Invoke(sender, e);
			CanRegister?.Invoke(sender, e);
		}

		private void PasswordPictureBox_MouseEnter(object sender, EventArgs e)
		{
			PasswordChange?.Invoke(sender, e);
		}

		private void PasswordTextBox_TextChanged(object sender, EventArgs e)
		{
			PasswordChange?.Invoke(sender, e);
			CanRegister?.Invoke(sender, e);
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
			CanRegister?.Invoke(sender, e);
		}
	}
}