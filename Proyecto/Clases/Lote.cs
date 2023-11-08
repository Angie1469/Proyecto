using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Lote
    {
        public string id;
        public int cantidad;
        public DateTime fechaIngreso;
        public string fechaVencimiento;
        public string id_medicamento;
        public string id_proveedor;

        //Metodo constructor de lote
        public Lote()
        {
            this.id = "";
            this.cantidad = 0;
            this.fechaIngreso = DateTime.Now;
            this.fechaVencimiento = "";
            this.id_medicamento = "";
            this.id_proveedor = "";
        }
    }
}
