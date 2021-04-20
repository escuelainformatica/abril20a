using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    // Value Object (VO), DTO (Data transfer Object).
    class AutoExtendido : Auto
    {
        public int Precio {set; get;}

        public AutoExtendido()
        {
        }

        public AutoExtendido(string nombre,string modelo,int anyo, int precio)
        {
            Nombre = nombre;
            Modelo = modelo;
            Anyo = anyo;
            Precio = precio;
        }
    }
}
