using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteI.models
{
    internal class RegistroDeEdades
    {
        public class Registro
        {
            public Persona[] personas = new Persona[30]; // Arreglo
            public int contador = 0; //contador para llevar el seguimiento


            // metodo
            public void AgregarPersona(Persona persona)
            {
                if (contador < 30)
                {
                    personas[contador] = persona;
                    contador++;
                }
                else
                {
                    throw new InvalidOperationException("El registro está lleno");
                }
            }

            // metodo
            public string MostrarPersonas()
            {
                string resultado = "";
                for (int i = 0; i < contador; i++)
                {
                    resultado += $"{personas[i].Nombres} {personas[i].Apellidos}, Ciudad: {personas[i].Ciudad}, Fecha de Nacimiento: {personas[i].FechaNacimiento.ToShortDateString()}\n";
                }
                return resultado;
            }
        }
}
