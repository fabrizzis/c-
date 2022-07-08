using System;

namespace meuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta_do_fabrizis = new ContaCorrente ("Barbara", 12345, 123, 10);
            ContaCorrente conta_do_guigui = new ContaCorrente ("Maria", 12345, 789, 100);
            ContaCorrente conta_do_titi = new ContaCorrente ("Joao", 12345, 456, 1000);


            Console.WriteLine("A conta é do " + conta_do_fabrizis.Titular + 
            ", a agência é " + conta_do_fabrizis.Agencia + " e o número é " 
            + conta_do_fabrizis.Numero + ".");

            Console.WriteLine("A conta é do " + conta_do_guigui.Titular + 
            ", a agência é " + conta_do_guigui.Agencia + " e o número é " 
            + conta_do_guigui.Numero + ".");

            Console.WriteLine("A conta é do " + conta_do_titi.Titular + 
            ", a agência é " + conta_do_titi.Agencia + " e o número é " 
            + conta_do_titi.Numero + ".");

            bool sacar_conta = conta_do_fabrizis.Sacar(100);
            bool sacar_conta1 = conta_do_guigui.Sacar(100);
            bool sacar_conta2 = conta_do_titi.Sacar(100);

        }
    }
}
