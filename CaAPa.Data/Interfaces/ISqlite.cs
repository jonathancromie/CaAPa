using System;
using SQLite.Net;

namespace CaAPa.Data
{
	public interface ISqlite
	{
		SQLiteConnection GetConnection();
	}
}

