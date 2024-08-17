using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class DepartamentoVehicular
    { 

        public int CantidadRegistros {  get { return registros.Count; } }


        ArrayList registros = new ArrayList();


        public RegistroVehiculo RegistrarVeh(Persona propietario)
        {
            //CAMBIAR
            string patente = "aavv11";
            int serie = 1111;
            RegistroVehiculo nuevoregistro = new RegistroVehiculo(patente, propietario, serie);

            registros.Add(nuevoregistro);

            return nuevoregistro;

        }

        //private string GenerarPatente()
        //{

        //}

        public RegistroVehiculo VerRegistro(int idx)
        {

            if(idx >= 0 && idx < CantidadRegistros)
            {
                return registros[idx] as RegistroVehiculo;
            }

            return null;

        }


    }
}
