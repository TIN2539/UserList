namespace UserList.View
{
	partial class AuthenticationView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.registerButton = new System.Windows.Forms.Button();
			this.loginButton = new System.Windows.Forms.Button();
			this.passwordPictureBox = new System.Windows.Forms.PictureBox();
			this.usernamePictureBox = new System.Windows.Forms.PictureBox();
			this.authenticationToolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usernamePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(12, 9);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(58, 13);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "Username:";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(12, 33);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(56, 13);
			this.passwordLabel.TabIndex = 1;
			this.passwordLabel.Text = "Password:";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(76, 30);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(179, 20);
			this.passwordTextBox.TabIndex = 2;
			this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Location = new System.Drawing.Point(76, 6);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(179, 20);
			this.usernameTextBox.TabIndex = 1;
			this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
			// 
			// registerButton
			// 
			this.registerButton.Location = new System.Drawing.Point(76, 56);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(86, 23);
			this.registerButton.TabIndex = 3;
			this.registerButton.Text = "Register";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// loginButton
			// 
			this.loginButton.Enabled = false;
			this.loginButton.Location = new System.Drawing.Point(168, 56);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(87, 23);
			this.loginButton.TabIndex = 4;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// passwordPictureBox
			// 
			this.passwordPictureBox.Image = global::UserList.Properties.Resources.Incorrect;
			this.passwordPictureBox.Location = new System.Drawing.Point(261, 30);
			this.passwordPictureBox.Name = "passwordPictureBox";
			this.passwordPictureBox.Size = new System.Drawing.Size(23, 20);
			this.passwordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.passwordPictureBox.TabIndex = 6;
			this.passwordPictureBox.TabStop = false;
			this.passwordPictureBox.MouseEnter += new System.EventHandler(this.PasswordPictureBox_MouseEnter);
			// 
			// usernamePictureBox
			// 
			this.usernamePictureBox.Image = global::UserList.Properties.Resources.Incorrect;
			this.usernamePictureBox.Location = new System.Drawing.Point(261, 6);
			this.usernamePictureBox.Name = "usernamePictureBox";
			this.usernamePictureBox.Size = new System.Drawing.Size(23, 20);
			this.usernamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.usernamePictureBox.TabIndex = 7;
			this.usernamePictureBox.TabStop = false;
			this.usernamePictureBox.MouseEnter += new System.EventHandler(this.UsernamePictureBox_MouseEnter);
			// 
			// authenticationToolTip
			// 
			this.authenticationToolTip.ToolTipTitle = "Validation Error";
			// 
			// AuthenticationView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 88);
			this.Controls.Add(this.usernamePictureBox);
			this.Controls.Add(this.passwordPictureBox);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.usernameLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "AuthenticationView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Authentication";
			((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usernamePictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.Button registerButton;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.PictureBox passwordPictureBox;
		private System.Windows.Forms.PictureBox usernamePictureBox;
		private System.Windows.Forms.ToolTip authenticationToolTip;
	}
}