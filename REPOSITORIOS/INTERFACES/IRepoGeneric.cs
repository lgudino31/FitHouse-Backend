using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORIOS.INTERFACES
{
    public interface IRepoGeneric<TModels> where TModels : class
    {
        Task<IEnumerable<TModels>> GetAll();
    }

}

