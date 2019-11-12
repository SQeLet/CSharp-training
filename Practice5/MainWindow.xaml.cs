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

namespace Praktika
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
            int allSquare = Convert.ToInt32(TBSquare.Text);
            Random r = new Random();
            LRooms.Content = "№\tДлина\tШирина\t\tПлощадь\n";
            LRooms.Content += "______________________________________________________________________________________________________\n";
            int roomNumber = 0;
            int sumSquare = 0;

            while (sumSquare < allSquare)
            {
                room.SetLength(r.Next(2, 10));
                room.SetWidth(r.Next(2, 10));
                sumSquare += room.Square();
                roomNumber++;
                LRooms.Content += roomNumber + "\t" +
                    room.GetLength() + "\t" +
                    room.GetWidth() + "\t\t" +
                    room.Square() + "\n";


            }
            LRooms.Content += "______________________________________________________________________________________________________\n";
            LRooms.Content += "Общая площадь:   " + sumSquare + "\n";
            LRooms.Content += "Среднее:   " + Math.Round(sumSquare / (double)roomNumber,2);

        }
    }
}
