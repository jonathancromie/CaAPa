/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:CaAPa.Data"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace CaAPa.Data.ViewModel
{
	/// <summary>
	/// This class contains static references to all the view models in the
	/// application and provides an entry point for the bindings.
	/// </summary>
	public class ViewModelLocator
	{
		public const string ReminderListPageKey = "ReminderListPage";
		public const string ReminderDetailPageKey = "ReminderDetailPage";
		/// <summary>
		/// Initializes a new instance of the ViewModelLocator class.
		/// </summary>
		public ViewModelLocator()
		{
			ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

			////if (ViewModelBase.IsInDesignModeStatic)
			////{
			////    // Create design time view services and models
			////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
			////}
			////else
			////{
			////    // Create run time view services and models
			////    SimpleIoc.Default.Register<IDataService, DataService>();
			////}

			SimpleIoc.Default.Register<ReminderListViewModel>(() => 
				{
					return new ReminderListViewModel(
						SimpleIoc.Default.GetInstance<IMyNavigationService>()
					);
				});
			SimpleIoc.Default.Register<ReminderDetailViewModel>(() => 
				{
					return new ReminderDetailViewModel(
						SimpleIoc.Default.GetInstance<IMyNavigationService>()
					);
				});
		}

		public ReminderListViewModel ReminderList
		{
			get
			{
				return ServiceLocator.Current.GetInstance<ReminderListViewModel>();
			}
		}

		public ReminderListViewModel ReminderDetail
		{
			get
			{
				return ServiceLocator.Current.GetInstance<ReminderListViewModel> ();
			}
		}
		public static void Cleanup()
		{
			// TODO Clear the ViewModels
		}
	}
}