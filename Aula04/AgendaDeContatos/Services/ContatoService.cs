using System.Text;
using AgendaDeContatos.Data;
using AgendaDeContatos.Domain;

namespace AgendaDeContatos.Services
{
    public class ContatoService
    {
        ContatoRepository minhaAgenda=new ContatoRepository();

        public int RetornaProximoId(){
            return minhaAgenda.GetAll().Count+1;
        }

        public string CriarContato(string nome, string telefone){
            minhaAgenda.Save(new Contato(RetornaProximoId(),nome,telefone));
            return "Contato add com sucesso!";
        }

        public string ListarContatos(){

            var builder=new StringBuilder();
            var listaContatos=minhaAgenda.GetAll();
            var quantidadeDeContatos=listaContatos.Count;
            if(quantidadeDeContatos==0){
                builder.AppendLine("Lista Vazia");
            }
            foreach (Contato contato in listaContatos){
                builder.AppendLine($"nome: {contato.Nome}   Id: {contato.Id}");
            }
            return builder.ToString();
        }   
    }
}