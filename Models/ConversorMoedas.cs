using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angelo_Projetos.Models
{
    public class ConversorMoedas
    {
        public int Valor { get; set; }
        public decimal TaxaCambio { get; set; }
        public ConversorMoedas (int valor, decimal taxaCambio)
        {
            Valor = valor;
            TaxaCambio = taxaCambio;
        }

        public ConversorMoedas()
        {
        }

        public void TabelaConversor()
        {
            Console.WriteLine("Conversor de valores:\n-----------------\n1-Converter valores escolhendo valor e taxa.\n2-Converter valores sem escolher.\nDigite a opção desejada: \n");
        }
        public void ConverterValores()
        {
            Console.WriteLine("Digite o valor que sera convertido: ");
            int Valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a taxa de cambio:");
            decimal TaxaCambio = Convert.ToDecimal(Console.ReadLine());   
            while(TaxaCambio == 0)
            {
                Console.WriteLine("A taxa de cambio não pode ser zero.");
                Console.WriteLine("Digite a taxa de cambio:");
                TaxaCambio = Convert.ToDecimal(Console.ReadLine());  
            }
            Console.WriteLine($"Convertendo R${Valor} com a taxa de {TaxaCambio}% : R${Valor/TaxaCambio} ");
        }
        public void ConverterValoresRandom()
        {
            Random randNum = new Random();
            int Valor = randNum.Next(10000);
            decimal TaxaCambio = randNum.Next(10);
            while(TaxaCambio == 0)
            {
               TaxaCambio = randNum.Next(10); 
            }
            Console.WriteLine($"Convertendo R${Valor} com a taxa de {TaxaCambio}% : R${Valor/TaxaCambio} ");
        }
    }
}