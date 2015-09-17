using System;
using System.Collections.Generic;
using Xamarin.Forms;
using CaAPa.Data.ViewModel;
using Microsoft.Practices.ServiceLocation;
using CaAPa.Data;

namespace CaAPa
{
	public partial class ReminderList : BaseView
	{
		public ReminderList ()
		{
			InitializeComponent ();
			base.Init ();
			BindingContext = App.Locator.ReminderList;
		}

		protected void ButtonClicked(Object sender, EventArgs e) {
			Navigation.PushAsync (new ReminderDetailPage ());
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			var vm = ServiceLocator.Current.GetInstance<ReminderListViewModel> ();
			vm.OnAppearing ();
		}
	}
}

