using System;
using System.Text.RegularExpressions;
using ValidaCPF;

public class Cpf
{
    public static void Main(string[] args)
    {
        //ValidacaoCPF cpf = new ValidacaoCPF("123.456.789-09");
        //if (cpf.Valida())
        //{
        //    Console.WriteLine("CPF Válido!");
        //}
        //else
        //{
        //    Console.WriteLine("CPF Inválido!");
        //}

        //GeraCpfValido cpf = new GeraCpfValido();
        //Console.WriteLine(cpf.CpfValido());

        TestePrograma testes = new TestePrograma();
        testes.TestesPrograma();
    }
}
