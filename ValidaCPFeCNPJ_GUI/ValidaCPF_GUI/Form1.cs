using System;
using System.Windows.Forms;
using ValidaCPF;
using ValidaCNPJ;

namespace ValidaCPF_GUI
{
    public partial class mainPage : Form
    {
        public mainPage()
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

        private void btnValidarCNPJ_Click(object sender, EventArgs e)
        {
            string textCNPJ = maskedCNPJ.Text;
            ValidacaoCNPJ cnpj = new ValidacaoCNPJ(textCNPJ);

            if (cnpj.Valida())
            {
                MessageBox.Show("CNPJ Válido!");
            }
            else
            {
                MessageBox.Show("CNPJ Inválido!");
            }
        }

        private void btnLimparCNPJ_Click(object sender, EventArgs e)
        {
            maskedCNPJ.Clear();
            maskedCNPJ.Focus();
        }

        private void btnSairCNPJ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerarCPF_Click(object sender, EventArgs e)
        {
            GeraCpfValido cpf = new GeraCpfValido();
            maskedCPFGerado.Text = cpf.CpfValido();
        }

        private void btnCopiarCPF_Click(object sender, EventArgs e)
        {
            string textCPFGerado = maskedCPFGerado.Text;
            Clipboard.SetText(textCPFGerado);
        }

        private void btnGerarCNPJ_Click(object sender, EventArgs e)
        {
            GeraCnpjValido cnpj = new GeraCnpjValido();
            maskedCNPJGerado.Text = cnpj.CnpjValido();
        }

        private void btnCopiarCNPJ_Click(object sender, EventArgs e)
        {
            string textCNPJGerado = maskedCNPJGerado.Text;
            Clipboard.SetText(textCNPJGerado);
        }
    }
}
