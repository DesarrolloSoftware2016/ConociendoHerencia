using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConociendoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Herencia básica *****");
            
            // Crear un objeto de tipo Vehiculo y darle una velocidad máxima
            Vehiculo miVehiculo = new Vehiculo(180);
            // Establecer la velocidad actual e imprimirla
            miVehiculo.Velocidad = 1000;
            Console.WriteLine("Mi vehículo va a una velocidad de {0} KPH", miVehiculo.Velocidad);

            // Crear un objeto de tipo Pickup
            Pickup pailita = new Pickup();
            pailita.Velocidad = 40;
            Console.WriteLine("La pailita va a {0} KPH", pailita.Velocidad);

            // Crear un objetp de tipo Pikup 4x4
            Pickup4x4 laPailitaPoderosa = new Pickup4x4();
            laPailitaPoderosa.Velocidad = 40;
            laPailitaPoderosa.CapacidadToneladas = 2;
            Console.WriteLine("La pailita poderosa va a {0} KPH y tiene una capacidad en toneladas de {1}", laPailitaPoderosa.Velocidad, laPailitaPoderosa.CapacidadToneladas);

            Console.ReadLine();
        }
    }
}
