using System.Globalization;

namespace ExercicioSec5
{
    class Conta
    {
        public int Numero { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }
        public Conta(int numero, string nomeTitular)
        {
            Numero = numero;
            NomeTitular = nomeTitular;
        }

        public Conta(int numero, string nomeTitular, double saldo) : this(numero, nomeTitular)
        {
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public void Saque(double valor)
        {
            //5 é a taxe de saque
            Saldo -= (valor + 5.00);
        }
        public override string ToString()
        {
            return
            "Conta " +
            + Numero
            + ", Titular: "
            + NomeTitular
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
