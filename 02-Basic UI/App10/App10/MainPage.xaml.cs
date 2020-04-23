using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App10
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			//var SL = new StackLayout();
			//var lbl = new Label
			//{
			//	Text = "Xamarin.Forms (C#)",
			//	TextColor = Color.Red,
			//	HorizontalOptions = LayoutOptions.Center,
			//	VerticalOptions = LayoutOptions.CenterAndExpand
			//};

			//SL.Children.Add(lbl);

			//Content = SL;
		}

		private void bAdd_Clicked(object sender, EventArgs e)
		{
			float
				Num1 = float.Parse(tbNumber1.Text),
				Num2 = float.Parse(tbNumber2.Text),
				Result = Num1 + Num2;

			lblResult.Text = $"{Num1} + {Num2} = {Result}";
		}
	}
}
