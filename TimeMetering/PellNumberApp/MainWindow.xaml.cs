using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PellNumber
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		Rectangle[] rtg = new Rectangle[2];

		public static double Method1(double n) //циклический метод
		{
			if (n == 0)
				return 0;

			else if (n == 1)
				return 1;

			else if (n == 2)
				return 2;

			else
			{
				double p = 0;
				double p1 = 1;
				double p2 = 2;

				for (int i = 2; i < n; i++)
				{
					p = 2 * p2 + p1;
					p1 = p2;
					p2 = p;
				}

				return p;
			}
		}

		public static double Method2(double n) //рекурсивный метод
		{
			if (n == 0)
				return 0;
			else if (n == 1)
				return 1;
			else
				return 2 * Method2(n - 1) + Method2(n - 2);

		}

		private void CalcUs_Click(object sender, RoutedEventArgs e)
		{
			LTime.Content = "Время вычисления:";
			DateTime t1 = DateTime.Now;
			LRes.Content = Method1(Convert.ToDouble(TBNum.Text));
			DateTime t2 = DateTime.Now;
			TimeSpan interval = t2 - t1;
			LTime.Content += " " + interval.Ticks;

			rtg[0] = new Rectangle(); //график
			rtg[0].Width = 5;
			rtg[0].Fill = Brushes.Green;
			double lth = interval.Ticks;
			rtg[0].Height = lth / 10000;
			Graph.Children.Add(rtg[0]);
			Thickness pos = new Thickness(19, 37, 0, 0);
			rtg[0].Margin = pos;
		}

		private void Calc_Click(object sender, RoutedEventArgs e)
		{
			LTime.Content = "Время вычисления:";
			DateTime t1 = DateTime.Now;
			LRes.Content = Method2(Convert.ToDouble(TBNum.Text));
			DateTime t2 = DateTime.Now;
			TimeSpan interval = t2 - t1;
			LTime.Content += " " + interval.Ticks;

			rtg[1] = new Rectangle(); //график
			rtg[1].Width = 5;
			rtg[1].Fill = Brushes.Green;
			double lth = interval.Ticks;
			rtg[1].Height = lth / 10000;
			Graph.Children.Add(rtg[1]);
			Thickness pos = new Thickness(-7, 37, 0, 0);
			rtg[1].Margin = pos;
		}
		
	}
}
