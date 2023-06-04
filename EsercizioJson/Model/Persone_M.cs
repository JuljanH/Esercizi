using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioJson.Model
{
    internal class Persone_M : INotifyPropertyChanged
    {
        private string nome;
        [JsonProperty("Nome")]
        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
                OnPropertyChanged(Nome);
            }
        }
        private string cognome;
        [JsonProperty("Cognome")]
        public string Cognome
        {
            get { return cognome; }
            set { cognome = value;
                  OnPropertyChanged(Cognome);
            }
        }
        private string sesso;
        [JsonProperty("Sesso")]
        public string Sesso
        {
            get { return sesso; }
            set { sesso = value;
                  OnPropertyChanged(Sesso);
            }
        }
        private string età;
        [JsonProperty("Età")]
        public string Età
        {
            get { return età; }
            set { età = value;
                  OnPropertyChanged(Età);
            }
        }


        private string telefono;
        [JsonProperty("Telefono")]
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value;
                OnPropertyChanged(Telefono);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
