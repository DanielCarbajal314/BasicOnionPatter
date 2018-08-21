using Domain.Entities;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DataMapping
{
    public static class UserMap
    {
        static public User ToEntity(this CreateUser createUserData)
        {
            return new User()
            {
                Names = createUserData.Names,
                LastNames = createUserData.LastNames,
                Email = createUserData.Email,
                Login = createUserData.Login,
                Password = createUserData.Password
            };
        }

        static public RegisteredUser ToDTO(this User userEntity)
        {
            return new RegisteredUser()
            {
                Id = userEntity.Id,
                CompleteName = userEntity.Names + " " + userEntity.LastNames,
                Login = userEntity.Login,
                Email = userEntity.Email
            };
        }

    }
}
