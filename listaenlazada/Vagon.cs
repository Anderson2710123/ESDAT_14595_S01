using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaenlazada{
    internal class Vagon{
        public Vagon Sig { get; set; }
        
        public int Dato { get; set; }

        public Vagon(int dato){
            Sig = null;
            Dato = dato;
        }
    }
}
