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

namespace Lab7
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
			Rec.Visibility = Visibility.Hidden;
			LRec.Visibility = Visibility.Hidden;
		}

		private void Task_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			switch (Task.SelectedIndex)
			{
				case 0:
					Rec.Visibility = Visibility.Hidden;
					LRec.Visibility = Visibility.Hidden;
					break;
				case 1:
					Rec.Visibility = Visibility.Visible;
					LRec.Visibility = Visibility.Visible;
					break;
			}

		}

		private void Calc_Click(object sender, RoutedEventArgs e)
        {

            Wjump.Background = Brushes.White;
            Bjump.Background = Brushes.White;
            Rec.Background = Brushes.White;
            Result.Content = "";



            switch (Units.SelectedIndex)
            {
                case 0:
                    jump.SetDigits("см");
                   

                        break;

                case 1:

                    jump.SetDigits("м");

                        break;

            }

            double worst = Convert.ToDouble(Wjump.Text);
            double best = Convert.ToDouble(Bjump.Text);
            // double record = Convert.ToDouble(Rec.Text);

            if ((Task.SelectedIndex == 1) & ((Units.SelectedIndex == 0 | Units.SelectedIndex == 1) & (Rec.Text == "")))
            {
                MessageBox.Show("Некорректный ввод. Введите положительные числа", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else  if ((worst <= 0) | (best <= 0) | (Wjump.Text == "") | (Wjump.Text == ""))

            {

                if (worst <= 0)
                    Wjump.Background = Brushes.LightPink;
                if (best <= 0)
                    Bjump.Background = Brushes.LightPink;

                MessageBox.Show("Некорректный ввод. Введите положительные числа", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else
            {


                switch (Task.SelectedIndex)
                {
                    case 0:

                        jump.SetWorstjump(Convert.ToDouble(Wjump.Text));
                        jump.SetBestjump(Convert.ToDouble(Bjump.Text));
                        Result.Content = jump.Average() + " " + jump.GetDigits();

                        break;

                    case 1:
                        double record = Convert.ToDouble(Rec.Text);
                        if (record <= 0) 
                        {
                            MessageBox.Show("Некорректный ввод. Введите положит. значение рекорда", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else if (record < best)  {
                            jump.SetWorstjump(Convert.ToDouble(Wjump.Text));
                            jump.SetBestjump(Convert.ToDouble(Bjump.Text));
                            MessageBox.Show("Рекорд побит!", "Поздравляем", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                            else
                        {
                            jump.SetWorstjump(Convert.ToDouble(Wjump.Text));
                            jump.SetBestjump(Convert.ToDouble(Bjump.Text));
                            Result.Content = jump.Record(Convert.ToDouble(Rec.Text)) + " " + jump.GetDigits();
                        }
                        break;

                }

            

           
            }
        }
	}
}
