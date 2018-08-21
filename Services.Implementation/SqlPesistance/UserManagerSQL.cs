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
    public class UserManagerSQL : IUserManager
    {
        public RegisteredUser Create(CreateUser createUserData)
        {
            using (DocumentContext db = new DocumentContext())
            {
                User userEntity = createUserData.ToEntity();
                db.Users.Add(userEntity);
                db.SaveChanges();
                return userEntity.ToDTO();
            }
        }

        public void Delete(int userId)
        {
            using (DocumentContext db = new DocumentContext())
            {
                User userToDelete = db.Users.Find(userId);
                db.Entry(userToDelete).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<RegisteredUser> List()
        {
            using (DocumentContext db = new DocumentContext())
            {
                return db.Users.ToList().Select(x=>x.ToDTO()).ToList();
            }
        }

        public RegisteredUser Search(int userId)
        {
            using (DocumentContext db = new DocumentContext())
            {
                return db.Users.Find(userId).ToDTO();
            }
        }

        public RegisteredUser Update(UpdateUser updateUserData)
        {
            using (DocumentContext db = new DocumentContext())
            {
                User userToUpdate = db.Users.Find(updateUserData.Id);
                userToUpdate.LastNames = updateUserData.LastNames;
                userToUpdate.Names = updateUserData.Names;
                userToUpdate.Password = updateUserData.Password;
                db.SaveChanges();
                return userToUpdate.ToDTO();
            }
        }
    }
}
