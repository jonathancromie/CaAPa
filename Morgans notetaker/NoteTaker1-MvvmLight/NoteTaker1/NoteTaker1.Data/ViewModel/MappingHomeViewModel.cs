using System;
using GalaSoft.MvvmLight;
using System.Windows.Input;
using Xamarin.Forms;
using NoteTaker1.Data.ViewModel;
using Microsoft.Practices.ServiceLocation;

namespace NoteTaker1.Data
{
	public class MappingHomeViewModel : ViewModelBase
	{
		public ICommand RemindersButtonCommand { get; private set; }
		public ICommand PromptingButtonCommand { get; private set; }
		public ICommand MappingButtonCommand { get; private set; }
		public ICommand SettingsButtonCommand { get; private set; }

		public MappingHomeViewModel(IMyNavigationService navigationService)
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
		}

	}
}
