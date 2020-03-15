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

namespace Captcha
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

		private void GenButt_Click(object sender, RoutedEventArgs e)
		{
			Random r = new Random();
			TbUser.Text = "";
			Captcha.Content = "";

			char letter1 = (char)r.Next('A', 'Z' + 1);
			char letter2 = 'A';
			while (letter1 == letter2)
				letter2 = (char)r.Next('A', 'Z' + 1);
			int num1 = r.Next(0, 10);
			int num2 = 0;
			while (num2 == num1)
				num2 = r.Next(0, 10);

			string[] arr =  { Convert.ToString(num1), Convert.ToString(letter1) ,
			Convert.ToString(num2) , Convert.ToString(letter2) };

			for (int i = arr.Length - 1; i >= 1; i--)
			{
				int j = r.Next(i + 1);
				var temp = arr[j];
				arr[j] = arr[i];
				arr[i] = temp;
			}

			for (int i = 0; i < arr.Length; i++)
				Captcha.Content += arr[i];
			
		}

		private void VerButt_Click(object sender, RoutedEventArgs e)
		{
			string input = Convert.ToString(TbUser.Text);
		
			if (Convert.ToString(input.ToUpper()) == Convert.ToString(Captcha.Content))
				MessageBox.Show("Input matches", "", MessageBoxButton.OK, MessageBoxImage.Information);
			else 
				MessageBox.Show("Input doesn't match", "", MessageBoxButton.OK, MessageBoxImage.Error);

		}
	}
}
