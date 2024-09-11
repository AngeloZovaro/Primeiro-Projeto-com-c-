using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Angelo_Projetos.Models
{
    public class Calculadora
    {
        public int GerarRandom()
        {
            Console.WriteLine("Deseja escolher o numero para realizar a conta?\nDigite 1 para Sim e 2 para Não");
            int opcaoRandom = Convert.ToInt32(Console.ReadLine());
            return opcaoRandom;
        }
        public int Tabela()
        {
            Console.WriteLine("\nCalculadora\n-------------\n1-Somar\n2-Subtrair\n3-Multiplicar\n4-Dividir\nDigite a opção que desejada:");
            int operacao = Convert.ToInt32(Console.ReadLine());
            return operacao;
        }
        public int Somar(int Numero1, int Numero2)
        {
            return Numero1 + Numero2;
        }
        public int Subtrair(int Numero1, int Numero2)
        {
            return Numero1 - Numero2;
        }
        public int Multiplicar(int Numero1, int Numero2)
        {
            return Numero1 * Numero2;
        }
        public int Dividir(int Numero1, int Numero2)
        {
            return Numero1 / Numero2;
        }


    }
}