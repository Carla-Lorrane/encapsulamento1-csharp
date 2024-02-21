
using ProgramBanco_pasta1;
using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)

        {

            ContaBancaria conta;



            Console.Write( "Entre com o número da conta : ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write(" Entre com o titular da conta ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial (S / N )");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 'S' ||resposta == 's')
            {
                Console.Write("Entre com o valor do deposito inicial : ");
                double DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero, titular, DepositoInicial);

            }

            else{
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta : ");
            Console.WriteLine(conta );

            Console.WriteLine();
            Console.WriteLine( "Entre um valor para deposito : ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre um valor para saque : ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);



        }
    }
}