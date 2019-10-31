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
                

            if ((TBw.Text == "") | (TBb.Text == "") | (TBr.Text == ""))
            {



                MessageBox.Show("Нет данных!\nВведите числа.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                if (TBw.Text == "")
                    TBw.Background = Brushes.LightPink;
                if (TBb.Text == "")
                    TBb.Background = Brushes.LightPink;
                if (TBr.Text == "")
                    TBr.Background = Brushes.LightPink;

            }


            else
            {
                double worst = Convert.ToDouble(TBw.Text);
                double best = Convert.ToDouble(TBb.Text);
                double record = Convert.ToDouble(TBr.Text);


                if ((worst <= 0) | (best <= 0) | (record <= 0))

                {

                    if (worst <= 0)
                        TBw.Background = Brushes.LightPink;
                    if (best <= 0)
                        TBb.Background = Brushes.LightPink;
                    if (record <= 0)
                        TBr.Background = Brushes.LightPink;

                    MessageBox.Show("Некорректный ввод. Введите положительные числа", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);


                }
            
                    else
                    {
                    if (worst <= best)
                    {
                        if (best > record)
                        {

                            jump.SetWorstjump(Convert.ToDouble(TBw.Text));
                            jump.SetBestjump(Convert.ToDouble(TBb.Text));
                            jump.Record(Convert.ToDouble(TBr.Text));
                            Lavg.Content = "Средний прыжок: " + jump.Average();
                            TBw.Background = Brushes.White;
                            TBb.Background = Brushes.White;
                            TBr.Background = Brushes.White;
                            MessageBox.Show("Рекорд побит!", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
                            Lrec.Content = "";

                        }

                        else
                        {
                            jump.SetWorstjump(Convert.ToDouble(TBw.Text));
                            jump.SetBestjump(Convert.ToDouble(TBb.Text));
                            jump.Record(Convert.ToDouble(TBr.Text));
                            Lavg.Content = "Средний прыжок: " + jump.Average();
                            Lrec.Content = "Не хватило до рекорда: " + jump.Record(Convert.ToDouble(TBr.Text));
                            TBw.Background = Brushes.White;
                            TBb.Background = Brushes.White;
                            TBr.Background = Brushes.White;

                            
                        }
                    }

                    else MessageBox.Show("Значение худшего прыжка не может превышать значение лучшего!", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
             }


            }
        }
    }
