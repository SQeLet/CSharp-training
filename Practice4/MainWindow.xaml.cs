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

namespace Lab7
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
        MyRoom room = new MyRoom();
        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            int countCh = Convert.ToInt32(TBc.Text);
            int countAng = Convert.ToInt32(TBa.Text);
            LResult.Content = room.ChildrenDispos(countCh, countAng) + " способов";
            A1.Visibility = Visibility.Hidden;
            A2.Visibility = Visibility.Hidden;
            A3.Visibility = Visibility.Hidden;
            A4.Visibility = Visibility.Hidden;

            switch(countAng)
            {
                case 0:
                    A1.Visibility = Visibility.Visible;
                    A2.Visibility = Visibility.Visible;
                    A3.Visibility = Visibility.Visible;
                    A4.Visibility = Visibility.Visible;
                    
                    break;
                case 1:
                    A2.Visibility = Visibility.Visible;
                    A3.Visibility = Visibility.Visible;
                    A4.Visibility = Visibility.Visible;
                    MessageBox.Show("Никто не поместится", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                    
                case 2:
                    A3.Visibility = Visibility.Visible;
                    A4.Visibility = Visibility.Visible;
                    MessageBox.Show("Есть 2 угла", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 3:
                    A4.Visibility = Visibility.Visible;
                    MessageBox.Show("Свободно 3 угла", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 4:
                    MessageBox.Show("Всё свободно", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;

                default:
                    RoomPlan.Fill = Brushes.Red;
                    Calc.IsEnabled = false;
                    break;

            }




        }
    }
}
