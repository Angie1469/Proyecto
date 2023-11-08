using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class ItemFactura
    {
        public int cantidad;
        public string idlote;

        //Se genro una lsita para almacenar en el factura los datos de cantidad y id lote
        public ItemFactura( int CantidadMedicamento, string IdentificadorLote )
        {
            this.cantidad = CantidadMedicamento;
            this.idlote = IdentificadorLote;
        }
    }

}
