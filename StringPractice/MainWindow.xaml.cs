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

namespace Strings
{
	/// <summary>
	/// Р›РѕРіРёРєР° РІР·Р°РёРјРѕРґРµР№СЃС‚РІРёСЏ РґР»СЏ MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Calc_Click(object sender, RoutedEventArgs e)
		{
			Random r = new Random();

			string str = "";
			char[] check = new char[3];
			char letterrep = (char)r.Next('A', 'Z' + 1);

			while (str.Length < 4)
			{
				char letter = (char)r.Next('A', 'Z' + 1);
				int number = r.Next(0, 10);
				str += Convert.ToString(letter) +  Convert.ToString(number);

				
			}

			for (int i = 0; i < 3; i++)
			{
				if (str[i] >= '0' && str[i] <= '9')
				{
					str = str.Replace(str[i], letterrep);
				}
				


			}


	

			Label.Content = str;

		}
	}
}
