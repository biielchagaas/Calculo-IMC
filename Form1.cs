namespace CalcIMC
{
    public partial class Form1 : Form
    {
        //comentário

        //comentário 2
        public Form1()
        {
            InitializeComponent();
            lb_resultado.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string cpf = mtb_cpf.Text;
            string sexo = cb_sexo.Text;
            double peso = Convert.ToDouble(tx_peso.Text);
            double altura = Convert.ToDouble(tx_altura.Text);
            int idade = Convert.ToInt32(tx_idade.Text);

            Pessoa iMC = new Pessoa(nome, cpf, sexo, peso, altura, idade);

            if (Validacoes.Validacao(cpf))
            {
                (double a, string b, string c) = iMC.CalcIMC();
                lb_resultado.Text = ($"{nome}, do CPF {cpf}, do sexo {sexo}!\n" +
                    $"Com {peso} kg, e {altura} metros de altura!\n" +
                    $"Tem o IMC {a.ToString("0.0")}, que é da categoria {b} e tem o grau de obesidade {c}!");
            }
            else
            {
                lb_resultado.Text = ("CPF INVÁLIDO!!");
            }
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tx_nome.Text = string.Empty;
            mtb_cpf.Text = string.Empty;
            cb_sexo.Text = string.Empty;
            tx_peso.Text = string.Empty;
            tx_altura.Text = string.Empty;
            tx_idade.Text = string.Empty;
            lb_resultado.Text = string.Empty;
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}