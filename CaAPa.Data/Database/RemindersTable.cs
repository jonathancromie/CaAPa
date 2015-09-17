using System;
using SQLite.Net;
using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Ioc;

namespace CaAPa.Data
{
	public class RemindersTable
	{
		SQLiteConnection database;

		public RemindersTable ()
		{
			database = DependencyService.Get<ISqlite> ().GetConnection ();
			//TODO show IOC vs Dependency injection
			//			database = SimpleIoc.Default.GetInstance<ISqlite> ().GetConnection ();
			if (database.TableMappings.All(t => t.MappedType.Name != typeof(Reminder).Name)) {
				database.CreateTable<Reminder> ();
				database.Commit ();
			}
		}

		public List<Reminder> GetAll(){
			var items = database.Table<Reminder> ().ToList<Reminder>();

			return items;
		}

		public int InsertOrUpdateNote(Reminder reminder){
			return database.Table<Reminder> ().Where (x => x.TitleText == reminder.TitleText).Count () > 0 
				? database.Update (reminder) : database.Insert (reminder);
		}

		public Reminder GetReminder(string key){
			return database.Table<Reminder> ().First (t => t.TitleText == key); 
		}
	}
}

