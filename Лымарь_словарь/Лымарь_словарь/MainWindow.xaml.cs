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

namespace Лымарь_словарь
{    /// <summary>
     /// Логика взаимодействия для MainWindow.xaml
     /// </summary>


    public partial class MainWindow : Window
    {
        private Dictionary<string, long> phoneBook;

        public MainWindow()
        {
            InitializeComponent();
            phoneBook = new Dictionary<string, long>()
            {
                {"Alisa", 89965214589},
                {"Gulsibar", 88005553535},
                {"Petr", 89961015660},
                {"Igor", 89654085695},
                {"Anastasiya", 89451652954},
                {"Tagir", 89459584859},
                {"Ekatya", 89541065974}
            };
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string key = KeyInput.Text;

            if (phoneBook.TryGetValue(key, out long value))
            {
                ResultTextBlock.Text = $"Телефон для {key}: {value}";
            }
            else
            {
                ResultTextBlock.Text = $"'{key}' не найден.";
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            string key = KeyInput.Text;

            if (phoneBook.Remove(key))
            {
                ResultTextBlock.Text = $"'{key}' удалён.";
            }
            else
            {
                ResultTextBlock.Text = $"'{key}' не найден для удаления.";
            }

            DisplayRemainingElements();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            phoneBook.Clear();
            ResultTextBlock.Text = "Все элементы удалены.";
        }

        private void DisplayRemainingElements()
        {
            ResultTextBlock.Text += "Оставшиеся элементы";
            foreach (var entry in phoneBook)
            {
                ResultTextBlock.Text += $"{entry.Key}: {entry.Value}";
            }
        }
    }
}

