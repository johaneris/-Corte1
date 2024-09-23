using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorteI.models;
using Microsoft.Win32;
using static CorteI.models.RegistroDeEdades;

namespace CorteI
{
   
    public partial class Form1 : Form
    {
        Registro2 registro = new Registro2();
        Operaciones2 operacion = new Operaciones2();
        public Form1()
        {
            InitializeComponent();
            cbCiudad.Items.Add("Managua");
            cbCiudad.Items.Add("Juigalpa");
            cbCiudad.Items.Add("Masaya");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // cree una persona con los dtos q ingresa en el form
                Persona nuevaPersona = new Persona(
                    tbNombres.Text,
                    tbApellidos.Text,
                    dtpfechaNacimiento.Value,
                    cbCiudad.SelectedItem.ToString()
                );

                // se agrega al registrp
                registro.AgregarPersona(nuevaPersona);
                MessageBox.Show("Persona agregada correctamente");

                // pa limpiar
                tbNombres.Clear();
                tbApellidos.Clear();
                cbCiudad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        // Evento para calcular la edad y si es mayor de edad
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la última persona registrada
                Persona ultimaPersona = registro.personas[registro.contador - 1];

                // Calcular la edad y si es mayor de edad
                int edad = operacion.CalcularEdad(ultimaPersona);
                string mayorOMenor = operacion.EsMayorDeEdad(ultimaPersona);

                // Mostrar el resultado
                MessageBox.Show($"Edad: {edad} años\n{mayorOMenor}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
