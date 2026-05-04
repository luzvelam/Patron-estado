using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{
    public class EstadoDespachandoProducto : IEstado
    {
        public void InsertarDinero(Contexto c)
        {
            c.Mensaje = "Espere, procesando compra";
        }

        public void SeleccionarProducto(Contexto c)
        {
            c.Mensaje = "Ya se está procesando";
        }

        public void ConfirmarCompra(Contexto c)
        {
            c.Mensaje = "Entregando producto...";
            c.Estado = new EstadoDevolviendoCambio();
        }

        public void Cancelar(Contexto c)
        {
            c.Mensaje = "No se puede cancelar ahora";
        }
    }
}
