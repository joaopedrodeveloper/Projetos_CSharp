using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaCPF
{
    internal class TestePrograma
    {
        private Random rand = new Random();
        private GeraCpfValido gera = new GeraCpfValido();

        public bool TestesPrograma()
        {
            int contadorTestes = 10;

            Console.WriteLine("\nIniciando bateria de testes!");
            while (contadorTestes > 0)
            {
                string repeat = Convert.ToString(rand.Next(1, 10));
                string cpfRepeat = new String(Convert.ToChar(repeat), 11);
                string cpfRepeatFive = new String(Convert.ToChar(repeat), 5);

                string cpfGerado = gera.RandCPF();
                string cpfGeradoInvalido = gera.RandCPFInvalido();
                string cpfGeradoValido = gera.CpfValido();

                string[] arrayCpfsTestes = new string[] { cpfGerado, cpfGeradoValido, cpfGeradoInvalido, cpfRepeat, cpfRepeatFive, "abc", ".."};

                Console.WriteLine($"\nCPFs Gerado para testes: {cpfGerado}, {cpfGeradoValido}, {cpfGeradoInvalido}, {cpfRepeat}, {cpfRepeatFive}");

                foreach (string cpfs in arrayCpfsTestes)
                {
                    ValidacaoCPF cpf = new ValidacaoCPF(cpfs);

                    if (cpf.Valida())
                    {
                        Console.WriteLine($"{cpfs} Válido!");
                    }
                    else
                    {
                        Console.WriteLine($"{cpfs} Inválido!");
                    }
                }
                contadorTestes--;
            }
            Console.WriteLine("\nFim dos testes!");

            return false;
        }
    }
}
