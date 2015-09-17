﻿using System;
using CaAPa.Data;
using SQLite.Net;
using System.IO;
using Xamarin.Forms;
using CaAPa.Droid;

//TODO show IOC vs Dependency Injection
[assembly: Dependency (typeof (SqliteDroid))]

namespace CaAPa.Droid
{
	public class SqliteDroid : ISqlite
	{
		public SqliteDroid(){
		}
		#region ISqlite implementation

		public SQLiteConnection GetConnection ()
		{
			const string sqliteFilename = "database.db3";
			var documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var path = Path.Combine (documentsPath, sqliteFilename);
			var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
			//Create the connection
			var conn = new SQLiteConnection(plat,path);

			return conn;
		}

		#endregion


	}
}