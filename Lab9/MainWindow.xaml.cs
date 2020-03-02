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
using ClassJump;

namespace Lab9
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Jumper jump = new Jumper();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Calc_Click(object sender, RoutedEventArgs e)
		{
			if (LRec.Text == "")
			{
				MessageBox.Show("Введите рекорд.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
				LRec.Background = Brushes.Red;
			}
			else
			{
				double rec = Convert.ToDouble(LRec.Text);
				if (rec < 3)
				{
					MessageBox.Show("Введите рекорд от 3.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
					LRec.Background = Brushes.Red;
				}
				else
				{
					LTable.Content = "";
					Random r = new Random();
					int num = 1;
					double jmp;
					double worse = 999;
					int nrg = 4;

					while (nrg > 0)
					{
						double ver = jump.Spade();

						if (ver > 25)
							jmp = (r.Next(300, 951)) / 100.00;

						else jmp = 0;

						if (jmp < worse)
						{
							worse = jmp;
							nrg--;
						}

						LTable.Content += num++ + " прыжок\t";
						LTable.Content += jmp + "\t\t\n";


						if (jmp >= rec)
							break;


					}

				}
			}
		}
	}
}
