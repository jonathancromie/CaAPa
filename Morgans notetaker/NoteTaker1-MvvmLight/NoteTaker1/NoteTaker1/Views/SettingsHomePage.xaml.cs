using System;
using System.Collections.Generic;

using Xamarin.Forms;
using NoteTaker1.Data.ViewModel;
using NoteTaker1.Data;

namespace NoteTaker1
{
	public partial class SettingsHomePage : BaseView
	{
		public SettingsHomePage()
		{
			BindingContext = App.Locator.SettingsHome;
			InitializeComponent();
			base.Init();
			Title = "Settings";
			//Icon =
		}

		protected override void OnAppearing()
		{
			NavigationPage.SetHasBackButton(this, false);
		}

	}
}
