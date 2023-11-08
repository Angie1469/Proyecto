using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto;
using System.Data.OracleClient;
using System.Data;
using System.Collections;

namespace Proyecto
{
    public class Factura
    {
        public string numero;
        public DateTime fechaDeCreacion;
        public float totalApagar;
        public string DireccionEntrega;
        public ArrayList ItemsFactura;
  
        //Metodo constructor de facturas
        public Factura()
        {
            this.numero = "";
            this.fechaDeCreacion = DateTime.Now;
            this.totalApagar = 0;
            this.DireccionEntrega = "";
            ItemsFactura = new ArrayList();
        }


    }
}
