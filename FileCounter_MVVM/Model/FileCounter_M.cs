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
            get { return _pathstring; } set
            {
                _pathstring = value;
                _count = Directory.GetFiles(_pathstring, "*", SearchOption.AllDirectories).Length; ;

            } }

        public int Count
        {
            get
            {
                return _count; 
            }

        }



    }
}
