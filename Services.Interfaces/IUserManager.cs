using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using Services.Interfaces.Common;

namespace Services.Interfaces
{
    public interface IUserManager: IGeneralManager<CreateUser, UpdateUser, RegisteredUser>
    {
    }
}
