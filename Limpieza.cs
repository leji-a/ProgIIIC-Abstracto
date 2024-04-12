using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioEmpleadoAbstracto
{
    internal class Limpieza : Empleado
    {
        public Limpieza(string pCiudad, string pNombre, string pPuesto) : base(pCiudad, pNombre, pPuesto)
        {

        }
        public override double SalarioDiario()
        {
            return 35;
        }
    }
}
