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
using pryzhok;


namespace Jumper
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		Prygun jump = new Prygun();


		public MainWindow()
		{
			InitializeComponent();
		}

		private void Count_Click(object sender, RoutedEventArgs e)
		{
			double worst = Convert.ToDouble(TBw.Text);
			double best = Convert.ToDouble(TBb.Text);

			if (worst <= best)
			{
				jump.SetWorstjump(Convert.ToDouble(TBw.Text));
                jump.SetBestjump(Convert.ToDouble(TBb.Text));
                Lavg.Content = "Средний прыжок: " + jump.Average();
                Lrec.Content = "Не хватило до рекорда: " + jump.Record(Convert.ToDouble(TBr.Text)); 


                ErrorMessage.Content = "";

            }

			else
			{
				ErrorMessage.Content = "Значение худшего прышка не может превышать значение лучшего!";

			}
		}
	}
}
