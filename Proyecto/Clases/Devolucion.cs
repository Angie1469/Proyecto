using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Devolucion

    {
        public string id;
        public int Cantidad;
        public string MotivoDevolucion;
        public string Idcliente;

        //Metodo constructor de devoluciones
        public Devolucion()
        {
            this.id = "";
            this.Cantidad = 0;
            this.MotivoDevolucion = "";
            this.Idcliente = "";
        }
    }
}
