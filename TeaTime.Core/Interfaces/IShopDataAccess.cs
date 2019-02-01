using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaTime.Core.Entities;

namespace TeaTime.Core.Interfaces
{
    public interface IShopDataAccess
    {
        IEnumerable<Shop> GetAll();
    }
}
