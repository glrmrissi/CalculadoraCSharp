using System.ComponentModel.DataAnnotations;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        enum Op
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public decimal Res { get; set; }
        public decimal Valor { get; set; }
        private Op OpSelected { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void number_0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void number_1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void number_2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void number_3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void number_4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void number_5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void number_6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void number_7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void number_8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void number_9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            OpSelected = Op.Divisao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void menos_Click(object sender, EventArgs e)
        {
            OpSelected = Op.Subtracao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void mais_Click(object sender, EventArgs e)
        {
            OpSelected = Op.Adicao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void porcentagem_Click(object sender, EventArgs e)
        {
            OpSelected = Op.Multiplicacao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void maisOuMenos_Click(object sender, EventArgs e)
        {
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void ponto_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }


        private void clearAll_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void clearLastCase_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void igual_Click(object sender, EventArgs e)
        {
            switch (OpSelected)
            {
                case Op.Adicao:
                    Res = Valor + Convert.ToDecimal(textBox1.Text);
                    textBox2.Text += Valor + " + " + textBox1.Text + " = " + Res;
                    break;
                case Op.Subtracao:
                    Res = Valor - Convert.ToDecimal(textBox1.Text);
                    textBox2.Text += Valor + " - " + textBox1.Text + " = " + Res;
                    break;
                case Op.Multiplicacao:
                    Res = Valor * Convert.ToDecimal(textBox1.Text);
                    textBox2.Text += Valor + " * " + textBox1.Text + " = " + Res;
                    break;
                case Op.Divisao:
                    Res = Valor / Convert.ToDecimal(textBox1.Text);
                    textBox2.Text += Valor + " / " + textBox1.Text + " = " + Res;
                    break;
            }
            textBox1.Text = Convert.ToString(Res);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
