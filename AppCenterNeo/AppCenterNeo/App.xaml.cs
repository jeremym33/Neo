using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Center = Microsoft.AppCenter;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace AppCenterNeo
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            Center.AppCenter.Start("android=6ca7c8c5-eb42-4166-afa2-522c8a3235d9;" +
                 "uwp={Your UWP App secret here};" +
                 "ios={Your iOS App secret here}",
                 typeof(Analytics), typeof(Crashes));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
