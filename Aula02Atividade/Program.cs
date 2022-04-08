using System;
using Aula02Atividade.bin.Entities;

namespace Aula02Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha 1, 2 ou 3: \n"+
            "1-Validar um horário. \n"+
            "2-Validar uma data. \n"+
            "3-Calcular a area de um triangulo." );

            int option=Convert.ToInt32(Console.ReadLine());
            switch (option){
                
                case 1:
                    Hour hour=new Hour();
                    Console.WriteLine(hour.isHourValid());
                    break;
                case 2:
                    Date date=new Date();
                    Console.WriteLine(date.isDateValid());
                    break;
                case 3:
                    Console.WriteLine("Escolheu 3");
                    break;
            }
           
        }
    } 
}
