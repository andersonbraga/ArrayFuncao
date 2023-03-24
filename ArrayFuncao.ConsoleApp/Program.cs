using System;
using System.Threading.Channels;

namespace ArrayFuncao.ConsoleApp
{
    internal class Program
    {
        static int[] numeroInteiro = new int[10];
        static void Main(string[] args)
        {
            CriarNumeroInteiro();
            DecrescenteNumeroInteiro();
            CrescenteNumeroInteiro();
            MeioNumeroInteiro();
            MaiorNumeroInteiro();
            MenorNumeroInteiro();
            NegativoNumeroInteiro();





        }
        static void CriarNumeroInteiro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("###################################");
            Console.WriteLine("ENTRADA DE NUMEROS INTEIRO");
            Console.WriteLine("###################################");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < numeroInteiro.Length; i++)
            {
                
                Console.WriteLine($"Digite numeros inteiro {i+1}: ");
                numeroInteiro[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void DecrescenteNumeroInteiro()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("###################################");
            Console.WriteLine("OS 3 MAIORES NUMEROS DA SEQUENCIA");
            Console.WriteLine("###################################");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 3; i++)
            {
                int guardaNumero = numeroInteiro.Max() - i; 
                Console.WriteLine(guardaNumero);
            }
            
        }

        static void CrescenteNumeroInteiro()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("##############################");
            Console.WriteLine("NUMEROS NA ORDEM CRESCENTE");
            Console.WriteLine("##############################");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var numeros in numeroInteiro)
            {
                Console.WriteLine(numeros);
            }
        }

        static void MeioNumeroInteiro()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("##############################");
            Console.WriteLine("NUMEROS DO MEIO");
            Console.WriteLine("##############################");
            Console.ForegroundColor = ConsoleColor.White;
            
                Console.WriteLine(numeroInteiro.Average());
            
        }

        static void MaiorNumeroInteiro()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("###################################");
            Console.WriteLine("O MAIOR NUMERO DA SEQUENCIA");
            Console.WriteLine("###################################");
            Console.ForegroundColor = ConsoleColor.White;
           
                int guardaNumero = numeroInteiro.Max();
                Console.WriteLine(guardaNumero);
            
        }

        static void MenorNumeroInteiro()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("###################################");
            Console.WriteLine("O MENOR NUMERO DA SEQUENCIA");
            Console.WriteLine("###################################");
            Console.ForegroundColor = ConsoleColor.White;
            int guardaNumero = numeroInteiro.Min();
            Console.WriteLine(guardaNumero);
        }

        static void NegativoNumeroInteiro()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("###################################");
            Console.WriteLine("OS NUMEROS NEGATIVOS ");
            Console.WriteLine("###################################");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < numeroInteiro.Length; i++)
            {
                if (numeroInteiro[i] < 0)
                {
                    Console.WriteLine(numeroInteiro[i]);
                }
            }
            
        }
    }
}