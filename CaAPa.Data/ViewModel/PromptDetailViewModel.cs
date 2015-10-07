using System;
using GalaSoft.MvvmLight;
using System.Windows.Input;
using Xamarin.Forms;
using CaAPa.Data.ViewModel;
using Microsoft.Practices.ServiceLocation;

namespace CaAPa.Data
{
	public class PromptDetailViewModel : ViewModelBase
	{
		public ICommand SavePromptCommand { get; private set; }
		private String promptName;

		public String PromptName
		{
			get { return promptName; }
			set { promptName = value;
				RaisePropertyChanged(() => PromptName); }
		}

		private string promptLocation;

		public string PromptLocation
		{
			get { return promptLocation; }
			set { promptLocation = value;
				RaisePropertyChanged(() => promptLocation); }
		}

//		public PromptDetailViewModel (IMyNavigationService navigationService)
//		{
//			var database = new PromptsTable();
//			SavePromptCommand = new Command (() => {
//				database.InsertOrUpdateNote(new Reminder(PromptName, PromptLocation));
//				navigationService.GoBack();
//			});
//		}
	}
}

