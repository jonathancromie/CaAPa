using System;
using GalaSoft.MvvmLight;
using System.Windows.Input;
using Xamarin.Forms;
using NoteTaker1.Data.ViewModel;
using Microsoft.Practices.ServiceLocation;
using NoteTaker1;
using System.Diagnostics;

namespace NoteTaker1.Data
{
	public class RemindersHomeViewModel : ViewModelBase
	{
		public ICommand RemindersButtonCommand { get; private set; }
		public ICommand PromptingButtonCommand { get; private set; }
		public ICommand MappingButtonCommand { get; private set; }
		public ICommand SettingsButtonCommand { get; private set; }

		public Color backColor { get; set; }

		public RemindersHomeViewModel(IMyNavigationService navigationService)
		{



			//TOP MENU BUTTONS
			RemindersButtonCommand = new Command(() => {
				navigationService.NavigateTo(ViewModelLocator.RemindersHomePageKey);
				//navigationService.GoBack();
			});
			PromptingButtonCommand = new Command(() => {
				navigationService.NavigateTo(ViewModelLocator.PromptingHomePageKey);
			});
			MappingButtonCommand = new Command(() => {
				navigationService.NavigateTo(ViewModelLocator.MappingHomePageKey);
			});
			SettingsButtonCommand = new Command(() => {
				navigationService.NavigateTo(ViewModelLocator.SettingsHomePageKey);

			});

			if (0 == 0)
			{
				//Debug.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~yes");
			}
			backColor = new Color(32,32,32);

		}

	}
}
