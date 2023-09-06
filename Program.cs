//Samara Machado - 202220926
using System;

namespace controleContas {
    class Program {
        static void Main(string[] args) {
            
            Conta conta1 = new Conta();
            conta1.Numero = 12345678;
            Console.WriteLine(conta1.Numero);
        }
    }
}