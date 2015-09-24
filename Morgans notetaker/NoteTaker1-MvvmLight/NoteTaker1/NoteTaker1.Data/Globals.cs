using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaker1.Data
{
	public class Globals
	{
		//Used for detirmining which tab we are in.....
		private string _currentTab;
		//public string GetCurrentTab()
		//{
		//	return _currentTab ?? "reminders";
		//}
		//public void SetCurrentTab(string newTab)
		//{
		//	_currentTab = newTab;
		//}
		public Globals MyGlobals = new Globals();
		public string CurrentTab
		{
			get
			{
				return _currentTab ?? "reminders";
			}
			set
			{
				_currentTab = value;
			}
		}
	}
}
