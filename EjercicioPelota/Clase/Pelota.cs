using EjercicioPelota.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPelota.Clase
{
    public class Pelota : ICaracteristicas
    {
        public int Serie { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string Tamaño { get; set; }

        public void AgregarRamadelDeporte(Pelota pelotas)
        {
            throw new NotImplementedException();
        }

        public void AgregarTiempodeUtilidadBalon(string Tamaño)
        {
            throw new NotImplementedException();
        }

        public void AgregarTipodeBalon(int Serie)
        {
            throw new NotImplementedException();
        }

        public void EliminarRamadelDeporte(Pelota pelotas)
        {
            throw new NotImplementedException();
        }

        public void EliminarTiempodeUtilidadBalon(string Tamaño)
        {
            throw new NotImplementedException();
        }

        public void EliminarTipodeBalon(int Serie)
        {
            throw new NotImplementedException();
        }
    }
}
