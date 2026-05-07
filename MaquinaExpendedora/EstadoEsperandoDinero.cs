using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaExpendedora
{
    public class EstadoEsperandoDinero : IEstado
    {
        public void InsertarDinero(Contexto c)
        {
            c.Dinero += 10;
            c.Mensaje = "Dinero insertado";
            c.Estado = new EstadoDineroInsertado();
        }

        public void SeleccionarProducto(Contexto c)
        {
            c.Mensaje = "Primero inserta dinero";
        }

        public void ConfirmarCompra(Contexto c)
        {
            c.Mensaje = "No hay dinero";
        }

        public void Cancelar(Contexto c)
        {
            c.Mensaje = "";
        }
    }

}
