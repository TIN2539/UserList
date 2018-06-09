using System;
using System.Windows.Forms;
using UserList.Module;
using UserList.Presenter;
using UserList.View;

namespace UserList
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		internal static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var applicationContext = new ApplicationContext();

			var source = new XMLService();
			var loginService = new LoginService(source);
			var registrationService = new RegistrationService(loginService, source);
			var mainService = new MainService(source);

			var authenticationView = new AuthenticationView(applicationContext);
			var registrationView = new RegistrationView(applicationContext);
			var mainView = new MainView(applicationContext);

			var mainPresenter = new MainPresenter(mainView, mainService);
			var registrationPresenter = new RegistrationPresenter(registrationView, registrationService);
			var authenticationPresenter = new AuthenticationPresenter(loginService, authenticationView, mainPresenter, registrationPresenter);

			authenticationPresenter.Run();
		}
	}
}