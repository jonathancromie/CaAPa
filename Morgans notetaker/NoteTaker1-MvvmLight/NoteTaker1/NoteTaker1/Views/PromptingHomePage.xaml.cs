using System;
using System.Collections.Generic;

using Xamarin.Forms;
using NoteTaker1.Data.ViewModel;
using NoteTaker1.Data;

using Xamarin.Forms;

namespace NoteTaker1
{
	public partial class PromptingHomePage : BaseView
	{
		public PromptingHomePage()
		{
			BindingContext = App.Locator.PromptingHome;
			InitializeComponent();
			base.Init();
			Title = "Prompting";
			//Icon =
		}

		protected override void OnAppearing()
		{
			NavigationPage.SetHasBackButton(this, false);
		}
	}
}
