using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Contatore.Model.IContatore_M;

namespace Contatore.Model
{
    internal class ModelContatore : IContatore_M1
    {
        private string _path;
        private int _contatore;
        private string _bgcolor;

        public string Path
        {
            get { return _path; }
            set {
                _path = value; 
                _contatore = Directory.GetFiles(_path, "*",SearchOption.AllDirectories).Length; 
            }
        }

        public string bgColor
        {
            get { return _bgcolor; }
            set
            {
                _bgcolor = value;
            }
        }
        public int Conteggio
        {
            get { return _contatore; }
        }
    }
}
