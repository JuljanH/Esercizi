using Contatore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Contatore.Model.IContatore_M;

namespace Contatore.ViewModel
{
    internal class ContatoreVM : INotifyPropertyChanged
    {
        private ModelContatore model;
        public ContatoreVM()
        {
            model = new ModelContatore();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string variablename) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(variablename));
        }

        public string Path
        {
            get { return model.Path; }
            set
            {
                OnPropertyChanged(nameof(bgColor));
                OnPropertyChanged(nameof(Path));
                OnPropertyChanged(nameof(Conteggio));
            }
        }

        public string bgColor()
        {
            get { return model.Conteggio; }

        }

        public int Conteggio
        {
            get { return model.Conteggio; }
        }
    }
}
