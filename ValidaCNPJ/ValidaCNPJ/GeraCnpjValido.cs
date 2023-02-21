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
            this.Aleatorio = Convert.ToString(rand.NextInt64(10000000, 99999999));

            return this.Aleatorio + "0001";
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
            return Convert.ToUInt64(cnpjGerado).ToString(@"00\.000\.000\/0000\-00");
        }
    }
}
