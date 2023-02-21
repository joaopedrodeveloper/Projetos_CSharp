using System;

namespace ValidaCPF
{
    class ValidacaoCPF
    {
        private string CpfLimpo { get; set; }
        private string NovoCpf { get; set; }
        private string CpfNumeros { get; set; }

        public ValidacaoCPF(string cpf)
        {
            this.CpfLimpo = cpf.Trim().Replace(".", "").Replace("-", "");
            this.Valida();
        }

        public string CalculaDigitos(string cpfNumeros)
        {
            int soma = 0;
            int resto;

            int multiplicador = cpfNumeros.Length + 1;

            for (int i = 0; i < cpfNumeros.Length; i++)
            {
                soma += int.Parse(cpfNumeros[i].ToString()) * multiplicador--;
            }

            resto = 11 - (soma % 11);
            string digito = resto <= 9 ? resto.ToString() : "0";

            return digito;
        }

        public string GeraNovoCpf()
        {
            this.CpfNumeros = CpfLimpo.Substring(0, 9);
            string digito1 = CalculaDigitos(this.CpfNumeros);
            string digito2 = CalculaDigitos(CpfNumeros + digito1);
            this.NovoCpf = CpfNumeros + digito1 + digito2;

            return this.NovoCpf;
        }

        public bool Valida()
        {
            if (this.CpfLimpo == "") return false;
            if (this.CpfLimpo.Length < 11) return false;
            if (this.eSequencia()) return false;

            this.GeraNovoCpf();

            return this.NovoCpf == CpfLimpo;
        }

        public bool eSequencia()
        {
            string repeat = new String(CpfLimpo[0], CpfLimpo.Length);

            return CpfLimpo == repeat;
        }
    }
}