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
        public double Aleatorio { get; set; }

        public string RandCPF()
        {
            Aleatorio = rand.NextInt64(100000000, 999999999);
            string aleatorioStr = Convert.ToString(Aleatorio);

            return aleatorioStr;
        }

        public string RandCPFMaior() 
        {
            Aleatorio = rand.NextInt64(10000000000, 99999999999);
            string aleatorioStr = Convert.ToString(Aleatorio);
            return this.CpfValidoFormatado(aleatorioStr);
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
