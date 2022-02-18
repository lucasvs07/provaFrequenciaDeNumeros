using System;

namespace provaFrequenciaDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números serão digitados?");
            string strQuantidadeDeNumeros = Console.ReadLine();
            int quantidadeDeNumeros = Convert.ToInt32(strQuantidadeDeNumeros);

            int[] arrayNumeros = new int [quantidadeDeNumeros];
            for (int i = 0; i < quantidadeDeNumeros; i++)
            {
                Console.WriteLine("Digite um número:");
                string strNumero = Console.ReadLine();
                int numero = Convert.ToInt32(strNumero);
                arrayNumeros[i] = numero;

            }
            foreach (var item in arrayNumeros)
            {
                Console.Write(item.ToString());
            }

        }
    }
}
