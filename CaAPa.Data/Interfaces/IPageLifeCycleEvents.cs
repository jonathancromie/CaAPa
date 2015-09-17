using System;

namespace CaAPa.Data
{
	public interface IPageLifeCycleEvents
	{
		void OnAppearing();
		void OnDisappearing();
		void OnLayoutChanged();
	}
}

