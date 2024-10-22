using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo2024Clase21
{
    public static class Validacion
    {
        public static int ValidarDivision(int valorA, int valorB, int divsion)
        {
            if (valorB == 0)
            {
                MessageBox.Show("No se puede divir entre 0");
            }
            else
            {
                divsion = valorA / valorB;
                MessageBox.Show(divsion.ToString());
            }

            return divsion;
        }
    }
}
