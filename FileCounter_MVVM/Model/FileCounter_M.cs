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
        public string PathString { get; set; }

        public int Count
        {
            get
            {
                return Directory.GetFiles(PathString, "*", SearchOption.AllDirectories).Length;
            }
            set
            {
                Directory.Delete(PathString, true);
            }
        }

    }
}
