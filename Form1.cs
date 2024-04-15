using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private bool Texto(string texto)
        { 
            if (string.IsNullOrEmpty(texto))
            {
                return false;
            }
            return texto.All(Char.IsLetter);
        }

        private bool Numero(string n)
        {
            if (string.IsNullOrEmpty(n))
            {
                return false;
            }
            return n.All(Char.IsDigit);
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            string tCiudad = txtCiudad.Text.Trim();
            string tNombre = txtNombre.Text.Trim();

            if (Texto(tCiudad) && Texto(tNombre))
            {
                Limpieza limpieza1 = new Limpieza(tCiudad, tNombre, "Limpieza");
                lblLimpieza.Text = "Nombre: " + limpieza1.Nombre +
                    "\nCiudad: " + limpieza1.Ciudad +
                    "\nPuesto: " + limpieza1.Puesto +
                    "\nSalario: " + limpieza1.SalarioDiario();
            }
            else
            {
                MessageBox.Show("Ingrese la ciudad y el nombre, no se admiten numeros.");
            }
        }

        private void btnCajero_Click(object sender, EventArgs e)
        {
            string tHoras = txtHorasTrabajadas.Text.Trim();
            string tCiudad = txtCiudad.Text.Trim();
            string tNombre = txtNombre.Text.Trim();

            if(Numero(tHoras))
            {
                if (Texto(tCiudad) && Texto(tNombre))
                {
                    Cajero cajero1 = new Cajero(tCiudad, tNombre, "Cajero", Convert.ToInt32(tHoras));
                    lblCajero.Text = "Nombre: " + cajero1.Nombre +
                    "\nCiudad: " + cajero1.Ciudad +
                    "\nPuesto: " + cajero1.Puesto +
                    "\nSalario: " + cajero1.SalarioDiario();
                }
                else { MessageBox.Show("Ingrese la ciudad y el nombre, no se admiten numeros."); }
            }
            else { MessageBox.Show("Ingrese las horas trabajadas, no se admiten palabras."); }
        }

        private void btnMostrador_Click(object sender, EventArgs e)
        {
            string tHoras = txtHorasTrabajadas.Text.Trim();
            string tCiudad = txtCiudad.Text.Trim();
            string tNombre = txtNombre.Text.Trim();
            string tVentas = txtVentas.Text.Trim();

            if (Numero(tVentas) && Numero(tHoras))
            {
                if (Texto(tCiudad) && Texto(tNombre))
                {
                    Mostrador mostrador1 = new Mostrador(tCiudad, tNombre, "Mostrador", Convert.ToDouble(tVentas));

                    lblMostrador.Text = "Nombre: " + mostrador1.Nombre +
                    "\nCiudad: " + mostrador1.Ciudad +
                    "\nPuesto: " + mostrador1.Puesto +
                    "\nSalario: " + mostrador1.SalarioDiario() +
                    "\nVentas: " + tVentas;
                } else { MessageBox.Show("Ingrese la ciudad y el nombre, no se admiten numeros."); }
            }
            else { MessageBox.Show("Ingrese las horas trabajadas, no se admiten palabras."); }
        }






    }
}
