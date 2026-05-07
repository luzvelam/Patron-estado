using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaExpendedora
{
    // Estado donde el usuario ya ha insertado dinero
    public class EstadoDineroInsertado : IEstado
    {
        public void InsertarDinero(Contexto c)
        {
            c.Dinero += 10;
            c.Mensaje = "Dinero acumulado: $" + c.Dinero;
        }

        public void SeleccionarProducto(Contexto c)
        {
            if (c.Producto == "")
            {
                c.Mensaje = "Selecciona un producto";
                return;
            }

            c.Mensaje = "Producto seleccionado: " + c.Producto;
            c.Estado = new EstadoProductoSeleccionado();
        }

        public void ConfirmarCompra(Contexto c)
        {
            c.Mensaje = "Primero selecciona un producto";
        }

        public void Cancelar(Contexto c)
        {
            c.Mensaje = "Compra cancelada. Dinero devuelto: $" + c.Dinero;
            c.Dinero = 0;
            c.Estado = new EstadoEsperandoDinero();
        }
    }
}
