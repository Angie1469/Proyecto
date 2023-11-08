using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;
using Proyecto;

namespace Proyecto
{
    public class Datos1
    {
        //añadir los pedidos creados por el cliente
        public void registrarFacturaPedido(Factura pedido, string DireccionEntrega)
        {
            string Id_Factura = " ";
            string ID_comprobar = Properties.Settings.Default.Id_cliente;

            string connectionString = "DATA SOURCE=xe; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                string IngesarDatosPedido = "INSERT INTO FACTURAPEDIDO (numero, fecha_creacion, total_a_pagar, idCliente, direccionEntrega) VALUES (fact_num_pk.nextval, :fecha_creacion, :total_a_pagar, :idCliente, :direccionEntrega)";
                using (OracleCommand Comando = new OracleCommand(IngesarDatosPedido, connection))
                {
                    Comando.Parameters.Add(new OracleParameter(":fecha_creacion", pedido.fechaDeCreacion));
                    Comando.Parameters.Add(new OracleParameter(":total_a_pagar", pedido.totalApagar));
                    Comando.Parameters.Add(new OracleParameter(":idCliente", ID_comprobar ));
                    Comando.Parameters.Add(new OracleParameter(":direccionEntrega", DireccionEntrega));
                    Comando.ExecuteNonQuery();
     
                }

                //Se busca nuemro creado anteriormente con la secuencia para ingresarlo en la tabla de lote_facturapedido
                using (OracleCommand Comando = new OracleCommand("SELECT MAX(TO_NUMBER(NUMERO)) FROM FACTURAPEDIDO ORDER BY NUMERO DESC", connection))
                {
                    OracleDataReader lector = Comando.ExecuteReader();
                    
                    while (lector.Read())
                    {
                        Id_Factura = lector[0].ToString();
                    }

                    lector.Close();
                }

                foreach (ItemFactura row in pedido.ItemsFactura)
                {

                    string IngesarLote_factura = "INSERT INTO LOTE_FACTURAPEDIDO (numerofactura,  idLote, cantidadMedicamento) VALUES (:numeroFactura, :idLote, :cantidadMedicamento)";
                    using (OracleCommand Comando = new OracleCommand(IngesarLote_factura, connection))
                    {
                        Comando.Parameters.Add(new OracleParameter(":numerofactura", Id_Factura));
                        Comando.Parameters.Add(new OracleParameter(":idLote", row.idlote));
                        Comando.Parameters.Add(new OracleParameter(":cantidadMedicamento",row.cantidad));
                        Comando.ExecuteNonQuery();
                        
                    }

                }

                System.Windows.Forms.MessageBox.Show("Pedido generado con exito");
            }
        }

        //Agregar las direcciones añadidas por el cliente
        public void registrarDireccion(Direccion NuevaDireccion)
        {
            string connectionString = "DATA SOURCE=xe; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                string IngesarDatosPedido = "INSERT INTO CLIENTE_DIRECCION (id, idCliente, direccion) VALUES (CLDIR_ID_PK.NEXTVAL, :idCliente, :direccion)";
                using (OracleCommand Comando = new OracleCommand(IngesarDatosPedido, connection))
                {
                    Comando.Parameters.Add(new OracleParameter(":idCliente", NuevaDireccion.id_cliente));
                    Comando.Parameters.Add(new OracleParameter(":direccion", NuevaDireccion.direccion));
                    Comando.ExecuteNonQuery();

                    System.Windows.Forms.MessageBox.Show("Dirrección Añadida con exito");
                }

            }
        }

        //agregar los medicaemntos añadidos por el administrador
        public void IngresarMedicamento(Medicamento NuevoMedicamento)
        {
            string connectionString = "DATA SOURCE=xe; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                string Id_Medicamento = " ";

                string IngesarDatosPedido = "INSERT INTO MEDICAMENTO (id, Nombre_Generico, descripcion, precio) VALUES (MED_ID_PK.NEXTVAL, :Nombre_Generico, :descripcion, :precio)";
                using (OracleCommand Comando = new OracleCommand(IngesarDatosPedido, connection))
                {
                    Comando.Parameters.Add(new OracleParameter(":Nombre_Generico", NuevoMedicamento.nombreGenerico));
                    Comando.Parameters.Add(new OracleParameter(":descripcion", NuevoMedicamento.descripcion));
                    Comando.Parameters.Add(new OracleParameter(":precio", NuevoMedicamento.precio));

                    Comando.ExecuteNonQuery();

                }

                using (OracleCommand Comando = new OracleCommand("SELECT MAX(TO_NUMBER(ID)) FROM MEDICAMENTO", connection))
                {
                    OracleDataReader lector = Comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Id_Medicamento = lector[0].ToString();
                    }

                    lector.Close();
                }


                string IngesarLote_factura = "INSERT INTO NOMBRECOMERCIAL (Id, nombre, idMedicamento) VALUES (NOM_ID_PK.NEXTVAL, :nombre, :idMedicamento)";
                using (OracleCommand Comando = new OracleCommand(IngesarLote_factura, connection))
                {
                    Comando.Parameters.Add(new OracleParameter(":nombre", NuevoMedicamento.NombreComercial));
                    Comando.Parameters.Add(new OracleParameter(":idMedicamento", Id_Medicamento));
                    Comando.ExecuteNonQuery();

                }

                System.Windows.Forms.MessageBox.Show("Medicamento Registrado con exito");
            }

        }


        //Registrar datos de lotes nuevos
        public void IngresarLote(Lote pLote)
        {
            string connectionString = "DATA SOURCE=xe; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {

                connection.Open();

                string IngesarDatosPedido = "INSERT INTO LOTE (id, fecha_ingreso, cantidad, fecha_vencimiento, id_medicamento, id_proveedor) VALUES (LOT_ID_PK.NEXTVAL, :fecha_ingreso, :cantidad, :fecha_vencimiento, :id_medicamento, :id_proveedor)";
                using (OracleCommand Comando = new OracleCommand(IngesarDatosPedido, connection))
                {
                    Comando.Parameters.Add(new OracleParameter(":fecha_ingreso", pLote.fechaIngreso));
                    Comando.Parameters.Add(new OracleParameter(":cantidad", pLote.cantidad));
                    Comando.Parameters.Add(new OracleParameter(":fecha_vencimiento", pLote.fechaVencimiento));
                    Comando.Parameters.Add(new OracleParameter(":id_medicamento", pLote.id_medicamento));
                    Comando.Parameters.Add(new OracleParameter(":id_proveedor", pLote.id_proveedor));
                    Comando.ExecuteNonQuery();

                }

                System.Windows.Forms.MessageBox.Show("Lote Registrado con exito");
            }
        }
    }

    
}
