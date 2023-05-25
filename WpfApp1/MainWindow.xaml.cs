using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using lib_fileCounter;


namespace WpfApp1 
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() 
        {
            InitializeComponent();
            DataContext = this;
        }

        private void btn_invio_Click(object sender, RoutedEventArgs e)
        {
            FileCounter fc = new FileCounter();
            fc.PathString = folderPathTextBox.Text;
            try
            {
                
                countfiles.Text = "Numero di file nella cartella: " + fc.Count;
            }
            catch (DirectoryNotFoundException)
            {
                countfiles.Text = "La cartella non è stata trovata! ";
            }
            catch (Exception ex)
            {
                countfiles.Text = "Si è verificato un errore!";
            }
        }
    }
}
