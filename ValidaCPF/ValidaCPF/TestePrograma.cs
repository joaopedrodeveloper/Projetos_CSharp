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

        private string cpfGerado { get; set; }
        private string cpfGeradoInvalido { get; set; }
        private string cpfGeradoValido { get; set; }
        private string[] arrayCpfsTestes { get; set; }
        private string repeat { get; set; }
        private string cpfRepeat { get; set; }
        private string cpfRepeatFive { get; set; }

        public bool TestesPrograma()
        {
            int contadorTestes = 100;

            Console.WriteLine("\nIniciando bateria de testes!");
            while (contadorTestes > 0)
            {
                repeat = Convert.ToString(rand.Next(1, 10));
                cpfRepeat = new String(Convert.ToChar(repeat), 11);
                cpfRepeatFive = new String(Convert.ToChar(repeat), 5);

                cpfGerado = gera.RandCPF();
                cpfGeradoInvalido = gera.RandCPFMaior();
                cpfGeradoValido = gera.CpfValido();

                arrayCpfsTestes = new string[] { cpfGerado, cpfGeradoValido, cpfGeradoInvalido, cpfRepeat, cpfRepeatFive, "abc", ".."};

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
