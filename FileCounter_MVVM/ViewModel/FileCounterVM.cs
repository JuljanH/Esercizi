using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;
using FileCounter_MVVM.Model;
using static FileCounter_MVVM.Model.IFileCounter_M;

namespace FileCounter_MVVM.ViewModel
{
    public class FileCounterVM : INotifyPropertyChanged
    {
        private IFilterCounter_M model;
        public FileCounterVM()
        {

            model = new FileCounter_M();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string variablename)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(variablename));
        }


        public string FolderPath
        {
            get { return model.PathString; }
            set
            {
                if (value != model.PathString)
                    model.PathString = value;
                OnPropertyChanged(nameof(FolderPath));
                OnPropertyChanged(nameof(Count));
            }
        }

        public int Count
        {
            get { return model.Count; }

        }

    }
}
