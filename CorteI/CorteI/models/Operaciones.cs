using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteI.models
{
    internal class Operaciones
    {
        // metodo
        public int CalcularEdad(Persona persona)
        {
            int edad = DateTime.Now.Year - persona.FechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < persona.FechaNacimiento.DayOfYear)
            {
                edad--; // Si no ha cumplido años, resta 1
            }
            return edad;
        }

        // metodo
        public string EsMayorDeEdad(Persona persona)
        {
            int edad = CalcularEdad(persona);
            if (edad >= 18)
            {
                return "Mayor de edad";
            }
            else
            {
                return "Menor de edad";
            }
        }
    }
}
