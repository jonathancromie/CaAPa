using System;
using System.Collections.Generic;

using Xamarin.Forms;
using NoteTaker1.Data.ViewModel;
using NoteTaker1.Data;

using Xamarin.Forms;

namespace NoteTaker1
{
	public partial class TabbedHomePage : TabbedPage
	{
		public TabbedHomePage()
		{
			BindingContext = App.Locator.TabbedHome;
			InitializeComponent();
			//base.Init();
			Title = "Home";
			//Icon =

			Children.Add(new SettingsHomePage());
			Children.Add(new RemindersHomePage());

		}

		protected void Init()
		{

			var lifecycleHandler = this.BindingContext as IPageLifeCycleEvents;

			if (lifecycleHandler != null)
			{
				base.Appearing += (object sender, EventArgs e) => {
					lifecycleHandler.OnAppearing();
				};
				base.Disappearing += (object sender, EventArgs e) => {
					lifecycleHandler.OnDisappearing();
				};
				base.LayoutChanged += (object sender, EventArgs e) => {
					lifecycleHandler.OnLayoutChanged();
				};
			}
		}

		protected override void OnAppearing()
		{
			
		}
	}
}