namespace UserList.Module
{
	internal interface IRegistrationService
	{
		bool CheckConfirmPassword(string confirmPaswword, string password);

		bool CheckPassword(string password);

		bool CheckUserInSource(string username);

		bool ChecUsername(string username);

		void Register(User user);
	}
}