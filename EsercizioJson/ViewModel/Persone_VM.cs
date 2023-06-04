using EsercizioJson.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioJson.ViewModel
{
    internal class Persone_VM:INotifyPropertyChanged
    {
        private Persone_M Persone_M;
        public List<Persone_M> Items { get; set; }

        public Persone_VM()
        {
            Persone_M = new Persone_M();
            GetJsonData();
        }

        private void GetJsonData()
        {
            string json = System.IO.File.ReadAllText(@"C:\Users\jhoxha\OneDrive - ALTEN Group\Documents\Sourcetree_esercitazione\EsercizioJson\Prova.json");
            Items = JsonConvert.DeserializeObject<List<Persone_M>>(json);
        }

        private Persone_M selectedItem;
        public Persone_M SelectedItem
        {
            get { return selectedItem; }
            set
            {
                if (selectedItem != value)
                {
                    selectedItem = value;
                    OnPropertyChanged(nameof(SelectedItem));
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
