using SQLite;

namespace DatabaseApp.DB
{
	class Person
	{
		[PrimaryKey, AutoIncrement]
		public int id { get; set; }

		public string Name { get; set; }

		public int Age { get; set; }

		[Ignore]
		public int Dummy { get; set; }

		public override string ToString() => $"{Name} (id: {id}) [Age: {Age}]";
	}
}
