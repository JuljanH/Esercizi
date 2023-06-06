using System.Windows;
using EsercizioJson.ViewModel;
using EsercizioJson.Model;
using System.Windows.Controls;

namespace EsercizioJson
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.NewSize.Width < 500)
            {
                MyStackPanel.Visibility = Visibility.Collapsed;
            }
            else
            {
                MyStackPanel.Visibility = Visibility.Visible;
            }
        }


    }
}
