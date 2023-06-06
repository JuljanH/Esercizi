using Newtonsoft.Json;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace EsercizioJson.Model
{
    internal class Persone_M : INotifyPropertyChanged
    {

        private string nome;
        [JsonPropertyName("nome")]
        [JsonProperty("nome")]
        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
                OnPropertyChanged(nameof(Nome));
            }
        }
        private string cognome;
        [JsonPropertyName("cognome")]
        [JsonProperty("cognome")]
        public string Cognome
        {
            get { return cognome; }
            set { cognome = value;
                  OnPropertyChanged(nameof(Cognome));
            }
        }
        private string sesso;
        [JsonPropertyName("sesso")]
        [JsonProperty("sesso")]
        public string Sesso
        {
            get { return sesso; }
            set { sesso = value;
                  OnPropertyChanged(nameof(Sesso));
            }
        }
        private string età;
        [JsonPropertyName("età")]
        [JsonProperty("età")]
        public string Età
        {
            get { return età; }
            set { età = value;
                  OnPropertyChanged(nameof(Età));
            }
        }


        private string telefono;
        [JsonPropertyName("telefono")]
        [JsonProperty("telefono")]
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value;
                OnPropertyChanged(nameof(Telefono));
            }
        }

        public bool MostraEtà
        {
            get { return Sesso != "Uomo"; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }

    }
}
