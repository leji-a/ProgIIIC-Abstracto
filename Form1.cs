using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioEmpleadoAbstracto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Limpieza limpieza = new Limpieza("San Francisco", "Lucas", "Limpieza");
            Cajero cajero = new Cajero("Devoto", "Santiago", "Cajero", 8);
            Mostrador mostrador = new Mostrador("Freyre", "Fernando", "Mostrador", 250000);

            lblLimpieza.Text = "Nombre: " + limpieza.Nombre + 
                "\nCiudad: " + limpieza.Ciudad + 
                "\nPuesto: " + limpieza.Puesto + 
                "\nSalario: " + limpieza.SalarioDiario();
            lblCajero.Text = "Nombre: " + cajero.Nombre +
                "\nCiudad: " + cajero.Ciudad +
                "\nPuesto: " + cajero.Puesto +
                "\nSalario: " + cajero.SalarioDiario();
            lblMostrador.Text = "Nombre: " + mostrador.Nombre +
                "\nCiudad: " + mostrador.Ciudad +
                "\nPuesto: " + mostrador.Puesto +
                "\nSalario: " + mostrador.SalarioDiario();
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            Limpieza limpieza1 = new Limpieza(txtCiudad.Text.Trim(), txtNombre.Text.Trim(), "Limpieza");
            lblLimpieza.Text = "Nombre: " + limpieza1.Nombre +
                "\nCiudad: " + limpieza1.Ciudad +
                "\nPuesto: " + limpieza1.Puesto +
                "\nSalario: " + limpieza1.SalarioDiario();
        }

        private void btnCajero_Click(object sender, EventArgs e)
        {
            Cajero cajero1 = new Cajero(txtCiudad.Text.Trim(), txtNombre.Text.Trim(), "Cajero", Convert.ToInt32(txtHorasTrabajadas.Text.Trim()));
            lblCajero.Text = "Nombre: " + cajero1.Nombre +
                "\nCiudad: " + cajero1.Ciudad +
                "\nPuesto: " + cajero1.Puesto +
                "\nSalario: " + cajero1.SalarioDiario();
        }

        private void btnMostrador_Click(object sender, EventArgs e)
        {
            Mostrador mostrador1 = new Mostrador(txtCiudad.Text.Trim(), txtNombre.Text.Trim(), "Mostrador", Convert.ToInt32(txtHorasTrabajadas.Text.Trim()));
            lblMostrador.Text = "Nombre: " + mostrador1.Nombre +
                "\nCiudad: " + mostrador1.Ciudad +
                "\nPuesto: " + mostrador1.Puesto +
                "\nSalario: " + mostrador1.SalarioDiario();
        }
    }
}
