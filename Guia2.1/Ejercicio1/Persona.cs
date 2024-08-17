using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Persona
    { 
    
        public string Dni { get; set; }
        public string Nombre { get; private set; }

        public Persona(string dni, string nombre)
        {
            Nombre = nombre;
            Dni = dni;
        }



        

    }
}
