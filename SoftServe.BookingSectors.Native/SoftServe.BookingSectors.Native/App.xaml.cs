using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoftServe.BookingSectors.Native
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
			// To inject all of dependencies of the view you must create page instance like a following:
			// MainPage = new NavigationPage(Resolver.Resolve<SomeView>());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
