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

namespace Lab8NEW
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
	
		private void StartBut_Click(object sender, RoutedEventArgs e)
		{
			Random r = new Random();
			RecLab.Content = "Рекорд: ";
			int n = Convert.ToInt32(NumBox.Text); //количество прыгунов, вводимое пользователем
			double jmp;
			int num = 1;
			double worstjmp = 0;
			double bestjmp = 0;
			double record = 0;

			LTable.Content = "№п/п\t1 прыжок\t2 прыжок\t3 прыжок\t4 прыжок\t5 прыжок \t6 прыжок\t\tХудший прыжок\t\tЛучший прыжок\n";
			LTable.Content += "______________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________\n";

			for(int i = 1; i <= n; i++)
			{
				LTable.Content += "" + num++; 
				for (int j = 1; j < 7; j++)
				{
					int ver = (r.Next(0, 101)); //генерация вероятности

					if (ver > 25)
					{
						jmp = (r.Next(300, 951)) / 100.00; 
									
						if (jmp > record)
							record = jmp;
						if (worstjmp < jmp)
							worstjmp = jmp;
	
					}
					else jmp = 0;
					

					LTable.Content += "\t" + jmp + "\t";	
	
				}
				
				LTable.Content += "                              " + worstjmp + "\t\t\t";
				//LTable.Content += "" + bestjmp;
				LTable.Content += "\n\n";

			}

			RecLab.Content += " " + record;
		}
	}
}
