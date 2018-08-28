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
    public class ClientController : ApiController
    {
        IClientManager _clientManager;

        public ClientController()
        {
            this._clientManager = new ClientManagerSQL();
        }

        [HttpPost]
        public RegisteredClient Create(CreateClient newRegister)
        {
            return this._clientManager.Create(newRegister);
        }

        [HttpDelete]
        public void Delete(int registerId)
        {
            this._clientManager.Delete(registerId);
        }

        [HttpGet]
        public List<RegisteredClient> List()
        {
            return this._clientManager.List();
        }

        [HttpGet]
        public RegisteredClient Search(int registerId)
        {
            return this._clientManager.Search(registerId);
        }

        [HttpPut]
        public RegisteredClient Update(UpdateClient updateRegister)
        {
            return this._clientManager.Update(updateRegister);
        }
    }
}
