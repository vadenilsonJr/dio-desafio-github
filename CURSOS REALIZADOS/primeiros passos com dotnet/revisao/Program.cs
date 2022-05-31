using System;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                    Console.WriteLine("Digite o nome do Aluno:");
                    var aluno = new Aluno();
                    aluno.Nome = Console.ReadLine();

                    Console.WriteLine("Digite a nota desse Aluno:");
                    if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                    {
                        aluno.Nota = nota;
                    }
                    else
                    {
                        throw new ArgumentException("A nota deve ser decimal");
                    }

                    alunos[indiceAluno] = aluno;
                    indiceAluno++; 

                        break;
                    case "2":
                    //Listar
                        break;
                    case "3":
                    //Calcular
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                    opcaoUsuario = ObterOpcaoUsuario();     
            }
        }

        private static string ObterOpcaoUsuario()
        {    
            Console.WriteLine();
            Console.WriteLine("Informe a opcao desejada");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular media geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}