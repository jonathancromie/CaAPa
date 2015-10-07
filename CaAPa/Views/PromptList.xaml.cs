using System;
using System.Collections.Generic;
using Xamarin.Forms;
using CaAPa.Data.ViewModel;
using Microsoft.Practices.ServiceLocation;
using CaAPa.Data;

using Xamarin.Forms;

namespace CaAPa
{
	public partial class PromptList : BaseView
	{
		public PromptList ()
		{
			InitializeComponent ();
			base.Init ();
			BindingContext = App.Locator.PromptList;
		}

		protected void ButtonClicked(Object sender, EventArgs e) {
			Navigation.PushAsync (new PromptDetailPage ());
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			var vm = ServiceLocator.Current.GetInstance<ReminderListViewModel> ();
			vm.OnAppearing ();
		}
	}
}

