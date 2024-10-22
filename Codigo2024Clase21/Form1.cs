using System.Text;

namespace Codigo2024Clase21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Sumar();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Dividir();

        }

        private void btnSumarDividir_Click(object sender, EventArgs e)
        {
            Sumar();
            Dividir();
        }

        private void Sumar()
        {
            int ValorA = 0;
            int ValorB = 0;
            int Suma = 0;

            ValorA = Convert.ToInt32(txtValorA.Text);
            ValorB = Convert.ToInt32(txtValorB.Text);

            Suma = ValorA + ValorB;


            MessageBox.Show(Suma.ToString());

        }
        private void Dividir()
        {
            int valorA = 0;
            int valorB = 0;
            int divsion = 0;

            valorA = Convert.ToInt32(txtValorA.Text);
            valorB = Convert.ToInt32(txtValorB.Text);

            divsion = Validacion.ValidarDivision(valorA, valorB, divsion);
        }

        private void btnCuarta_Click(object sender, EventArgs e)
        {
            IImpuesto impuesto = new Impuesto();
            impuesto.Calcular4taCategoria(5000);
        }

        private void btnTablaMultiplicar_Click(object sender, EventArgs e)
        {

            int valorA = 0;
            valorA = Convert.ToInt32(txtValorA.Text);

            StringBuilder stringBuilder = new StringBuilder();

         
            
            for (int i = 1; i <= 5000; i++)
            {               
                //Cómo hago para colocar un punto de interrupción cuando i=500?
                stringBuilder.Append(txtValorA.Text  + "X" +i + "="+ valorA*i + "\n");
            }

            MessageBox.Show(stringBuilder.ToString());
        }
    }
}
