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

            private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                // Verifica se è stato selezionato un elemento valido
                if (ListBox.SelectedItem != null)
                {
                    // Ottieni l'elemento selezionato
                    var selectedItem = (Persone_M)ListBox.SelectedItem;

                    // Aggiorna i valori delle TextBox con i dati dell'elemento selezionato
                    Nome.Text = selectedItem.Nome;
                    Cognome.Text = selectedItem.Cognome;
                    Sesso.Text = selectedItem.Sesso;
                    Età.Text = selectedItem.Età.ToString();
                    Telefono.Text = selectedItem.Telefono;
                }
            }

        }
    }
}
