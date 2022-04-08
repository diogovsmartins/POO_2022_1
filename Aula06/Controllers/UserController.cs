using System;
using Aula06.UseCases;

namespace Aula06.Controllers
{
    public class UserController
    {
        private readonly UserUseCase UserUseCases = new();

        public void Menu()
        {
            var operador = string.Empty;

            while (operador != "0")
            {
                Console.WriteLine("Digite 0 para sair da aplicação");
                Console.WriteLine("Digite 1 para adicionar um usuário.");
                Console.WriteLine("Digite 2 para listar um usuário.");
                Console.WriteLine("Digite 3 para listar todos os usuários.");
                Console.WriteLine("Digite 4 para deletar um usuário.");
                Console.WriteLine("Digite 5 para atualizar um usuário.\n");
                operador = Console.ReadLine();

                switch (operador)
                {
                    case "0":
                        Environment.Exit(0);
                        break;

                    case "1":
                        Console.WriteLine("\n" + UserUseCases.SaveUser());
                        break;

                    case "2":
                        Console.WriteLine("\n" + UserUseCases.GetUser());
                        break;

                    case "3":
                        Console.WriteLine("\n" + UserUseCases.GetAllUsers());
                        break;

                    case "4":
                        Console.WriteLine("\n" + UserUseCases.DeleteUser());
                        break;

                    case "5":
                        Console.WriteLine("\n" + UserUseCases.UpdateUser());
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        continue;
                }
            }
        }
    }
}