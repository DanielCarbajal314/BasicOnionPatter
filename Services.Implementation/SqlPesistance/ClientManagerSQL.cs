using Domain.Entities;
using Infraestructure.DataMapping;
using Infraestructure.SQLServerRepository.DocumentDB;
using Services.Interfaces;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation.SqlPesistance
{
    public class ClientManagerSQL : IClientManager
    {
        public RegisteredClient Create(CreateClient newRegister)
        {
            using (DocumentContext db = new DocumentContext())
            {
                Client clientEntity = newRegister.ToEntity();
                db.Clients.Add(clientEntity);
                db.SaveChanges();
                return clientEntity.ToDTO();
            }
        }

        public void Delete(int registerId)
        {
            using (DocumentContext db = new DocumentContext())
            {
                Client clientToDelete = db.Clients.Find(registerId);
                db.Entry(clientToDelete).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<RegisteredClient> List()
        {
            using (DocumentContext db = new DocumentContext())
            {
                return db.Clients.ToList().Select(x => x.ToDTO()).ToList();
            }
        }

        public RegisteredClient Search(int registerId)
        {
            using (DocumentContext db = new DocumentContext())
            {
                return db.Clients.Find(registerId).ToDTO();
            }
        }

        public RegisteredClient Update(UpdateClient updateRegister)
        {
            using (DocumentContext db = new DocumentContext())
            {
                Client userToUpdate = db.Clients.Find(updateRegister.Id);
                userToUpdate.Email = updateRegister.Email;
                userToUpdate.Address = updateRegister.Address;
                userToUpdate.Phone = updateRegister.Phone;
                db.SaveChanges();
                return userToUpdate.ToDTO();
            }
        }
    }
}
