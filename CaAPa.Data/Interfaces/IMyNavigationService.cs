﻿using System;
using GalaSoft.MvvmLight.Views;
using Xamarin.Forms;

namespace CaAPa.Data
{
	public interface IMyNavigationService : INavigationService
	{
		Page CurrentPage{get;}

		void ClearHistory (string pageKey);

		void NavigateToModal (string pageKey);

		void NavigateToModal (string pageKey, object parameter);

		bool IsModal{ get; }

		void SetNavigationBarVisibility (bool visible);
	}
}