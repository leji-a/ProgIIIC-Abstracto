using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioEmpleadoAbstracto
{
    internal class Mostrador : Empleado
    {
        private double ventas;

        public double Ventas
        {
            get { return ventas; } set { ventas = value; }
        }

        public Mostrador(string pCiudad, string pNombre, string pPuesto, double pVentas) : base(pCiudad, pNombre, pPuesto)
        {
            Ventas = pVentas;
        }
        public override double SalarioDiario()
        {
            return 50 + (Ventas * 0.15);
        }
    }
}
