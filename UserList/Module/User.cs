namespace UserList.Module
{
	internal class User
	{
		private readonly string password;
		private readonly string username;

		public User(string username, string password)
		{
			this.password = password;
			this.username = username;
		}

		public string Password => password;

		public string Username => username;
	}
}