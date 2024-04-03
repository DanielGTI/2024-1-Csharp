namespace Aula_1
{
    public partial class frm_Calculadora : Form
    {
        public frm_Calculadora()
        {
            InitializeComponent();
        }

        private void btn_Somar_Click(object sender, EventArgs e)
        {
            double valorA, valorB, soma;

            valorA = Convert.ToDouble(txt_ValorA.Text);
            valorB = Convert.ToDouble(txt_ValorB.Text);

            soma = valorA + valorB;

            txt_Resultado.Text = soma.ToString();
            lbl_Operacao.Text = "+";
        }

        private void btn_Subtrair_Click(object sender, EventArgs e)
        {
            double valorA, valorB, subtrair;

            valorA = Convert.ToDouble(txt_ValorA.Text);
            valorB = Convert.ToDouble(txt_ValorB.Text);

            subtrair = valorA - valorB;

            txt_Resultado.Text = subtrair.ToString();
            lbl_Operacao.Text = "-";
        }
    }
}