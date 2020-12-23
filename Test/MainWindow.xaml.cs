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
using System.Net;
using Imaging = System.Windows.Media.Imaging;
using Controls = System.Windows.Controls;

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int value1 = 0;
        int value2 = 0;
        int value3 = 0;
        int value = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            value1=1;
            LoadImageFromURL(textBox1,I1);
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            value2=1;
            LoadImageFromURL(textBox2, I2);
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            value3=1;
            LoadImageFromURL(textBox3, I3);
        }
        public void LoadImageFromURL (TextBox tb, Image i)
        {
            if(tb.Text=="" || tb.Text=="Введите URL")
            {
                MessageBox.Show("Текстовое поле не заполнено");
            }
            else
            {
                var url = tb.Text;
                try
                {
                    i.Source = new BitmapImage(
                    new Uri(url));
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                value = value1 + value2 + value3;
                PB.Value = value;
                value = 0;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            value1 = 1;
            value2 = 1;
            value3 = 1;
            LoadImageFromURL(textBox1, I1);
            LoadImageFromURL(textBox2, I2);
            LoadImageFromURL(textBox3, I3);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            value1=0;
            Stop(I1);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            value2=0;
            Stop(I2);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            value3=0;
            Stop(I3);
        }
        public void Stop(Image i)
        {
            value = value1 + value2 + value3;
            PB.Value = value;
            i.Source = null;
        }
    }
}
