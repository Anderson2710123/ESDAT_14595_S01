using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaenlazada{
    internal class Locomotora{
        private Vagon Primero {  get; set; }
        
        public void AgregaIni(int valor) {
            //agregar un dato al inicio
            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null) {
                this.Primero = nuevo;
            } else {
                Vagon prim = this.Primero;
                nuevo.Sig = prim;
                this.Primero = nuevo;
            }
        }

        public void AgregaFin(int valor) {
            //agregar un dato al inicio
            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null) {
                this.Primero = nuevo;
            }else if (this.Primero.Sig == null) {
                this.Primero.Sig = nuevo;
            } else {
                Vagon ultimo = Primero;
                while (ultimo.Sig != null) {
                    ultimo = ultimo.Sig;
                }
                ultimo.Sig = nuevo;
            }
        }

        public void EliminaSegundo() {
            //1)sin vagones o 1 vagon no hacer nada
            if (this.Primero != null) {
                if (this.Primero.Sig != null) {
                    //2)el sig del 2do lo conecto al primero
                    Vagon segundo = this.Primero.Sig;
                    Vagon tercero = segundo.Sig;
                    this.Primero.Sig = tercero;
                    //3) sig del 2do = null
                    segundo.Sig = null;
                }
            }
        }

        public bool BuscaValor(int valorBuscar) {
            Vagon tmp = Primero;
            while (tmp != null) {
                if (tmp.Dato == valorBuscar) {
                    return true;
                }
                tmp = tmp.Sig;
            }
            return false;
        }

        public void Imprime(){
            Vagon tmp = Primero;
            while (tmp != null){
                Console.WriteLine($"{tmp.Dato}, ");
                tmp = tmp.Sig;
            }
            
        }
    }
}
