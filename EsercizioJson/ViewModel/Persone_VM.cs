using EsercizioJson.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;

namespace EsercizioJson.ViewModel
{
    internal class Persone_VM : INotifyPropertyChanged
    {
        private Persone_M Persone_M = new Persone_M();

        private ObservableCollection<Persone_M> _items;

        
        public ObservableCollection<Persone_M> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (_items != value)
                {
                    _items = value;
                }
                OnPropertyChanged(nameof(Items));
            }
        }
        
        public Persone_VM()
        {
            Persone_M = new Persone_M();
            GetJsonData();
        }

        private void GetJsonData()
        {
            string json = System.IO.File.ReadAllText(@"C:\Users\jhoxha\OneDrive - ALTEN Group\Documents\GitHub\Esercizi\Esercizi\EsercizioJson\Prova.json");
            Items = JsonConvert.DeserializeObject<ObservableCollection<Persone_M>>(json);
        }

        private Persone_M selectedperson;
        public Persone_M SelectedPerson
        {
            get { return selectedperson; }
            set
            {
                if (selectedperson != value)
                {
                    selectedperson = value;
                    OnPropertyChanged(nameof(SelectedPerson));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
