using System;

namespace CaAPa.Data
{
	public class Reminder
	{
		public string TitleText { get; set; }
		public string TimeStamp { get; set; }	
		public string ReminderDetail { get; set; }
		public string ActionRequiredFlag { get; set; }


		public Reminder (string titleText, string timeStamp = "", string reminderDetail = "", string actionRequiredFlag = "")
		{
			TitleText = titleText;
			TimeStamp = timeStamp;
			ReminderDetail = reminderDetail;
			ActionRequiredFlag = actionRequiredFlag;
		}
	}
}

