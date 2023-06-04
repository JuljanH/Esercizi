using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using static FileCounter_MVVM.Model.IFileCounter_M;

namespace FileCounter_MVVM.Model
{
    public class FileCounter_M : IFilterCounter_M
    {
        private string _pathstring;
        private int _count;
        public string PathString
        {
            get { return _pathstring; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _pathstring = value;
                    _count = Directory.GetFiles(_pathstring, "*", SearchOption.AllDirectories).Length;
                }
            }
        }



        /*public string BgColor
        {
            get { return Directory.Exists(_pathstring) ? "Verde" : "Rosso"; }
            set { }
        }*/

 

        public int Count
        {
            get
            {
                return _count;
            }
        }
    }
}
