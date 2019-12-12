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
using Room;

namespace ArrayPractice2
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

		Flat flat = new Flat();

		private void Calc_Click(object sender, RoutedEventArgs e)
		{
			int count = Convert.ToInt32(TBRooms.Text);
			double dop = Convert.ToDouble(TBNotlive.Text);
			flat.CreateFlat(count, dop);
			LLive.Content = flat.Area();
			LTotal.Content = flat.AllArea();
			LRooms.Content = "";
			
		}
	}
}
