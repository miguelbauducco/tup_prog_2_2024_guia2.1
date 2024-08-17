using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        DepartamentoVehicular departamento = new DepartamentoVehicular();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DatosPersona datospersona   = new DatosPersona();
            Persona persona = new Persona(datospersona.textBox1.Text,datospersona.textBox2.Text);
            RegistroVehiculo registroVehiculo = departamento.RegistrarVeh(persona);
            datospersona.ShowDialog();

            lb1.Items.Add($"{RegistroVehiculo.Serie}{persona.Nombre}(DNI {persona.Dni})");
            lb2.Items.Add($"{persona.Nombre}(DNI {persona.Dni})");

            //datospersona.btnGuardar;

        }

        private void btnListarRegistros_Click(object sender, EventArgs e)
        {

        }
    }
}
