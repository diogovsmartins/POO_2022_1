using System;
using AgendaDeContatos.Controllers;

namespace AgendaDeContatos
{
    class Program
    {
        static void Main(string[] args)
        {
            ContatoController agenda=new ContatoController();
            agenda.Menu();
        }
    }
}
