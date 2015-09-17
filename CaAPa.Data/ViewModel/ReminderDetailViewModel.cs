using System;
using GalaSoft.MvvmLight;
using System.Windows.Input;
using Xamarin.Forms;
using CaAPa.Data.ViewModel;
using Microsoft.Practices.ServiceLocation;

namespace CaAPa.Data
{
	public class ReminderDetailViewModel :ViewModelBase
	{
		public ICommand SaveReminderCommand { get; private set;}
		private String reminderTitle;

		public String ReminderTitle
		{
			get { return reminderTitle; }
			set { reminderTitle = value;
				RaisePropertyChanged(() => ReminderTitle); }
		}

		private string reminderDetail;

		public string ReminderDetail
		{
			get { return reminderDetail; }
			set { reminderDetail = value;
				RaisePropertyChanged(() => ReminderDetail); }
		}

		private bool reminderActionFlag;

		public bool ReminderActionFlag
		{
			get { return reminderActionFlag; }
			set { reminderActionFlag = value;
				RaisePropertyChanged(() => ReminderActionFlag); }
		}


		public ReminderDetailViewModel (IMyNavigationService navigationService)
		{
			var database = new RemindersTable();
			SaveReminderCommand = new Command (() => {
				database.InsertOrUpdateNote(new Reminder(ReminderTitle,DateTime.Now.ToString(),ReminderActionFlag.ToString(),ReminderDetail));
				navigationService.GoBack();
			});
		}


	}
}
