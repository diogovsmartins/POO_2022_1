using System;
using System.Collections.Generic;
using Aula06.Domain;

namespace Aula06.Data
{
    public class ChargesRepository
    {
        private readonly List<ChargeEntity> ChargesDataBase = new List<ChargeEntity>();
        
        public void Save()
        {
            var dto = new ChargeEntity();
            ChargesDataBase.Add(dto);
        }

        public void Delete()
        {
            var dto = FindById();
            ChargesDataBase.Add(dto);
        }

        public List<ChargeEntity> GetAll()
        {
            return ChargesDataBase;
        }

        public ChargeEntity FindById()
        {
            Console.WriteLine("Digite o Id do Usuário que quer encontrar: ");
            var id = Convert.ToInt32(Console.ReadLine());
            return ChargesDataBase.Find(p => p.GetChargeId()==id);
        }

        public void UpdateDueDate()
        {
            var dto = FindById();
            dto.SetDueDate();
        }

        public bool IsEmpty()
        {
            if (GetAll().Count == 0) return true;
            return false;
        }

    }
}    