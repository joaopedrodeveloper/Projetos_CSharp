using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaCPF
{
    internal class GeraCpfValido
    {
        Random rand = new Random();
        private string Aleatorio { get; set; }

        public string RandCPF()
        {
            Aleatorio = Convert.ToString(rand.NextInt64(100000000, 999999999));

            return Aleatorio;
        }

        public string RandCPFInvalido() 
        {
            Aleatorio = Convert.ToString(rand.NextInt64(10000000000, 99999999999));

            return this.CpfValidoFormatado(Aleatorio);
        }

        public string CpfValido()
        {
            string geraCpfValido = this.RandCPF();
            ValidacaoCPF cpf = new ValidacaoCPF(geraCpfValido);
            string cpfGerado = cpf.GeraNovoCpf();
            
            return this.CpfValidoFormatado(cpfGerado);
        }

        public string CpfValidoFormatado(string cpf)
        {
            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }
    }
}
