using System;
using System.Reflection;

namespace CaAPa.Data
{
	public class Prompt
	{
		public string Name{ get; set; }
		public string Location { get; set; }

		// what else?

		public Prompt (string name, string location)
		{
			Name = name;
			Location = location;
		}
	}
}

