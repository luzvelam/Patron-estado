using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{

    // Clase principal que representa el CONTEXTO del patrón Estado
    public class Contexto
    {
        // Aquí se aplica el patrón Estado, ya que el contexto mantiene una referencia
        // al estado actual mediante la interfaz IEstado, permitiendo cambiar el
        // comportamiento de la máquina dinámicamente.
        // Estado actual de la máquina (puede cambiar dinámicamente)
        public IEstado Estado { get; set; }
        public int Dinero { get; set; }
        public string Producto { get; set; }
        public string Mensaje { get; set; }

        // Constructor: inicializa el estado y valores por defecto
        public Contexto()
        {
            // Estado inicial: esperando que el usuario inserte dinero
            Estado = new EstadoEsperandoDinero();
            Dinero = 0;
            Producto = "";
            Mensaje = "Esperando dinero";
        }
    }

}
