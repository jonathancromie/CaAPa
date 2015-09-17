using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace CaAPa.Data.ViewModel
{
	/// <summary>
	/// This class contains properties that the main View can data bind to.
	/// <para>
	/// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
	/// </para>
	/// <para>
	/// You can also use Blend to data bind with the tool's support.
	/// </para>
	/// <para>
	/// See http://www.galasoft.ch/mvvm
	/// </para>
	/// </summary>
	public class ReminderListViewModel : ViewModelBase
	{
		private IMyNavigationService navigationService;

		public ObservableCollection<Reminder> ReminderList {
			get {
				var database = new RemindersTable ();
				var x = database.GetAll ();
				return new ObservableCollection<Reminder> (x);
			}
		}


		public ICommand NewReminderCommand { get; private set; }
		/// <summary>
		/// Initializes a new instance of the MainViewModel class.
		/// </summary>
		public ReminderListViewModel(IMyNavigationService navigationService)
		{
			this.navigationService = navigationService;
			////if (IsInDesignMode)
			////{
			////    // Code runs in Blend --> create design time data.
			////}
			////else
			////{
			////    // Code runs "for real"
			////}

			NewReminderCommand = new Command (() => this.navigationService.NavigateTo (ViewModelLocator.ReminderDetailPageKey));
		}

		public void OnAppearing(){
			RaisePropertyChanged (() => ReminderList);
		}

	}
}