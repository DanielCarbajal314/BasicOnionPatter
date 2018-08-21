using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Common
{
    public interface IGeneralManager<NewRegister,UpdateRegister,GeneralRegister>
    {
        GeneralRegister Create(NewRegister newRegister);
        List<GeneralRegister> List();
        GeneralRegister Update(UpdateRegister updateRegister);
        void Delete(int registerId);
        GeneralRegister Search(int registerId);
    }
}
