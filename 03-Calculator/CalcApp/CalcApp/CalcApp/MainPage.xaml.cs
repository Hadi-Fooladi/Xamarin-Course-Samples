using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcApp
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			for(int i = 1; i <= 9; i++)
			{
				int
					Row = (i - 1) / 3,
					Col = (i - 1) % 3;

				var B = new Button { Text = i.ToString() };
				B.Clicked += bNumber_Clicked;

				G.Children.Add(B, Col, Row);
			}

			var bZero = new Button { Text = "0" };
			bZero.Clicked += bNumber_Clicked;
			G.Children.Add(bZero, 0, 3, 3, 4);
		}

		private int Num1;
		private char Op = '?';

		private void ApplyOperator(char Op)
		{
			this.Op = Op;

			Num1 = int.Parse(TB.Text);
			TB.Text = "0";
		}

		private void bNumber_Clicked(object sender, EventArgs e)
		{
			var B = (Button)sender;

			var S = TB.Text;
			var Num = B.Text;

			if (S == "0")
				TB.Text = Num;
			else
				TB.Text += Num;
		}

		private void bDel_Clicked(object sender, EventArgs e)
		{
			var S = TB.Text;
			S = S.Substring(0, S.Length - 1);

			if (S.Length == 0)
				TB.Text = "0";
			else TB.Text = S;
		}

		private void bPlus_Clicked(object sender, EventArgs e) => ApplyOperator('+');
		private void bMinus_Clicked(object sender, EventArgs e) => ApplyOperator('-');

		private void bEqual_Clicked(object sender, EventArgs e)
		{
			if (Op == '?') return;

			int
				Num2 = int.Parse(TB.Text),
				Result;

			switch (Op)
			{
				case '+': Result = Num1 + Num2; break;
				case '-': Result = Num1 - Num2; break;
				default: return;
			}

			Op = '?';
			TB.Text = Result.ToString();
		}
	}
}
