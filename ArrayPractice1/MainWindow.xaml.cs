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

namespace MassivePractice1
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

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            string[] uName = new string[] {"Драконы", "Эльфы", "Лошади", "Гномы", "Дриады", "Студенты"};
            int[] uSpeed = new int[] {20, 8, 15, 2, 4, 1 };
            string[] strCount = TBCount.Text.Split(' ');
            int n = uName.Length;
			int min;
            int[] intCount = new int[n];
            for (int i = 0; i < n; i++)
                if (i < strCount.Length)
                    intCount[i] = Convert.ToInt32(strCount[i]);
                else
                    intCount[i] = 0;
            LUnit.Content += "";
            LV.Content += "";
            LCount.Content += "";
            for(int i = 0; i < n; i++)
            {
                LUnit.Content += uName[i] + "\n";
                LV.Content += uSpeed[i] + "\n";
                LCount.Content += intCount[i] + "\n";

            }
			int pos = -1;
			for (int i = 0; i < n; i++)
				if (intCount[i] > 0)
					pos = i;
			if (pos < 0)
			
				MessageBox.Show("Возьмите с собой армию!");
			
			else
			{
				min = uSpeed[pos];
				for (int i = 0; i < n; i++)
					if (intCount[i] > 0 && uSpeed[i] < min)
						min = uSpeed[i];
				LVAll.Content = "Скорость: " + min;
			}
			


        }
    }
}
