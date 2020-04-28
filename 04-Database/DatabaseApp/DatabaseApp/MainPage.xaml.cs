using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DatabaseApp
{
	using DB;

	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			Global.Init();
			var DB = Global.Database;

			var E = new Employee
			{
				Name = "ABC",
				Age = 34,
				Wage = 45000
			};

			DB.AddEmployee(E);

			var SB = new StringBuilder();
			foreach (var emp in DB.Employees_SortedByWage)
				SB.AppendLine(emp.ToString());

			lbl.Text = SB.ToString();
		}
	}
}
