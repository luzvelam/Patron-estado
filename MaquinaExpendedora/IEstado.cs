using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{
    // Interfaz que define las acciones que puede realizar la máquina
    // Todos los estados deben implementar estos métodos
    public interface IEstado
    {
        // Acción para insertar dinero en la máquina
        void InsertarDinero(Contexto c);
        // Acción para seleccionar un producto
        void SeleccionarProducto(Contexto c);
        // Acción para confirmar la compra
        void ConfirmarCompra(Contexto c);
        // Acción para cancelar la operación
        void Cancelar(Contexto c);
    }
}
