using System;
using System.Globalization;

namespace ExercicioSec5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o Numero da Conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Titular da Conta: ");
            string nomeTitual = Console.ReadLine();

            Conta cn; //= new Conta(conta, nomeTitual);

            Console.Write("Haverá depósito inicial (s/n)? ");
            if (Console.ReadLine().ToLower() == "s")
            {
                Console.Write("Entre com valor do depósito inicial: ");
                //cn.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                cn = new(conta, nomeTitual, double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
            else 
            { 
                cn = new(conta, nomeTitual); 
            }

            Console.WriteLine("\nDados da conta");
            Console.WriteLine(cn);

            Console.Write("\nEntre com um valor para depósito: ");
            cn.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(cn.ToString());

            Console.Write("\nEntre com um valor para saque: ");
            cn.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(cn.ToString());
        }
    }
}
