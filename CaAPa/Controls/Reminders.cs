using System;

namespace CaAPa
{
	public class Reminders
	{
		private String titleText;
		public string TimeStamp;
		public string ActionRequiredFlag;


		public Reminders (string titleText, string timestamp, string actionRequiredFlag)
		{
			titleText = titleText;
			TimeStamp = timestamp;
			ActionRequiredFlag = actionRequiredFlag;
		}
	}
}

