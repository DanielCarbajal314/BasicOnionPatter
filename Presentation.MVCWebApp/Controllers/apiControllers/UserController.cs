using Services.Implementation.SqlPesistance;
using Services.Interfaces;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentation.WebApi.Controllers
{
    public class UserController : ApiController
    {
        IUserManager _userManager;

        public UserController()
        {
            this._userManager = new UserManagerSQL();
        }

        [HttpPost]
        public RegisteredUser Create(CreateUser createUserData)
        {
            return this._userManager.Create(createUserData);
        }

        [HttpDelete]
        public void Delete(int userId)
        {
            this._userManager.Delete(userId);
        }

        [HttpGet]
        public List<RegisteredUser> List()
        {
            return this._userManager.List();
        }

        [HttpGet]
        public RegisteredUser Search(int userId)
        {
            return this._userManager.Search(userId);
        }

        [HttpPut]
        public RegisteredUser Update(UpdateUser updateUserData)
        {
            return this._userManager.Update(updateUserData);
        }
    }
}
