using System;
using System.Collections.Generic;
using Aula06.Domain;

namespace Aula06.Data
{
    public class UserRepository
    {
        private readonly List<UserEntity> UserDataBase = new();

        public void Save()
        {
            var dto = new UserEntity();
            UserDataBase.Add(dto);
        }

        public void Delete()
        {
            var dto = FindByName();
            UserDataBase.Remove(dto);
        }

        public List<UserEntity> GetAll()
        {
            return UserDataBase;
        }

        public UserEntity FindByName()
        {
            Console.WriteLine("Digite o nome do Usuário que quer encontrar: ");
            var name = Console.ReadLine();
            return UserDataBase.Find(p => p.GetUserName().Equals(name));
        }

        public void Update()
        {
            var dto = FindByName();
            dto.SetUserName();
            dto.SetCellphone();
        }

        public bool IsEmpty()
        {
            if (GetAll().Count == 0) return true;
            return false;
        }

        public void SaveNewBill()
        {
            FindByName().AddBill(new ChargeEntity());
        }
    }
}