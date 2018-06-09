namespace UserList.Module
{
	internal interface ILoginService
	{
		bool CorrectPassword(string password);

		bool CorrectUsername(string usrename);

		bool Login(User user);

		bool LoginButtonState(User user);
	}
}