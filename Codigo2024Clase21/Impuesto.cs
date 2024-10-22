using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo2024Clase21
{
    public class Impuesto : IImpuesto
    {
        public double Calcular4taCategoria(int monto)
        {
            return monto * 0.08;
        }

        public double Calcular5taCategoria(int monto)
        {
            return monto * 0.10;
        }
    }
}
