namespace UserList.Module
{
	internal interface ILoginService
	{
		bool CorrectPassword(string password);

		bool CorrectUsername(string username);

		bool Login(User user);

		bool LoginButtonState(User user);
	}
}