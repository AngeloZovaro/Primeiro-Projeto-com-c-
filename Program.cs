using System;
using Angelo_Projetos.Models;
Calculadora calc = new Calculadora();
Nota cnota = new Nota();
ConversorMoedas conversor = new ConversorMoedas();
Random randNum = new Random();

Console.WriteLine("Projetos Angelo C#:\n1-Calculadora.\n2-Notas.\n3-Conversor de valores\nDigite a opção desejada: \n");
int projeto = Convert.ToInt32(Console.ReadLine());
Console.Clear();
bool boolprojeto = true;
while(boolprojeto == true){
    switch(projeto)
    {
        case 1:
        int numero1 = 0;
        int numero2 = 0;
        bool boolcalc = true;
        while (boolcalc == true)
        {
            int operacao = calc.Tabela();
            int opcaoRandom = calc.GerarRandom();
            if (opcaoRandom == 1)
            {
                Console.WriteLine("Digite o primeiro número: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                numero2 = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                numero1 = randNum.Next(100);
                numero2 = randNum.Next(100);
            }
            switch(operacao)
            {
                case 1:
                    Console.WriteLine($"O resultado da soma: {numero1} + {numero2} = {calc.Somar(numero1,numero2)}");
                    break;
                case 2:
                    Console.WriteLine($"O resultado da subtração: {numero1} - {numero2} = {calc.Subtrair(numero1,numero2)}");
                    break;
                case 3:
                    Console.WriteLine($"O resultado da multiplicação: {numero1} * {numero2} = {calc.Multiplicar(numero1,numero2)}");
                    break;
                case 4:
                    Console.WriteLine($"O resultado da divisão: {numero1} / {numero2} = {calc.Dividir(numero1,numero2)}");
                    break;
                case 5:
                    boolcalc = false;
                    break;
                default:
                    Console.WriteLine("Opcao invalida.");
                    break;
            }
        }
        break;
    case 2:
        List<Nota> notas = new List<Nota>();
        bool boolnotas = true;
        while (boolnotas == true){
            cnota.ApresentarNota();
            int opcaonota = Convert.ToInt32(Console.ReadLine());
            switch(opcaonota)
            {
                case 1:
                    cnota.CriarNota(notas);
                    Console.Clear();
                    Console.WriteLine("Nota adicionada com sucesso!\n");
                    break;
                case 2:
                    Console.Clear();
                    cnota.ExibirNotas(notas);
                    break;
                case 3:
                    boolnotas = false;
                    break;
            }   
        }
        break;
    case 3:
        conversor.TabelaConversor();
        int opcaoConversao = Convert.ToInt32(Console.ReadLine());
        switch(opcaoConversao)
        {
            case 1:
                conversor.ConverterValores();
            break;
            case 2:
                conversor.ConverterValoresRandom();
            break;
            default:
                Console.WriteLine("Opção invalida.");
            break;
        }
    break;
    default: 
        Console.WriteLine("Opção invalida.");
        break;
    }
}


