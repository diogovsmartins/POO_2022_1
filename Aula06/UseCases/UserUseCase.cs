using System.Text;
using Aula06.Data;

namespace Aula06.UseCases
{
    public class UserUseCase
    {
        private readonly UserRepository userRepository = new();

        public string SaveUser()
        {
            userRepository.Save();
            return "\n Usuário salvo com sucesso";
        }

        public string GetUser()
        {
            return userRepository.FindByName().ToString();
        }

        public string UpdateUser()
        {
            userRepository.Update();
            return "\n Usuário atualizado com sucesso.";
        }

        public string DeleteUser()
        {
            userRepository.Delete();
            return "\n Usuário deletado com sucesso";
        }

        public string GetAllUsers()
        {
            var builder = new StringBuilder();
            var users = userRepository.GetAll();
            if (userRepository.IsEmpty() == false)
            {
                foreach (var user in users) builder.AppendLine(user.ToString());

                return builder.ToString();
            }

            return "\n Não existem Usuários para retornar.";
        }
    }
}