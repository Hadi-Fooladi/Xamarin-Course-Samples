using SQLite;
using System.Collections.Generic;

namespace DatabaseApp.DB
{
	class Database
	{
		public Database(string databasePath)
		{
			Con = new SQLiteConnection(databasePath);

			Con.CreateTable<Person>();
			Con.CreateTable<Employee>();
		}

		private readonly SQLiteConnection Con;

		public void AddPerson(Person P) => Con.Insert(P);
		public void AddEmployee(Employee E) => Con.Insert(E);

		public IEnumerable<Person> Persons => Con.Table<Person>();
		public IEnumerable<Employee> Employees => Con.Table<Employee>();

		public Person GetPersonByID(int id) => Con.Table<Person>().First(P => P.id == id);
		public Employee GetEmployeeByID(int id) => Con.Table<Employee>().First(P => P.id == id);

		public IEnumerable<Employee> Employees_SortedByWage
			=> Con.Table<Employee>().OrderByDescending(E => E.Wage);

	}
}
