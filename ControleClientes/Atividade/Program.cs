using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float valPag;
            Console.WriteLine("Informar Nome");
            string varNome = Console.ReadLine();
            Console.WriteLine("Informar Endereço");
            string varEndereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
            string varTipo = Console.ReadLine();
            if(varTipo == "f")
            {
                // --- Pessoa Física ----
                PessoaFisica pf = new PessoaFisica();
                pf.Nome = varNome;
                pf.Endereco = varEndereco;
                Console.WriteLine("Informar CPF:");
                pf.Cpf = Console.ReadLine();
                Console.WriteLine("Informar RG:");
                pf.Rg = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra:");
                valPag = float.Parse(Console.ReadLine());
                pf.PagarImposto(valPag);
                Console.WriteLine("-------- Pessoa Física ---------");
                Console.WriteLine("Nome ..........: " + pf.Nome);
                Console.WriteLine("Endereço ......: " + pf.Endereco);
                Console.WriteLine("CPF ...........: " + pf.Cpf);
                Console.WriteLine("RG ............: " + pf.Rg);
                Console.WriteLine("Valor de Compra: " + 
                pf.Valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + 
                pf.ValorImposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " + 
                pf.Total.ToString("C"));
            }

            if(varTipo == "j")
            {
                // Pessoa Jurídica
                PessoaJuridica pj = new PessoaJuridica();
                pj.Nome = varNome;
                pj.Endereco = varEndereco;
                Console.WriteLine("Informar CNPJ:");
                pj.Cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE:");
                pj.Ie = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra:");
                valPag = float.Parse(Console.ReadLine());
                pj.PagarImposto(valPag);
                Console.WriteLine("-------- Pessoa Jurídica ---------");
                Console.WriteLine("Nome ..........: " + pj.Nome);
                Console.WriteLine("Endereço ......: " + pj.Endereco);
                Console.WriteLine("CNPJ ..........: " + pj.Cnpj);
                Console.WriteLine("IE ............: " + pj.Ie);
                Console.WriteLine("Valor de Compra: " + 
                pj.Valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + 
                pj.ValorImposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " + 
                pj.Total.ToString("C"));
            }
        }
    }
}