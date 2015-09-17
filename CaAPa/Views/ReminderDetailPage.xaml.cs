using System;
using System.Collections.Generic;

using Xamarin.Forms;
using CaAPa.Data.ViewModel;
using CaAPa.Data;
using System.ServiceModel.Channels;

namespace CaAPa
{
	public partial class ReminderDetailPage : BaseView
	{
		public ReminderDetailPage ()
		{
			BindingContext = App.Locator.ReminderDetail;
			InitializeComponent ();
			base.Init ();
			Title = "Reminder Details";
		}
	}
}

