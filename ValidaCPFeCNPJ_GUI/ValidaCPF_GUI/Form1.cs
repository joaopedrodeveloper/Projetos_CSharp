using System;
using System.Windows.Forms;
using ValidaCPF;

namespace ValidaCPF_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string textCPF = maskedCPF.Text;
            ValidacaoCPF cpf = new ValidacaoCPF(textCPF);

            if(cpf.Valida())
            {
                MessageBox.Show("CPF Válido!");
            }
            else
            {
                MessageBox.Show("CPF Inválido!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            maskedCPF.Clear();
            maskedCPF.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
