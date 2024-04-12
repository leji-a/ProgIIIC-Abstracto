using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioEmpleadoAbstracto
{
    abstract internal class Empleado
    {
        private string ciudad;
        private string nombre;
        private string puesto;
        public string Ciudad
        {
            get { return ciudad; } set { ciudad = value; }
        }
        public string Nombre
        {
            get { return nombre; } set { nombre = value; }
        }
        public string Puesto
        {
            get { return puesto; } set { puesto = value; }
        }

        public Empleado(string pCiudad, string pNombre, string pPuesto)
        {
            Ciudad = pCiudad;
            Nombre = pNombre;
            Puesto = pPuesto;
        }

        abstract public double SalarioDiario();
    }
}
