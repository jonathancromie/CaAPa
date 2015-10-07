using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace CaAPa.Data.ViewModel
{
	public class PromptListViewModel : ViewModelBase
	{
		private IMyNavigationService navigationService;

//		public ObservableCollection<Prompt> PromptList {
//			get {
//				var database = new PromptsTable ();
//				var x = database.GetAll ();
//				return new ObservableCollection<Prompt> (x);
//			}
//		}

//		public ICommand NewPromptCommand { get; private set; }
//		/// <summary>
//		/// Initializes a new instance of the MainViewModel class.
//		/// </summary>
//		public PromptListViewModel(IMyNavigationService navigationService)
//		{
//			this.navigationService = navigationService;
//			////if (IsInDesignMode)
//			////{
//			////    // Code runs in Blend --> create design time data.
//			////}
//			////else
//			////{
//			////    // Code runs "for real"
//			////}
//
//			NewPromptCommand = new Command (() => this.navigationService.NavigateTo (ViewModelLocator.PromptDetailPageKey));
//		}

//		public void OnAppearing(){
//			RaisePropertyChanged (() => PromptList);
//		}

	}
}

