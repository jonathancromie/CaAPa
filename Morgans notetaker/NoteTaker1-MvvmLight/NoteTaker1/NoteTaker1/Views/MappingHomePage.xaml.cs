using System;
using System.Collections.Generic;

using Xamarin.Forms;
using NoteTaker1.Data.ViewModel;
using NoteTaker1.Data;

using Xamarin.Forms;

namespace NoteTaker1
{
	public partial class MappingHomePage : BaseView
	{
		public MappingHomePage()
		{
			BindingContext = App.Locator.MappingHome;
			InitializeComponent();
			base.Init();
			Title = "Mapping";
			//Icon =
		}

		protected override void OnAppearing()
		{
			NavigationPage.SetHasBackButton(this, false);
		}
	}
}
