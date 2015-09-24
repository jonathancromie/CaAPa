using System;
using GalaSoft.MvvmLight;
using System.Windows.Input;
using Xamarin.Forms;
using NoteTaker1.Data.ViewModel;
using Microsoft.Practices.ServiceLocation;

namespace NoteTaker1.Data
{
	public class TabbedHomeViewModel : ViewModelBase
	{
		public ICommand RemindersButtonCommand { get; private set; }
		public ICommand PromptingButtonCommand { get; private set; }
		public ICommand MappingButtonCommand { get; private set; }
		public ICommand SettingsButtonCommand { get; private set; }

		public TabbedHomeViewModel(IMyNavigationService navigationService)
		{

		}

	}
}
