using EjercicioPelota.Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPelota.Interfaces
{
    public interface IOperaciones
    {
        void AgregarCaracteristicas(Pelota pelotas);

        void AgregarCaracteristicas(int Serie);

        void EliminarCaracteristicas(Pelota pelotas);

        void EliminarCaracteristicas(int Serie, string modelo);

    }
}
