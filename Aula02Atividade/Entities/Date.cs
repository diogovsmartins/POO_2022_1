using System;
namespace Aula02Atividade.bin.Entities
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(){
            setDate();
        }
          public void setDate(){
            Console.WriteLine("Digite uma data (dd/mm/yyyy) :");
            String hour=Console.ReadLine();
            String[] arrayHour=hour.Split("/");
            this.day=int.Parse(arrayHour[0]);
            this.month=int.Parse(arrayHour[1]);
            this.year=int.Parse(arrayHour[2]);
        }


        public String isDateValid(){
            if(
            this.day>31||
            this.day<1||
            this.month>12||
            this.month<1||
            this.year<=0
            ){
                return "Data inválida.";
            }
            else if(this.month==2 && day>28){
                return "Mês de janeiro só tem 28 dias, data inválida.";
            }
            else if(this.month%2==0 && day>=31){
                return "Data inválida abril, junho, setembro e novembro só tem 30 dias.";
            }else{
                return "Data válida.";
            }
        }
    }
}