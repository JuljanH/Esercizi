using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace FileCounter_MVVM.ViewModel
{
    public class FileCounterVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string FolderPath)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(FolderPath));
        }
    }
}
