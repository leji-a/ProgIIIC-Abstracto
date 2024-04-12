using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioEmpleadoAbstracto
{
    internal class Cajero : Empleado
    {
        private int horasTrabajadas;

        public int HorasTrabajadas
        {
            get { return horasTrabajadas; } set { horasTrabajadas = value; }
        }
        public Cajero (string pCiudad, string pNombre, string pPuesto, int pHorasTrabajadas) : base (pCiudad, pNombre, pPuesto)
        {
            HorasTrabajadas = pHorasTrabajadas;
        }

        public override double SalarioDiario()
        {
            int valorHora = 15;
            return HorasTrabajadas * valorHora;
        }
    }
}
