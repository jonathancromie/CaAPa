using System;
using GalaSoft.MvvmLight.Ioc;
using Xamarin.Forms;
using CaAPa.Data.ViewModel;
using CaAPa.Data;

namespace CaAPa
{
	public class App : Application
	{
		private static ViewModelLocator _locator;
		private static NavigationService nav;
		public static ViewModelLocator Locator
		{
			get
			{
				return _locator ?? (_locator = new ViewModelLocator());
			}
		}

		public App ()
		{
			// The root page of your application
			MainPage = GetMainPage();
		}

		public Page GetMainPage()
		{
			nav = new NavigationService ();
			nav.Configure (ViewModelLocator.ReminderListPageKey, typeof(ReminderList));
			nav.Configure (ViewModelLocator.ReminderDetailPageKey, typeof(ReminderDetailPage));
			SimpleIoc.Default.Register<IMyNavigationService> (()=> nav, true);
			var navPage = new NavigationPage (new ReminderList ());
			nav.Initialize (navPage);
			return navPage;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
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

