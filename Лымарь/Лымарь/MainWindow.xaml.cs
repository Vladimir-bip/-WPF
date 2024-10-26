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

namespace Лымарь
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Menu_123.Background = new SolidColorBrush(Colors.Blue);
            Menu_1.Background = new SolidColorBrush(Colors.Blue);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Автор: Владимир Лымарь", "Авторы", 0 , MessageBoxImage.Information);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mi_open_MouseEnter(object sender, MouseEventArgs e)
        {
            rr1.Text = "Изменить цвет";
        }

        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            rr1.Text = "Авторы";
        }

        private void MenuItem_MouseEnter_1(object sender, MouseEventArgs e)
        {
            rr1.Text = "Закрыть меню";
        }
    }
}
