using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{
    public class EstadoDevolviendoCambio : IEstado
    {
        public void InsertarDinero(Contexto c)
        {
            c.Mensaje = "Espere...";
        }

        public void SeleccionarProducto(Contexto c)
        {
            c.Mensaje = "Espere...";
        }

        public void ConfirmarCompra(Contexto c)
        {
            int precio = 0;

            if (c.Producto == "Coca" || c.Producto == "Suavicrema")
                precio = 20;
            else if (c.Producto == "Sabritas" || c.Producto == "Pocky")
                precio = 30;

            int cambio = c.Dinero - precio;

            if (cambio > 0)
                c.Mensaje = "Producto entregado. Cambio: $" + cambio;
            else
                c.Mensaje = "Producto entregado. Sin cambio";

            c.Dinero = 0;
            c.Producto = "";
            c.Estado = new EstadoEsperandoDinero();
        }

        public void Cancelar(Contexto c)
        {
            c.Mensaje = "Operación finalizada";
        }
    }
}
