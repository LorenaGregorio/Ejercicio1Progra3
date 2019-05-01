using EjercicioPelota.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPelota.Clase
{
    public partial class Procesos : IOperaciones
    {
        public List<Pelota> CargarDatos = new List<Pelota>();
        public void AgregarCaracteristicas(Pelota pelotas)
        {
            CargarDatos.Add(pelotas);
        }

        public void AgregarCaracteristicas(int Serie)
        {
            throw new NotImplementedException();
        }

        public void EliminarCaracteristicas(Pelota pelotas)
        {
            throw new NotImplementedException();
        }

        public void EliminarCaracteristicas(int Serie, string modelo)
        {
            throw new NotImplementedException();
        }
    }
}
