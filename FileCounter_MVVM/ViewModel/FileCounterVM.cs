using System;
using System.ComponentModel;
using System.IO;
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
                try
                {
                    if (value != model.PathString)
                        model.PathString = value;
                    //BgColor = "Green";

                    OnPropertyChanged(nameof(FolderPath));
                    OnPropertyChanged(nameof(Count));
                    //OnPropertyChanged(nameof(BgColor));
                }
                catch (DirectoryNotFoundException)
                {
                    
                    model.PathString = string.Empty;  
                    OnPropertyChanged(nameof(FolderPath));
                    OnPropertyChanged(nameof(Count));
                    //BgColor = "Red";  
                }
            }
        }



        public int Count
        {
            get { return model.Count; }
        }

        /*private string _bgColor;  
        public string BgColor
        {
            get { return _bgColor; }
            set
            {
                if (_bgColor != value)
                {
                    _bgColor = value;
                    OnPropertyChanged(nameof(BgColor));
                }
            }
        }*/

    }
}
