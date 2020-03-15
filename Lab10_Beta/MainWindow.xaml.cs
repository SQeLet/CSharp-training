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
using JumperLib;

namespace Lab10
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		int c = 0;
		public MainWindow()
		{
		    InitializeComponent();

			Name1.Visibility = Visibility.Hidden;
			Name2.Visibility = Visibility.Hidden;
			Name2.Visibility = Visibility.Hidden;
			Name3.Visibility = Visibility.Hidden;
			Name4.Visibility = Visibility.Hidden;
			Name5.Visibility = Visibility.Hidden;
			Name6.Visibility = Visibility.Hidden;
			Name7.Visibility = Visibility.Hidden;

			J11.Visibility = Visibility.Hidden;
			J12.Visibility = Visibility.Hidden;
			J13.Visibility = Visibility.Hidden;
			J14.Visibility = Visibility.Hidden;
			J15.Visibility = Visibility.Hidden;
			J16.Visibility = Visibility.Hidden;
			J21.Visibility = Visibility.Hidden;
			J22.Visibility = Visibility.Hidden;
			J23.Visibility = Visibility.Hidden;
			J24.Visibility = Visibility.Hidden;
			J25.Visibility = Visibility.Hidden;
			J26.Visibility = Visibility.Hidden;
			J31.Visibility = Visibility.Hidden;
			J32.Visibility = Visibility.Hidden;
			J33.Visibility = Visibility.Hidden;
			J34.Visibility = Visibility.Hidden;
			J35.Visibility = Visibility.Hidden;
			J36.Visibility = Visibility.Hidden;
			J41.Visibility = Visibility.Hidden;
			J42.Visibility = Visibility.Hidden;
			J43.Visibility = Visibility.Hidden;
			J44.Visibility = Visibility.Hidden;
			J45.Visibility = Visibility.Hidden;
			J46.Visibility = Visibility.Hidden;
			J51.Visibility = Visibility.Hidden;
			J52.Visibility = Visibility.Hidden;
			J53.Visibility = Visibility.Hidden;
			J54.Visibility = Visibility.Hidden;
			J55.Visibility = Visibility.Hidden;
			J56.Visibility = Visibility.Hidden;
			J61.Visibility = Visibility.Hidden;
			J62.Visibility = Visibility.Hidden;
			J63.Visibility = Visibility.Hidden;
			J64.Visibility = Visibility.Hidden;
			J65.Visibility = Visibility.Hidden;
			J66.Visibility = Visibility.Hidden;
			J71.Visibility = Visibility.Hidden;
			J72.Visibility = Visibility.Hidden;
			J73.Visibility = Visibility.Hidden;
			J74.Visibility = Visibility.Hidden;
			J75.Visibility = Visibility.Hidden;
			J76.Visibility = Visibility.Hidden;

		}

		private void ClearButt_Click(object sender, RoutedEventArgs e)
		{
			LRes.Content = "";
			LName.Content = "";
		}

		private void AddButt_Click(object sender, RoutedEventArgs e)
		{
			c++;

			switch (c)
			{
				case 1:

					Name1.Visibility = Visibility.Visible;
					J11.Visibility = Visibility.Visible;
					J12.Visibility = Visibility.Visible;
					J13.Visibility = Visibility.Visible;
					J14.Visibility = Visibility.Visible;
					J15.Visibility = Visibility.Visible;
					J16.Visibility = Visibility.Visible;

					break;

				case 2:

					Name2.Visibility = Visibility.Visible;
					J21.Visibility = Visibility.Visible;
					J22.Visibility = Visibility.Visible;
					J23.Visibility = Visibility.Visible;
					J24.Visibility = Visibility.Visible;
					J25.Visibility = Visibility.Visible;
					J26.Visibility = Visibility.Visible;

					break;

				case 3:

					Name3.Visibility = Visibility.Visible;
					J31.Visibility = Visibility.Visible;
					J32.Visibility = Visibility.Visible;
					J33.Visibility = Visibility.Visible;
					J34.Visibility = Visibility.Visible;
					J35.Visibility = Visibility.Visible;
					J36.Visibility = Visibility.Visible;

					break;

				case 4:

					Name4.Visibility = Visibility.Visible;
					J41.Visibility = Visibility.Visible;
					J42.Visibility = Visibility.Visible;
					J43.Visibility = Visibility.Visible;
					J44.Visibility = Visibility.Visible;
					J45.Visibility = Visibility.Visible;
					J46.Visibility = Visibility.Visible;

					break;

				case 5:

					Name5.Visibility = Visibility.Visible;
					J51.Visibility = Visibility.Visible;
					J52.Visibility = Visibility.Visible;
					J53.Visibility = Visibility.Visible;
					J54.Visibility = Visibility.Visible;
					J55.Visibility = Visibility.Visible;
					J56.Visibility = Visibility.Visible;

					break;

				case 6:

					Name6.Visibility = Visibility.Visible;
					J61.Visibility = Visibility.Visible;
					J62.Visibility = Visibility.Visible;
					J63.Visibility = Visibility.Visible;
					J64.Visibility = Visibility.Visible;
					J65.Visibility = Visibility.Visible;
					J66.Visibility = Visibility.Visible;

					break;

				case 7:

					Name7.Visibility = Visibility.Visible;
					J71.Visibility = Visibility.Visible;
					J72.Visibility = Visibility.Visible;
					J73.Visibility = Visibility.Visible;
					J74.Visibility = Visibility.Visible;
					J75.Visibility = Visibility.Visible;
					J76.Visibility = Visibility.Visible;

					break;

			}

			if (c > 7)
				MessageBox.Show("Вы можете добавить до 7 прыгунов!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

		}

		private void Calc_Click(object sender, RoutedEventArgs e)
		{
			Jump jmp = new Jump();
			Jumper jmper = new Jumper();

			double min = 20000;
			double max = 0;
			LName.Content = "";
			LRes.Content = "";

			if ((J11.Text == "") | (J12.Text == "") | (J13.Text == "") | (J14.Text == "") | (J15.Text == "") | (J16.Text == ""))
				MessageBox.Show("Ошибка ввода!", "вы ошиблись:))", MessageBoxButton.OK, MessageBoxImage.Error);
			else
			{
				jmper.SetName(Convert.ToString(Name1.Text));
				jmper.Array();
				jmper.Arr[0] = Convert.ToDouble(J11.Text); //прыгун 1
				jmper.Arr[1] = Convert.ToDouble(J12.Text);
				jmper.Arr[2] = Convert.ToDouble(J13.Text);
				jmper.Arr[3] = Convert.ToDouble(J14.Text);
				jmper.Arr[4] = Convert.ToDouble(J15.Text);
				jmper.Arr[5] = Convert.ToDouble(J16.Text);

				for (int i = 0; i < jmper.Arr.Length; i++)
				{

					if ((jmper.Arr[i] < 3) | (jmper.Arr[i] > 9.5))
						jmper.Arr[i] = 0;

					if ((jmper.Arr[i] < min) & (jmper.Arr[i] != 0))
						min = jmper.Arr[i];
					if ((jmper.Arr[i] > max) & (jmper.Arr[i] != 0))
						max = jmper.Arr[i];

				}


				LName.Content = "      Имя\n      " + jmper.GetName() + "\n";
				LRes.Content += "  1 прыжок   2 прыжок   3 прыжок   4 прыжок   5 прыжок   6 прыжок	         Лучший     Худший\n";
				LRes.Content += "   " + jmper.Arr[0] + "                " + jmper.Arr[1] + "                  " + jmper.Arr[2] + "                 " + jmper.Arr[3] + "                   " + jmper.Arr[4] + "                  " + jmper.Arr[5] + "                        " + max + "                " + min + "\n";
			}

			if ((J21.Text == "") | (J22.Text == "") | (J23.Text == "") | (J24.Text == "") | (J25.Text == "") | (J26.Text == ""))
				goto E;

			

			max = 0;
			min = 20000;

									jmper.SetName(Convert.ToString(Name2.Text));
									jmper.Arr[0] = Convert.ToDouble(J21.Text); //прыгун 2
									jmper.Arr[1] = Convert.ToDouble(J22.Text);
									jmper.Arr[2] = Convert.ToDouble(J23.Text);
									jmper.Arr[3] = Convert.ToDouble(J24.Text);
									jmper.Arr[4] = Convert.ToDouble(J25.Text);
									jmper.Arr[5] = Convert.ToDouble(J26.Text);

									for (int i = 0; i < jmper.Arr.Length; i++)
									{

										if ((jmper.Arr[i] < 3) | (jmper.Arr[i] > 9.5))
											jmper.Arr[i] = 0;

										if ((jmper.Arr[i] < min) & (jmper.Arr[i] != 0))
											min = jmper.Arr[i];
										if ((jmper.Arr[i] > max) & (jmper.Arr[i] != 0))
											max = jmper.Arr[i];
									}

									LName.Content += "      " + jmper.GetName() + "\n";
									LRes.Content += "   " + jmper.Arr[0] + "                " + jmper.Arr[1] + "                  " + jmper.Arr[2] + "                 " + jmper.Arr[3] + "                   " + jmper.Arr[4] + "                  " + jmper.Arr[5]+ "                        " + max + "                " + min + "\n";

			if ((J31.Text == "") | (J32.Text == "") | (J33.Text == "") | (J34.Text == "") | (J35.Text == "") | (J36.Text == ""))
				goto E;


			max = 0;
			min = 20000;


												jmper.SetName(Convert.ToString(Name3.Text));
												jmper.Arr[0] = Convert.ToDouble(J31.Text); //прыгун 3
												jmper.Arr[1] = Convert.ToInt32(J32.Text);
												jmper.Arr[2] = Convert.ToInt32(J33.Text);
												jmper.Arr[3] = Convert.ToInt32(J34.Text);
												jmper.Arr[4] = Convert.ToInt32(J35.Text);
												jmper.Arr[5] = Convert.ToInt32(J36.Text);

												for (int i = 0; i < jmper.Arr.Length; i++)
												{

												if ((jmper.Arr[i] < 3) | (jmper.Arr[i] > 9.5))
													jmper.Arr[i] = 0;

												if ((jmper.Arr[i] < min) & (jmper.Arr[i] != 0))
													min = jmper.Arr[i];
													if ((jmper.Arr[i] > max) & (jmper.Arr[i] != 0))
														max = jmper.Arr[i];
												}

												LName.Content += "      " + jmper.GetName() + "\n";
												LRes.Content += "   " + jmper.Arr[0] + "                " + jmper.Arr[1] + "                  " + jmper.Arr[2] + "                 " + jmper.Arr[3] + "                   " + jmper.Arr[4] + "                  " + jmper.Arr[5] + "                        " + max + "                " + min + "\n";


			if ((J41.Text == "") | (J42.Text == "") | (J43.Text == "") | (J44.Text == "") | (J45.Text == "") | (J46.Text == ""))
				goto E;


			max = 0;
			min = 20000;



												jmper.SetName(Convert.ToString(Name4.Text));
												jmper.Arr[0] = Convert.ToInt32(J41.Text); //прыгун 4
												jmper.Arr[1] = Convert.ToInt32(J42.Text);
												jmper.Arr[2] = Convert.ToInt32(J43.Text);
												jmper.Arr[3] = Convert.ToInt32(J44.Text);
												jmper.Arr[4] = Convert.ToInt32(J45.Text);
												jmper.Arr[5] = Convert.ToInt32(J46.Text);

												for (int i = 0; i < jmper.Arr.Length; i++)
												{

													if ((jmper.Arr[i] < 3) | (jmper.Arr[i] > 9.5))
														jmper.Arr[i] = 0;

													if ((jmper.Arr[i] < min) & (jmper.Arr[i] != 0))
														min = jmper.Arr[i];
													if ((jmper.Arr[i] > max) & (jmper.Arr[i] != 0))
														max = jmper.Arr[i];
												}

												LName.Content += "      " + jmper.GetName() + "\n";
												LRes.Content += "   " + jmper.Arr[0] + "                " + jmper.Arr[1] + "                  " + jmper.Arr[2] + "                 " + jmper.Arr[3] + "                   " + jmper.Arr[4] + "                  " + jmper.Arr[5] + "                        " + max + "                " + min + "\n";

			if ((J51.Text == "") | (J52.Text == "") | (J53.Text == "") | (J54.Text == "") | (J55.Text == "") | (J56.Text == ""))
				goto E;

			max = 0;
			min = 20000;




												jmper.SetName(Convert.ToString(Name5.Text));
												jmper.Arr[0] = Convert.ToInt32(J51.Text); //прыгун 5
												jmper.Arr[1] = Convert.ToInt32(J52.Text);
												jmper.Arr[2] = Convert.ToInt32(J53.Text);
												jmper.Arr[3] = Convert.ToInt32(J54.Text);
												jmper.Arr[4] = Convert.ToInt32(J55.Text);
												jmper.Arr[5] = Convert.ToInt32(J56.Text);

													for (int i = 0; i < jmper.Arr.Length; i++)
													{

														if ((jmper.Arr[i] < 3) | (jmper.Arr[i] > 9.5))
															jmper.Arr[i] = 0;

														if ((jmper.Arr[i] < min) & (jmper.Arr[i] != 0))
															min = jmper.Arr[i];
														if ((jmper.Arr[i] > max) & (jmper.Arr[i] != 0))
															max = jmper.Arr[i];
													}

													LName.Content += "      " + jmper.GetName() + "\n";
													LRes.Content += "   " + jmper.Arr[0] + "                " + jmper.Arr[1] + "                  " + jmper.Arr[2] + "                 " + jmper.Arr[3] + "                   " + jmper.Arr[4] + "                  " + jmper.Arr[5] + "                        " + max + "                " + min + "\n";

			if ((J61.Text == "") | (J62.Text == "") | (J63.Text == "") | (J64.Text == "") | (J65.Text == "") | (J66.Text == ""))
				goto E;


			max = 0;
			min = 20000;

												jmper.SetName(Convert.ToString(Name6.Text));
												jmper.Arr[0] = Convert.ToInt32(J61.Text); //прыгун 6
												jmper.Arr[1] = Convert.ToInt32(J62.Text);
												jmper.Arr[2] = Convert.ToInt32(J63.Text);
												jmper.Arr[3] = Convert.ToInt32(J64.Text);
												jmper.Arr[4] = Convert.ToInt32(J65.Text);
												jmper.Arr[5] = Convert.ToInt32(J66.Text);

												for (int i = 0; i < jmper.Arr.Length; i++)
												{

													if ((jmper.Arr[i] < 3) | (jmper.Arr[i] > 9.5))
														jmper.Arr[i] = 0;

													if ((jmper.Arr[i] < min) & (jmper.Arr[i] != 0))
														min = jmper.Arr[i];
													if ((jmper.Arr[i] > max) & (jmper.Arr[i] != 0))
														max = jmper.Arr[i];
												}

												LName.Content += "      " + jmper.GetName() + "\n";
												LRes.Content += "   " + jmper.Arr[0] + "                " + jmper.Arr[1] + "                  " + jmper.Arr[2] + "                 " + jmper.Arr[3] + "                   " + jmper.Arr[4] + "                  " + jmper.Arr[5] + "                        " + max + "                " + min + "\n";

	
	




		E:	Name1.Visibility = Visibility.Hidden;
			Name2.Visibility = Visibility.Hidden;
			Name2.Visibility = Visibility.Hidden;
			Name3.Visibility = Visibility.Hidden;
			Name4.Visibility = Visibility.Hidden;
			Name5.Visibility = Visibility.Hidden;
			Name6.Visibility = Visibility.Hidden;
			Name7.Visibility = Visibility.Hidden;

			J11.Visibility = Visibility.Hidden;
			J12.Visibility = Visibility.Hidden;
			J13.Visibility = Visibility.Hidden;
			J14.Visibility = Visibility.Hidden;
			J15.Visibility = Visibility.Hidden;
			J16.Visibility = Visibility.Hidden;
			J21.Visibility = Visibility.Hidden;
			J22.Visibility = Visibility.Hidden;
			J23.Visibility = Visibility.Hidden;
			J24.Visibility = Visibility.Hidden;
			J25.Visibility = Visibility.Hidden;
			J26.Visibility = Visibility.Hidden;
			J31.Visibility = Visibility.Hidden;
			J32.Visibility = Visibility.Hidden;
			J33.Visibility = Visibility.Hidden;
			J34.Visibility = Visibility.Hidden;
			J35.Visibility = Visibility.Hidden;
			J36.Visibility = Visibility.Hidden;
			J41.Visibility = Visibility.Hidden;
			J42.Visibility = Visibility.Hidden;
			J43.Visibility = Visibility.Hidden;
			J44.Visibility = Visibility.Hidden;
			J45.Visibility = Visibility.Hidden;
			J46.Visibility = Visibility.Hidden;
			J51.Visibility = Visibility.Hidden;
			J52.Visibility = Visibility.Hidden;
			J53.Visibility = Visibility.Hidden;
			J54.Visibility = Visibility.Hidden;
			J55.Visibility = Visibility.Hidden;
			J56.Visibility = Visibility.Hidden;
			J61.Visibility = Visibility.Hidden;
			J62.Visibility = Visibility.Hidden;
			J63.Visibility = Visibility.Hidden;
			J64.Visibility = Visibility.Hidden;
			J65.Visibility = Visibility.Hidden;
			J66.Visibility = Visibility.Hidden;
			J71.Visibility = Visibility.Hidden;
			J72.Visibility = Visibility.Hidden;
			J73.Visibility = Visibility.Hidden;
			J74.Visibility = Visibility.Hidden;
			J75.Visibility = Visibility.Hidden;
			J76.Visibility = Visibility.Hidden;










		}
	}
}
