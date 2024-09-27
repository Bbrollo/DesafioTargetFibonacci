

using System.Runtime.InteropServices;

namespace DesafioTargetFibonacci {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe um número inteiro qualquer: ");
            int num = int.Parse(Console.ReadLine());
            int fibo1 = 0;
            int fibo2 = 1;

            if (num == fibo1 || num == fibo2) {
                Console.WriteLine("Número informado pertence à sequência de Fibonacci");
                Environment.Exit(0);
            }

            int proximoFibo;

            while (fibo1 <= num) {
                proximoFibo = fibo1 + fibo2;
                if (proximoFibo == num) {
                    Console.WriteLine("Número informado pertence à sequência de Fibonacci");
                    Environment.Exit(0);
                }
                fibo1 = fibo2;
                fibo2 = proximoFibo;
            }
            Console.WriteLine("Número informado não pertence à sequencia de Fibonacci");

        }
    }
}
