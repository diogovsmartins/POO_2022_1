using System;
using System.Collections.Generic;

namespace Aula06.Domain
{
    public class UserEntity
    {
        private static int Users = 1;
        private List<ChargeEntity> Bills;
        private string Cellphone;
        private readonly int UserId;
        private string UserName;

        public UserEntity()
        {
            SetUserName();
            SetCellphone();
            UserId = Users;
            Users++;
        }

        public string GetUserName()
        {
            return UserName;
        }

        public void SetUserName()
        {
            Console.Write("Digite o Nome do Usuário: ");
            UserName = Console.ReadLine();
        }

        public void SetCellphone()
        {
            Console.Write("Digite o número de telefone do usuário: ");
            Cellphone = Console.ReadLine();
        }

        public void AddBill(ChargeEntity chargeEntity)
        {
            Bills.Add(chargeEntity);
        }

        public void PayBill(ChargeEntity bill)
        {
            Bills.Remove(bill);
        }

        public string ToString()
        {
            return "|---------------------------------------|" +
                   "\n|USER ID: " + UserId +
                   "\n|---------------------------------------|" +
                   "\n|USERNAME: " + UserName +
                   "\n|---------------------------------------|" +
                   "\n|CELLPHONE: " + Cellphone +
                   "\n|---------------------------------------|\n";
        }
    }
}