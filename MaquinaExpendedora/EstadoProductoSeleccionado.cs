using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{
    public class EstadoProductoSeleccionado : IEstado
    {
        public void InsertarDinero(Contexto c)
        {
            c.Dinero += 10;
            c.Mensaje = "Dinero actualizado: $" + c.Dinero;
        }

        public void SeleccionarProducto(Contexto c)
        {
            c.Mensaje = "Producto ya seleccionado";
        }

        public void ConfirmarCompra(Contexto c)
        {

            c.Estado = new EstadoDevolviendoCambio();
            c.Estado.ConfirmarCompra(c); 
        }

        public void Cancelar(Contexto c)
        {
            c.Mensaje = "Compra cancelada. Dinero devuelto: $" + c.Dinero;
            c.Dinero = 0;
            c.Estado = new EstadoEsperandoDinero();
        }

        private int ObtenerPrecio(string producto)
        {
            switch (producto)
            {
                case "Coca": return 20;
                case "Sabritas": return 30;
                case "Pocky": return 30;
                case "Suavicrema": return 20;
                default: return 20;
            }
        }
    }
}
