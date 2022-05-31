using System;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                    //Cadastrar
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