using System;
using ValidaCNPJ;

public class Cnpj 
{ 
    public static void Main(string[] args)
    {
        GeraCnpjValido cnpj = new GeraCnpjValido();
        Console.WriteLine(cnpj.CnpjValida());
        //ValidacaoCNPJ cnpj = new ValidacaoCNPJ("58.538.757/0001-13");
        //Console.WriteLine(cnpj.Valida());
    }
}