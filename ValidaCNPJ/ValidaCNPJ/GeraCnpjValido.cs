using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaCNPJ
{
    class GeraCnpjValido
    {
        private Random rand = new Random();
        private string Aleatorio { get; set; }

        private string RandCNPJ()
        {
            this.Aleatorio = Convert.ToString(rand.NextInt64(100000000000, 999999999999));

            return this.Aleatorio;
        }

        public string CnpjValida() 
        {
            string geraCnpjAleatorio = this.RandCNPJ();
            ValidacaoCNPJ cnpj = new ValidacaoCNPJ(geraCnpjAleatorio);
            string cnpjGerado = cnpj.GeraNovoCNPJ();

            return this.CnpjValidoFormatado(cnpjGerado);
        }

        private string CnpjValidoFormatado(string cnpjGerado)
        {
            return Convert.ToUInt64(cnpjGerado).ToString(@"");
        }
    }
}
