using System;
using System.Collections.Generic;

using Xamarin.Forms;
using NoteTaker1.Data.ViewModel;
using NoteTaker1.Data;

namespace NoteTaker1
{
	public partial class RemindersHomePage : BaseView
	{
		public RemindersHomePage()
		{
			BindingContext = App.Locator.RemindersHome;
			InitializeComponent();
			base.Init();
			Title = "Reminders";
			Icon = "monkeyicon.png";
		}

		protected override void OnAppearing()
		{
			NavigationPage.SetHasBackButton(this, false);
			NavigationPage.SetTitleIcon(this, "monkeyicon.png");
			
		}

	}
}
