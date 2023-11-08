using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.OracleClient;

namespace Proyecto
{
    public class Medicamento
    {
        public string id;
        public string nombreGenerico;
        public string descripcion;
        public int precio;
        public String NombreComercial;

        //Metodo constructor de medicamento
        public Medicamento()
        {
            this.id = "";
            this.nombreGenerico = "";
            this.descripcion = "";
            this.precio = 0;
            NombreComercial = "";
        }
    }
}
