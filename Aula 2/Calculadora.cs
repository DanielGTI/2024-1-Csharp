using System.Drawing;

namespace Aula_2
{
    public partial class frmCalculadora : Form
    {

        public class var_Global
        {
            public static double valor_Inicial = 0.0;
            public static double resultado = 0.0;
            public static string operacao = "";
            public static bool Limpar = false;
        }
        public frmCalculadora()
        {
            InitializeComponent();
        }

        public void operacao_Digito(string valor)
        {
            if (var_Global.Limpar)
            {
                txt_Visor.Text = "";
                var_Global.Limpar = false;
            }

            txt_Visor.Text += valor;
            var_Global.valor_Inicial = Convert.ToDouble(txt_Visor.Text);


        }

        public void auxiliar_Operacao()
        {
            var_Global.resultado = var_Global.valor_Inicial;
            var_Global.valor_Inicial = 0;
            var_Global.Limpar = true;
        }
        public void operacao(string valor)
        {
            switch (valor)
            {

                case "+":
                    auxiliar_Operacao();
                    var_Global.operacao = "+";
                    break;

                case "-":
                    auxiliar_Operacao();
                    var_Global.operacao = "-";
                    break;

                case "*":
                    auxiliar_Operacao();
                    var_Global.operacao = "*";
                    break;

                case "=":

                    if (var_Global.operacao == "+")
                    {
                        var_Global.resultado += var_Global.valor_Inicial;
                    }

                    if (var_Global.operacao == "-")
                    {
                        var_Global.resultado -= var_Global.valor_Inicial;
                    }

                    if (var_Global.operacao == "*")
                    {
                        var_Global.resultado *= var_Global.valor_Inicial;
                    }

                    var_Global.valor_Inicial = 0;
                    txt_Visor.Text = var_Global.resultado.ToString();

                    break;

                default:
                    break;

            }
            var_Global.valor_Inicial = Convert.ToDouble(txt_Visor.Text);

        }



        private void btn_0_Click(object sender, EventArgs e)
        {
            operacao_Digito("0");
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            operacao_Digito("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            operacao_Digito("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            operacao_Digito("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            operacao_Digito("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            operacao_Digito("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            operacao_Digito("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            operacao_Digito("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            operacao_Digito("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            operacao_Digito("9");
        }

        private void btn_Virgula_Click(object sender, EventArgs e)
        {
            txt_Visor.Text += ",";
        }

        private void txt_Visor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Impede que o caracter seja digitado
                e.Handled = true;

            }
        }

        private void btn_LimparVisor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valor inicial = " + var_Global.valor_Inicial.ToString());
        }

        private void btn_Somar_Click(object sender, EventArgs e)
        {
            operacao("+");
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            operacao("=");
        }

        private void btn_Subtrair_Click(object sender, EventArgs e)
        {
            operacao("-");
        }

        private void btn_LimparCalculo_Click(object sender, EventArgs e)
        {
            var_Global.valor_Inicial = 0;
            var_Global.resultado = 0;
            var_Global.operacao = "";
            var_Global.Limpar = false;
            txt_Visor.Text = "0";
        }

        private void btn_Multiplicar_Click(object sender, EventArgs e)
        {
            operacao("*");
        }
    }
}