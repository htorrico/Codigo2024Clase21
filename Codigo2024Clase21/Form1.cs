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

            int ValorA = 0;
            int ValorB = 0;
            int Suma = 0;

            ValorA = Convert.ToInt32(txtValorA.Text);
            ValorB = Convert.ToInt32(txtValorB.Text);

            Suma = ValorA + ValorB;

            
            MessageBox.Show(Suma.ToString());
        }
    }
}
