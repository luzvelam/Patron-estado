using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{
    // Clase Contexto (Context) del patrón Estado
    // Esta clase representa la máquina expendedora
    // y mantiene el estado actual junto con sus datos
    public class Contexto
    {
        public IEstado Estado { get; set; }
        public int Dinero { get; set; }
        public string Producto { get; set; }
        public string Mensaje { get; set; }

        public Contexto()
        {
            Estado = new EstadoEsperandoDinero();
            Dinero = 0;
            Producto = "";
            Mensaje = "Esperando dinero";
        }
    }

}
