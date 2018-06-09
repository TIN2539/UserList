namespace UserList.View
{
	partial class RegistrationView
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
			this.usernamePictureBox = new System.Windows.Forms.PictureBox();
			this.passwordPictureBox = new System.Windows.Forms.PictureBox();
			this.cacelButton = new System.Windows.Forms.Button();
			this.registerButton = new System.Windows.Forms.Button();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.confirmPasswordPictureBox = new System.Windows.Forms.PictureBox();
			this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
			this.confirmPasswordLabel = new System.Windows.Forms.Label();
			this.registeredToolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.usernamePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.confirmPasswordPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// usernamePictureBox
			// 
			this.usernamePictureBox.Image = global::UserList.Properties.Resources.Incorrect;
			this.usernamePictureBox.Location = new System.Drawing.Point(300, 12);
			this.usernamePictureBox.Name = "usernamePictureBox";
			this.usernamePictureBox.Size = new System.Drawing.Size(23, 20);
			this.usernamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.usernamePictureBox.TabIndex = 15;
			this.usernamePictureBox.TabStop = false;
			this.usernamePictureBox.MouseEnter += new System.EventHandler(this.UsernamePictureBox_MouseEnter);
			// 
			// passwordPictureBox
			// 
			this.passwordPictureBox.Image = global::UserList.Properties.Resources.Incorrect;
			this.passwordPictureBox.Location = new System.Drawing.Point(300, 36);
			this.passwordPictureBox.Name = "passwordPictureBox";
			this.passwordPictureBox.Size = new System.Drawing.Size(23, 20);
			this.passwordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.passwordPictureBox.TabIndex = 14;
			this.passwordPictureBox.TabStop = false;
			this.passwordPictureBox.MouseEnter += new System.EventHandler(this.PasswordPictureBox_MouseEnter);
			// 
			// cacelButton
			// 
			this.cacelButton.Location = new System.Drawing.Point(207, 88);
			this.cacelButton.Name = "cacelButton";
			this.cacelButton.Size = new System.Drawing.Size(87, 23);
			this.cacelButton.TabIndex = 5;
			this.cacelButton.Text = "Cancel";
			this.cacelButton.UseVisualStyleBackColor = true;
			this.cacelButton.Click += new System.EventHandler(this.CacelButton_Click);
			// 
			// registerButton
			// 
			this.registerButton.Enabled = false;
			this.registerButton.Location = new System.Drawing.Point(115, 88);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(86, 23);
			this.registerButton.TabIndex = 4;
			this.registerButton.Text = "Register";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Location = new System.Drawing.Point(115, 12);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(179, 20);
			this.usernameTextBox.TabIndex = 1;
			this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(115, 36);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(179, 20);
			this.passwordTextBox.TabIndex = 2;
			this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(9, 39);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(56, 13);
			this.passwordLabel.TabIndex = 10;
			this.passwordLabel.Text = "Password:";
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(9, 15);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(58, 13);
			this.usernameLabel.TabIndex = 8;
			this.usernameLabel.Text = "Username:";
			// 
			// confirmPasswordPictureBox
			// 
			this.confirmPasswordPictureBox.Image = global::UserList.Properties.Resources.Incorrect;
			this.confirmPasswordPictureBox.Location = new System.Drawing.Point(300, 62);
			this.confirmPasswordPictureBox.Name = "confirmPasswordPictureBox";
			this.confirmPasswordPictureBox.Size = new System.Drawing.Size(23, 20);
			this.confirmPasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.confirmPasswordPictureBox.TabIndex = 18;
			this.confirmPasswordPictureBox.TabStop = false;
			this.confirmPasswordPictureBox.MouseEnter += new System.EventHandler(this.ConfirmPasswordPictureBox_MouseEnter);
			// 
			// confirmPasswordTextBox
			// 
			this.confirmPasswordTextBox.Location = new System.Drawing.Point(115, 62);
			this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
			this.confirmPasswordTextBox.PasswordChar = '*';
			this.confirmPasswordTextBox.Size = new System.Drawing.Size(179, 20);
			this.confirmPasswordTextBox.TabIndex = 3;
			this.confirmPasswordTextBox.TextChanged += new System.EventHandler(this.ConfirmPasswordTextBox_TextChanged);
			// 
			// confirmPasswordLabel
			// 
			this.confirmPasswordLabel.AutoSize = true;
			this.confirmPasswordLabel.Location = new System.Drawing.Point(9, 65);
			this.confirmPasswordLabel.Name = "confirmPasswordLabel";
			this.confirmPasswordLabel.Size = new System.Drawing.Size(93, 13);
			this.confirmPasswordLabel.TabIndex = 16;
			this.confirmPasswordLabel.Text = "Confirm password:";
			// 
			// registeredToolTip
			// 
			this.registeredToolTip.ToolTipTitle = "Validation Error";
			// 
			// RegistrationView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 118);
			this.Controls.Add(this.confirmPasswordPictureBox);
			this.Controls.Add(this.confirmPasswordTextBox);
			this.Controls.Add(this.confirmPasswordLabel);
			this.Controls.Add(this.usernamePictureBox);
			this.Controls.Add(this.passwordPictureBox);
			this.Controls.Add(this.cacelButton);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.usernameLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "RegistrationView";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registration";
			((System.ComponentModel.ISupportInitialize)(this.usernamePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.confirmPasswordPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox usernamePictureBox;
		private System.Windows.Forms.PictureBox passwordPictureBox;
		private System.Windows.Forms.Button cacelButton;
		private System.Windows.Forms.Button registerButton;
		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.PictureBox confirmPasswordPictureBox;
		private System.Windows.Forms.TextBox confirmPasswordTextBox;
		private System.Windows.Forms.Label confirmPasswordLabel;
		private System.Windows.Forms.ToolTip registeredToolTip;
	}
}