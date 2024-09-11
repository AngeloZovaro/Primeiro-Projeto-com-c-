using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angelo_Projetos.Models
{
    public class Nota
    {
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public Nota(string titulo, string conteudo)
        {
            Conteudo = conteudo;
            Titulo = titulo;
        }

        public Nota()
        {
        }

        public void ApresentarNota(){
            Console.WriteLine("Programa de notas:\n-----------------\n1-Adicionar Notas\n2-Vizualizar notas.\nDigite a opção desejada: \n");
        }
        public void CriarNota(List<Nota> notas)
        {
            Console.WriteLine("Digite o titulo da nota: ");
            string titulo = Console.ReadLine();
            Console.WriteLine("Digite o conteudo da nota: ");
            string conteudo = Console.ReadLine();

            Nota nota = new Nota(titulo, conteudo);
            notas.Add(nota);
        }
        public void ExibirNotas(List<Nota> notas)
        {
            int n = 0;
            foreach (Nota notaz in notas)
            {
                Console.WriteLine($"Exibindo nota: {n+1}");
                Console.WriteLine(notaz.Titulo);
                Console.WriteLine(notaz.Conteudo);
                n+=1;
            }
        }
        
    }

}