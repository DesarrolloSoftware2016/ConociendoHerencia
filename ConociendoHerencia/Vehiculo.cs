using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConociendoHerencia
{
    class Vehiculo
    {
        // Variables miembro
        private int velocidadActual;
        public readonly int velocidadMaxima;

        // Propiedades
        public int Velocidad
        {
            get { return velocidadActual; }
            set
            {
                velocidadActual = value;
                if (velocidadActual > velocidadMaxima)
                    velocidadActual = velocidadMaxima;
            }
        }

        // Constructores
        public Vehiculo() { }

        public Vehiculo(int maximaVelocidad)
        {
            velocidadMaxima = maximaVelocidad;
        }
    }
}
