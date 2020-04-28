using System.IO;
using Xamarin.Essentials;

namespace DatabaseApp
{
	using DB;

    static class Global
	{
		public static Database Database { get; private set; }

		public static void Init()
		{
			var Root = FileSystem.AppDataDirectory;
			var Filename = Path.Combine(Root, "Database.db3");

			Database = new Database(Filename);
		}
	}
}
