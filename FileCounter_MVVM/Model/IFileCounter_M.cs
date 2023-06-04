using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCounter_MVVM.Model
{
    public class IFileCounter_M
    {
        public interface IFilterCounter_M
        {
            string PathString { get; set; }
            int Count { get; }

            //string BgColor { get; set; }

        }
    }
}
