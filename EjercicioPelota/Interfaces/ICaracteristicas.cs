using EjercicioPelota.Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPelota.Interfaces
{
    public interface ICaracteristicas
    {
        void AgregarRamadelDeporte(Pelota pelotas);
        void AgregarTipodeBalon(int Serie);
        void AgregarTiempodeUtilidadBalon(string Tamaño);

        void EliminarRamadelDeporte(Pelota pelotas);
        void EliminarTipodeBalon(int Serie);
        void EliminarTiempodeUtilidadBalon(string Tamaño);

    }
}
