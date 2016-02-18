using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConociendoHerencia
{
    class Pickup : Vehiculo
    {
        // Variables miembro
        private int capacidadToneladas;

        // Propiedades
        public int CapacidadToneladas
        {
            get { return capacidadToneladas; }
            set { capacidadToneladas = value; }
        }
    }
}
