using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
        public int Get(int idx)
        {
            Vagon tmp = Primero;
            int indice =0;
            while (tmp != null)
            {
                if (indice == idx)
                {
                    return tmp.Dato;
                }
                indice++;
                tmp = tmp.Sig;
            }
            return int.MinValue;
        }
        public int Length()
        {
            Vagon tmp = Primero;
            int contar = 0;
            while (tmp != null)
            {
                contar++;
                tmp = tmp.Sig;
            }
            return contar;
        }
        public void MerclaAlFinal(Locomotora ListFin)
        {
            int cant = ListFin.Length();
            for (int i = 0; i <= cant; i++) 
            {
                this.AgregaFin(ListFin.Get(i));
            }
            
        }
        public void MerclaAlFinal2(Locomotora ListFin)
        {
            Vagon PriVagB = ListFin.Primero;
            Vagon tmp = Primero;
            if (this.Primero == null) 
            {
                this.Primero = PriVagB;
            }
            else
            {
                Vagon Tmp = Primero;
                while(tmp.Sig != null)
                {
                    Tmp = Tmp.Sig;
                }
                tmp.Sig = PriVagB;
            }
           
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
