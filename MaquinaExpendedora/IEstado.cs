using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{
    public interface IEstado
    {
        void InsertarDinero(Contexto c);
        void SeleccionarProducto(Contexto c);
        void ConfirmarCompra(Contexto c);
        void Cancelar(Contexto c);
    }
}
