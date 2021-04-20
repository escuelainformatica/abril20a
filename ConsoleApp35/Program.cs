﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> listado=new List<Auto>();

            listado.Add( new Auto {Nombre="306",Modelo="Peugeot", Anyo=2010} );
            listado.Add( new Auto {Nombre="308",Modelo="Peugeot", Anyo=2010} );
            listado.Add( new Auto {Nombre="310",Modelo="Peugeot", Anyo=2010} );
            listado.Add( new Auto {Nombre="f105",Modelo="Mazda", Anyo=2010} );
            listado.Add( new Auto {Nombre="f205",Modelo="Mazda", Anyo=2010} );
            listado.Add( new Auto {Nombre="f305",Modelo="Mazda", Anyo=2010} );

            // linq
            List<string> noDuplicados=listado
                .GroupBy(alias=>alias.Modelo)
                .Select(alias => alias.Key)
                .ToList();

            // extender la lista de autos usando un dto llamado AutoExtendido
            List<AutoExtendido> listadoExtendido=
                    listado.Select( 
                        fila => new AutoExtendido(fila.Nombre,fila.Modelo,fila.Anyo,5000)
                    )
                    .ToList();
            

            // filtras los autos
            var peugeots=listado.Where( alias => alias.Modelo=="Peugeot" ).ToList();

            // agrupar por modelo y obtener la cantidad de vehiculos por agrupacion
            List<ModeloAgrupacion> agrupar =listado
                    .GroupBy( alias => alias.Modelo)
                    .Select( alias=> new ModeloAgrupacion()
                    {
                        Modelo=alias.Key,
                        Cantidad=alias.Count()
                    })
                    .ToList();

        }
    }
}
