using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Nomina
    {
        public int DiasLaburados { get; set; }

        //Metodo para Calcular la Nomina
        public decimal CalcularSalario (int diaslab, decimal valordia)
        {
            decimal TotalSalario= diaslab*valordia;
            return TotalSalario;
        }

    }
}
