using System.Collections.Generic;
using AgendaDeContatos.Domain;

namespace AgendaDeContatos.Data
{
    public class ContatoRepository
    {
        private List<Contato> listaDeContatos=new List<Contato>();

        public List<Contato> GetAll(){
            return listaDeContatos;
        }
        public void Save(Contato contato){
            listaDeContatos.Add(contato);
        }

        public Contato GetById(int idContato){
            return listaDeContatos.Find(p=>p.Id==idContato);
        }

        public void Update(Contato contato){
            var contatoEditado = listaDeContatos.Find(p=>p.Id==contato.Id);
            contatoEditado.Nome=contato.Nome;
            contatoEditado.Telefone=contato.Telefone;
        }

        public void Delete(Contato contato){
            listaDeContatos.Remove(contato);
        }
    }
}