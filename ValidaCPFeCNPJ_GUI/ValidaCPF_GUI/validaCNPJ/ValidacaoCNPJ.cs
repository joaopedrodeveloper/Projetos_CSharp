using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaCNPJ
{
    class ValidacaoCNPJ
    {
        private string CnpjLimpo { get; set; }
        private string CnpjParcial { get; set; }
        private string NovoCNPJ { get; set; }
        public ValidacaoCNPJ(string cnpj) 
        {
            this.CnpjLimpo = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
            this.Valida();
        }
        public string GeraNovoCNPJ()
        {
            this.CnpjParcial = CnpjLimpo.Substring(0, 12);
            string digito1 = this.CalculaDigito(this.CnpjParcial);
            string digito2 = this.CalculaDigito(this.CnpjParcial + digito1);

            this.NovoCNPJ = this.CnpjParcial + digito1 + digito2;

            return this.NovoCNPJ;
        }

        private string CalculaDigito(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma = 0;
            int resto;

            if (cnpj.Length < 13) 
            {
                for (int i = 0; i < cnpj.Length; i++)
                {
                    soma += Convert.ToInt32(cnpj[i].ToString()) * multiplicador1[i];
                }
            }
            else
            {
                for (int j = 0; j < cnpj.Length; j++)
                {
                    soma += Convert.ToInt32(cnpj[j].ToString()) * multiplicador2[j];
                }
            }
            resto = (soma % 11);
            return resto < 2 ? "0" : Convert.ToString(11 - resto);
        }

        private bool eSequencia()
        {
            string repeat = new String(CnpjLimpo[0], CnpjLimpo.Length);

            return CnpjLimpo == repeat;
        }

        public bool Valida()
        {
            if (this.CnpjLimpo == "") return false;
            if (this.CnpjLimpo.Length < 11 || this.CnpjLimpo.Length > 14) return false;
            if (this.eSequencia()) return false;

            this.GeraNovoCNPJ();
            return this.NovoCNPJ == this.CnpjLimpo;
        }
    }
}
