using System;
namespace Aula02Atividade.bin.Entities
{
    public class Hour
    {
        private int hour;
        private int minutes;
        private int seconds;

        public Hour(){
           setHora();
        }

        public void setHora(){
            Console.WriteLine("Digite a hora (hh:mm:ss) :");
            String hour=Console.ReadLine();
            String[] arrayHour=hour.Split(":");
            this.hour=int.Parse(arrayHour[0]);
            this.minutes=int.Parse(arrayHour[1]);
            this.seconds=int.Parse(arrayHour[2]);
        }
        public String isHourValid(){
            if(this.hour<=0 ||this.hour>24 || this.minutes>60 || this.minutes<0 || this.seconds>60 || this.seconds<0){
                return "Horário é inválido.";
            }
            return "Horario válido: "+this.hour+":"+this.minutes+":"+this.seconds;
        }
    }
    
}