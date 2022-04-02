namespace AgendaDeContatos.Domain
{
    public class Contato
    {
        public int Id {get; set;}
        public string Nome{get;set;}
        public string Telefone{get;set;}

        public Contato(int Id, string nome, string telefone)
        {
            this.Id=Id;
            this.Nome=nome;
            this.Telefone=telefone;
        }
    }
}