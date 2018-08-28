using Services.Interfaces.Common;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IClientManager:IGeneralManager<CreateClient, UpdateClient, RegisteredClient>
    {
    }
}
