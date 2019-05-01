using EjercicioPelota.Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPelota.Interfaces
{
    public interface IBuscar
    {
        void BuscarPelota(int id);
        Pelota ObtenerDatosdePelota(int id);
        List<Pelota> ObtenerDatosPelota();
        List<Pelota> ObtenerDatosPelota(string modelo);
    }
}
